using FastConsig.Auditoria.Helpers;
using FastConsig.Auditoria.Service;
using FastConsig.Common.Loggin;
using FastConsig.Common.Services;
using FastConsig.Core.Entity;
using FastConsig.Core.Model;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using FastConsig.Seguranca.Entity;
using FastConsig.Seguranca.Services;
using Framework.Web.UI;
using Framework.Web.UI.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FastConsig.Core.Web.Credito.SIAPE
{
   public partial class CapturaSIAPE : FastConsigPageBase
   {
      #region Propriedades da Página
      public PropostaModel proposta { get { return GetCrossPageData<PropostaModel>("Proposta"); } }
      #endregion

      #region Metodos da Página
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("MonitorPropostas.aspx");
         txtEnderecoResidencial.Enabled = true;

         if (!IsPostBack)
         {
            ScriptManager scriptManager = ScriptManager.GetCurrent(this.Page);

            AddMessageCollection(PropostaService.GetInstance().ListarEstados(), "Estados");
            AddMessageCollection(PropostaService.GetInstance().ListarRamoAtividade("F"), "RamoAtividade");
            AddMessageCollection(PropostaService.GetInstance().ListarGerente(), "Gerentes");
            AddMessageCollection(PropostaService.GetInstance().ListarPromotoras(), "Promotoras");
            AddMessageCollection(PropostaService.GetInstance().ListarNacionalidades(), "Nacionalidade");
            AddMessageCollection(PropostaService.GetInstance().ListarNacionalidades(), "NacionalidadeDevedorSolidario");
            AddMessageCollection(PropostaService.GetInstance().ListarSexo(), "Sexo");
            AddMessageCollection(PropostaService.GetInstance().ListarEstadoCivil(), "EstadoCivil");
            AddMessageCollection(PropostaService.GetInstance().ListarTipoDocumentoIdentidade(), "TipoDocumentoIdentidade");
            AddMessageCollection(PropostaService.GetInstance().ListarOrgaoEmissor(), "OrgaoEmissor");
            AddMessageCollection(PropostaService.GetInstance().ListarEstados(), "UFEmissaoDocumentoIdentidade");
            AddMessageCollection(PropostaService.GetInstance().ListarMeiosdeLiberacao(), "MeiosLiberacao");
            AddMessageCollection(PropostaService.GetInstance().ListarTiposDocumentoSelecionaveis(), "TipoDocumento");
            AddMessageCollection(PropostaService.GetInstance().ListarTiposDocumentoSelecionaveis(), "TipoDocumentoCheckList");
            AddMessageCollection(PropostaService.GetInstance().ListarTipoComunicacao(), "TipoComunicacao");
            AddMessageCollection(PropostaService.GetInstance().ListarRedeLoja(), "RedeLoja");
            AddMessageCollection(PropostaService.GetInstance().ListarLojas(), "Lojas");
            AddMessageCollection(PropostaService.GetInstance().ListarTipoBeneficioINSS(), "EspecieBeneficio");
            AddMessageCollection(PropostaService.GetInstance().ListarTiposDocumentoSelecionaveis(), "TipoDocumento");
            AddMessageCollection(PropostaService.GetInstance().ListarOcorrencias().Where(x => x.Recusa == true).ToList(), "ListaOcorrenciaRecusa");

            var usuario = this.UserContext?.GetUserData<Usuario>();
            var produtosHabilitados = SegurancaService.GetInstance().ListarProdutosHabilitados(usuario.Id);

            List<Produtos> produtos = new List<Produtos>();

            if (produtosHabilitados == null)
            {
               produtos = new List<Produtos>();
            }
            else
            {
               foreach (UsuarioProduto u in produtosHabilitados)
               {
                  produtos.Add(PropostaService.GetInstance().ObtemProduto(u.Produto));
               }
               produtos = produtos.OrderBy(x => x.Nome).ToList();
            }

            AddMessageCollection(produtos, "Produtos");

            if (Parameters["Comando"] == "Editar")
            {
               Editar(proposta.Id.ToString());
               BloqueiaCampos(proposta);
            }
            else if (Parameters["Comando"] == "Novo")
               Novo();

            DataBind();
         }
         else
         {
            DataUnbind();
            var proposta = GetMessage<PropostaModel>("PropostaModel");

            rptOcorrencias.DataSource = proposta.Ocorrencias;
            rptOcorrencias.DataBind();
            rptOcorrenciasCheckList.DataSource = PropostaService.GetInstance().ListarItensCheckListProposta(proposta.Id);
            rptOcorrenciasCheckList.DataBind();
            rptArquivos.DataSource = this.ListarArquivosPropostaAutorizados(proposta);
            rptArquivos.DataBind();
            rptLog.DataSource = PropostaService.GetInstance().ListarHistorico(proposta.Id, proposta.Operacoes.Simulacao).OrderByDescending(x => x.DataExecucao);
            rptLog.DataBind();


            DataBind();
         }
      }

      protected void btnRejeitarProposta_Click(object sender, EventArgs e)
      {
         //TODO: Implementar
         if (!VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Rejeitar Proposta"))
         {
            ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
            return;
         }

         try
         {
            DataUnbind();

            var proposta = GetMessage<PropostaModel>();
            AddMessage<PropostaModel>("PropostaModel", proposta);
            AddMessage("OcorrenciaRecusa", new PropostaOcorrencias { Proposta = proposta.Id, DataOcorrencia = DateTime.Now, Restritiva = "R" });
            AddMessageCollection(PropostaService.GetInstance().ListarOcorrencias().Where(x => x.Recusa == true).Where(x => x.Sistema == false).ToList(), "ListaOcorrenciaRecusa");

            DataBind();

            var masterpage = (SiteMaster)Master;
            pnlPopupJustificativaRecusa.Visible = true;
            masterpage.RegisterStartupScript("ShowModalJustificativaRecusa",
                string.Format("$('#{0}').modal('show');",
                pnlPopupJustificativaRecusa.ClientID));
         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Motivo Recusa"));
         }
      }

      protected void btnSalvar_Click(object sender, EventArgs e)
      {
         DataUnbind();

         var proposta = GetMessage<PropostaModel>("PropostaModel");

         AuditoriaService.GetInstance().CreateAuditTrail(AuditActionType.Update, proposta.Id, Session["Auditoria"], proposta, UserContext.GetUserData<Usuario>().Id);

         PropostaService.GetInstance().GravarHistoricoProposta(proposta, "SalvarProposta");

         PropostaService.GetInstance().DesbloquearProposta(proposta);

         proposta.Status = (proposta.Status == 1 ? proposta.Status : 6);
         PropostaService.GetInstance().SalvarProposta(proposta);
         SetCrossPageData("Proposta", proposta);
         Response.Redirect("/Credito/MonitorPropostas.aspx", false);
      }

      protected void btnSubmeter_Click(object sender, EventArgs e)
      {
         btnSubmeter.Enabled = false;
         DataUnbind();
         var proposta = GetMessage<PropostaModel>("PropostaModel");

         AuditoriaService.GetInstance().CreateAuditTrail(AuditActionType.Update, proposta.Id, Session["Auditoria"], proposta, UserContext.GetUserData<Usuario>().Id);

         proposta.Fase = PropostaService.GetInstance().ObterProposta(proposta.Id).Fase;
         proposta.Status = PropostaService.GetInstance().ObterProposta(proposta.Id).Status;

         // validando se a proposta está bloqueada, caso esteja recupera o usuário para submeter
         if (PropostaService.GetInstance().PropostaBloqueada(proposta.Id))
            proposta.UsuarioProposta = PropostaService.GetInstance().ObterProposta(proposta.Id)?.UsuarioProposta;

         switch (proposta.Fase)
         {
            case 2:
               if (!VerificarPermissaoAcessoAcaoUrl("/Concessao/Monitor.aspx", "Submeter Proposta na Fase CAPTURA"))
               {
                  btnSubmeter.Enabled = true;
                  ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                  return;
               }
               break;
            case 3:
               if (!VerificarPermissaoAcessoAcaoUrl("/Concessao/Monitor.aspx", "Submeter Proposta na Fase MESA PROMOTORA"))
               {
                  btnSubmeter.Enabled = true;
                  ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                  return;
               }
               break;
            case 4:
               if (!VerificarPermissaoAcessoAcaoUrl("/Concessao/Monitor.aspx", "Submeter Proposta na Fase CONSULTA"))
               {
                  btnSubmeter.Enabled = true;
                  ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                  return;
               }
               break;
            case 5:
               if (!VerificarPermissaoAcessoAcaoUrl("/Concessao/Monitor.aspx", "Submeter Proposta na Fase ANÁLISE BACKOFFICE"))
               {
                  btnSubmeter.Enabled = true;
                  ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                  return;
               }
               break;
            case 6:
               if (!VerificarPermissaoAcessoAcaoUrl("/Concessao/Monitor.aspx", "Submeter Proposta na Fase ANÁLISE PLD"))
               {
                  btnSubmeter.Enabled = true;
                  ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                  return;
               }
               break;
            case 7:
               if (!VerificarPermissaoAcessoAcaoUrl("/Concessao/Monitor.aspx", "Submeter Proposta na Fase ASSINATURA DIGITAL"))
               {
                  btnSubmeter.Enabled = true;
                  ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                  return;
               }
               break;
            case 8:
               if (!VerificarPermissaoAcessoAcaoUrl("/Concessao/Monitor.aspx", "Submeter Proposta na Fase AVERBAÇÃO"))
               {
                  btnSubmeter.Enabled = true;
                  ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                  return;
               }
               break;
            case 9:
               if (!VerificarPermissaoAcessoAcaoUrl("/Concessao/Monitor.aspx", "Submeter Proposta na Fase INTEGRAÇÃO"))
               {
                  btnSubmeter.Enabled = true;
                  ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                  return;
               }
               break;
            case 10:
               if (!VerificarPermissaoAcessoAcaoUrl("/Concessao/Monitor.aspx", "Submeter Proposta na Fase RETORNO CRITICA"))
               {
                  btnSubmeter.Enabled = true;
                  ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                  return;
               }
               break;
            default:
               btnSubmeter.Enabled = true;
               ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
               return;
         }

         proposta.Status = (proposta.Status == 11 ? 11 : 12);

         try
         {
            PropostaService.GetInstance().SalvarProposta(proposta);
            PropostaService.GetInstance().SubmeterProposta(proposta);
         }
         catch (Exception ex)
         {
            proposta = PropostaService.GetInstance().ObterProposta(proposta.Id);

            ContratosRepeater.DataSource = proposta.ContratosREFIN;
            ContratosRepeater.DataBind();
            rptArquivos.DataSource = this.ListarArquivosPropostaAutorizados(proposta);
            rptArquivos.DataBind();
            rptTrilhaAuditoria.DataSource = PropostaService.GetInstance().ListarTrilhaAuditoriaProposta(proposta.Id, proposta.Operacoes.Simulacao, proposta.Operacoes.Produto).OrderByDescending(x => x.Date);
            rptTrilhaAuditoria.DataBind();
            ConteudoHistoricoAlteracoes.InnerHtml = AuditoriaService.GetInstance().GetHtmlAudit("PropostaModel", proposta.Id);
            rptLog.DataSource = PropostaService.GetInstance().ListarHistorico(proposta.Id, proposta.Operacoes.Simulacao).OrderByDescending(x => x.DataExecucao);
            rptLog.DataBind();
            rptOcorrencias.DataSource = proposta.Ocorrencias;
            rptOcorrencias.DataBind();
            rptOcorrenciasCheckList.DataSource = PropostaService.GetInstance().ListarItensCheckListProposta(proposta.Id);
            rptOcorrenciasCheckList.DataBind();
            MontaTreeView(proposta);
            ShowMessage(TipoMensagem.Erro, ex.Message);
            btnSubmeter.Enabled = true;
            return;
         }

         ContratosRepeater.DataSource = proposta.ContratosREFIN;
         ContratosRepeater.DataBind();
         rptArquivos.DataSource = this.ListarArquivosPropostaAutorizados(proposta);
         rptArquivos.DataBind();
         rptTrilhaAuditoria.DataSource = PropostaService.GetInstance().ListarTrilhaAuditoriaProposta(proposta.Id, proposta.Operacoes.Simulacao, proposta.Operacoes.Produto).OrderByDescending(x => x.Date);
         rptTrilhaAuditoria.DataBind();
         ConteudoHistoricoAlteracoes.InnerHtml = AuditoriaService.GetInstance().GetHtmlAudit("PropostaModel", proposta.Id);
         rptLog.DataSource = PropostaService.GetInstance().ListarHistorico(proposta.Id, proposta.Operacoes.Simulacao).OrderByDescending(x => x.DataExecucao);
         rptLog.DataBind();
         rptOcorrencias.DataSource = proposta.Ocorrencias;
         rptOcorrencias.DataBind();
         rptOcorrenciasCheckList.DataSource = PropostaService.GetInstance().ListarItensCheckListProposta(proposta.Id);
         rptOcorrenciasCheckList.DataBind();

         MontaTreeView(proposta);

         AddMessage("PropostaModel", proposta);
         DataBind();

         SetCrossPageData("Proposta", proposta);
         Response.Redirect("/Credito/MonitorPropostas.aspx", false);
      }

      protected void btnReenviarLinkAssinatura_Click(object sender, EventArgs e)
      {

      }

      protected void btnReenviarLinkCombateaFraude_Click(object sender, EventArgs e)
      {

      }

      protected void btnReenviarMensagem_Click(object sender, EventArgs e)
      {

      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Credito/MonitorPropostas.aspx", false);
      }

      protected void btnDesbloquearProposta_Click(object sender, EventArgs e)
      {
         btnDesbloquearProposta.Enabled = false;

         proposta.UsuarioProposta = UserContext.GetUserData<Usuario>().Id;
         PropostaService.GetInstance().DesbloquearProposta(proposta, true);
         proposta.Fase = PropostaService.GetInstance().ObterProposta(proposta.Id).Fase;
         proposta.Status = PropostaService.GetInstance().ObterProposta(proposta.Id).Status;


         switch (proposta.Fase)
         {
            case 2:
               if (!VerificarPermissaoAcessoAcaoUrl("/Concessao/Monitor.aspx", "Desbloquear Proposta na Fase CAPTURA"))
               {
                  btnDesbloquearProposta.Enabled = false;
                  ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                  return;
               }
               break;
            case 3:
               if (!VerificarPermissaoAcessoAcaoUrl("/Concessao/Monitor.aspx", "Desbloquear Proposta na Fase MESA PROMOTORA"))
               {
                  btnDesbloquearProposta.Enabled = false;
                  ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                  return;
               }
               break;
            case 4:
               if (!VerificarPermissaoAcessoAcaoUrl("/Concessao/Monitor.aspx", "Desbloquear Proposta na Fase CONSULTA"))
               {
                  btnDesbloquearProposta.Enabled = false;
                  ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                  return;
               }
               break;
            case 5:
               if (!VerificarPermissaoAcessoAcaoUrl("/Concessao/Monitor.aspx", "Desbloquear Proposta na Fase ANÁLISE DE BACKOFFICE"))
               {
                  btnDesbloquearProposta.Enabled = false;
                  ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                  return;
               }
               break;
            case 6:
               if (!VerificarPermissaoAcessoAcaoUrl("/Concessao/Monitor.aspx", "Desbloquear Proposta na Fase ANALISE PLD"))
               {
                  btnDesbloquearProposta.Enabled = false;
                  ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                  return;
               }
               break;
            case 7:
               if (!VerificarPermissaoAcessoAcaoUrl("/Concessao/Monitor.aspx", "Desbloquear Proposta na Fase ASSINATURA DIGITAL"))
               {
                  btnDesbloquearProposta.Enabled = false;
                  ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                  return;
               }
               break;
            case 8:
               if (!VerificarPermissaoAcessoAcaoUrl("/Concessao/Monitor.aspx", "Desbloquear Proposta na Fase AVERBAÇÃO"))
               {
                  btnDesbloquearProposta.Enabled = false;
                  ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                  return;
               }
               break;
            case 9:
               if (!VerificarPermissaoAcessoAcaoUrl("/Concessao/Monitor.aspx", "Desbloquear Proposta na Fase INTEGRAÇÃO"))
               {
                  btnDesbloquearProposta.Enabled = false;
                  ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                  return;
               }
               break;
            default:
               btnDesbloquearProposta.Enabled = false;
               ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
               return;
         }

         ShowMessage(TipoMensagem.Aviso, "Proposta desbloqueada!");
         Editar(proposta.Id.ToString());
         BloqueiaCampos(proposta);
         return;
      }

      protected void btnJustificativaRecusaOk_Click(object sender, EventArgs e)
      {
         DataUnbind();
         var proposta = GetMessage<PropostaModel>("PropostaModel");
         var usuario = this.UserContext?.GetUserData<Usuario>();
         var ocorrencia = GetMessage<PropostaOcorrencias>("OcorrenciaRecusa");
         ocorrencia.Usuario = UserContext.GetUserData<Usuario>().Id;
         ocorrencia.Complemento = proposta.MotivoRecusa;
         proposta.MensagemInterna = proposta.MotivoRecusa;
         PropostaService.GetInstance().InsereOcorrencia(ocorrencia);
         PropostaService.GetInstance().RejeitaProposta(proposta, usuario.Id);
         SetCrossPageData("Proposta", proposta);
         Response.Redirect("/Credito/MonitorPropostas.aspx", false);
      }

      protected void btnPendenciar_Click(object sender, EventArgs e)
      {
         try
         {
            DataUnbind();

            var proposta = GetMessage<PropostaModel>();
            var fase = PropostaService.GetInstance().ObtemFase(proposta.Fase);

            AddMessage("OcorrenciaPendencia", new PropostaOcorrencias { Proposta = proposta.Id, DataOcorrencia = DateTime.Now, Fase = fase.Id, Restritiva = "P" });
            AddMessageCollection(PropostaService.GetInstance().ListarOcorrencias().Where(x => x.Pendencia == true).ToList(), "ListaOcorrenciaPendencia");

            DataBind();

            var masterpage = (SiteMaster)Master;
            pnlPopupPendenciarProposta.Visible = true;
            masterpage.RegisterStartupScript("ShowModalPendenciarProposta",
                string.Format("$('#{0}').modal('show');",
                pnlPopupPendenciarProposta.ClientID));
         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Pendênciar Proposta"));
         }
      }

      protected void btnPendenciarOk_Click(object sender, EventArgs e)
      {
         DataUnbind();
         var proposta = GetMessage<PropostaModel>();
         var ocorrencia = GetMessage<PropostaOcorrencias>("OcorrenciaPendencia");
         ocorrencia.Usuario = UserContext.GetUserData<Usuario>().Id;

         if (ocorrencia.Restritiva == "P")
         {
            var faseDestino = PropostaService.GetInstance().ListarOcorrenciasProdutoXFase(proposta.Operacoes.Produto, PropostaService.GetInstance().ObtemFase(proposta.Fase).Id).Where(x => x.Ocorrencia == ocorrencia.Ocorrencia).FirstOrDefault().FaseDestino;
            var validacoes = PropostaService.GetInstance().ListarOcorrenciasProdutoXFase(proposta.Operacoes.Produto, PropostaService.GetInstance().ObtemFase(proposta.Fase).Id).Where(x => x.Ocorrencia == ocorrencia.Ocorrencia).FirstOrDefault().Validacoes;

            PropostaService.GetInstance().PendenciarProposta(proposta, faseDestino, ocorrencia, UserContext.GetUserData<Usuario>().Id);
            proposta.UsuarioProposta = UserContext.GetUserData<Usuario>().Login;
            PropostaService.GetInstance().DesbloquearProposta(proposta, true);

            if (!string.IsNullOrEmpty(validacoes))
            {
               dynamic pol = JsonConvert.DeserializeObject<dynamic>(validacoes);

               if (!string.IsNullOrEmpty((string)pol.Envio))
               {
                  PropostaService.GetInstance().ExecutaPolitica((string)pol.Envio, proposta, PropostaService.GetInstance().ObtemFase(faseDestino).Id, proposta.Proponente.TipoPessoa);
               }
            }

            Response.Redirect("/Credito/MonitorPropostas.aspx", false);
         }
         else if (ocorrencia.Restritiva == "I")
         {
            PropostaService.GetInstance().InsereOcorrencia(ocorrencia);
            proposta = PropostaService.GetInstance().ObterProposta(proposta.Id);
            rptOcorrencias.DataSource = proposta.Ocorrencias;
            rptOcorrencias.DataBind();
            HiddenTab.Value = "tabOcorrenciasTab";

            SetCrossPageData("Proposta", proposta);
            AddMessage("PropostaModel", proposta);
            DataBind();
         }
         else if (ocorrencia.Restritiva == "S")
         {
            PropostaService.GetInstance().InsereOcorrencia(ocorrencia);
            proposta = PropostaService.GetInstance().ObterProposta(proposta.Id);
            rptOcorrencias.DataSource = proposta.Ocorrencias;
            rptOcorrencias.DataBind();
            HiddenTab.Value = "tabOcorrenciasTab";

            SetCrossPageData("Proposta", proposta);
            AddMessage("PropostaModel", proposta);
            DataBind();
         }
         else if (ocorrencia.Restritiva == "N")
         {
            PropostaService.GetInstance().InsereOcorrencia(ocorrencia);
            proposta = PropostaService.GetInstance().ObterProposta(proposta.Id);
            rptOcorrencias.DataSource = proposta.Ocorrencias;
            rptOcorrencias.DataBind();
            HiddenTab.Value = "tabOcorrenciasTab";

            SetCrossPageData("Proposta", proposta);
            AddMessage("PropostaModel", proposta);
            DataBind();
         }
      }

      protected void btnAdicionarOcorrencia_Click(object sender, EventArgs e)
      {
         try
         {
            DataUnbind();

            var proposta = GetMessage<PropostaModel>();

            AddMessage("AdicionarOcorrencia", new PropostaOcorrencias { Proposta = proposta.Id, DataOcorrencia = DateTime.Now, Fase = proposta.Fase, Restritiva = "I" });
            AddMessageCollection(PropostaService.GetInstance().ListarOcorrencias().Where(x => x.Informativa == true).ToList(), "ListaOcorrenciaAdicionar");

            DataBind();

            var masterpage = (SiteMaster)Master;
            pnlPopupAdicionarOcorrencia.Visible = true;
            masterpage.RegisterStartupScript("ShowModalAdicionarOcorrencia",
                string.Format("$('#{0}').modal('show');",
                pnlPopupAdicionarOcorrencia.ClientID));
         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Adicionar Ocorrência a Proposta"));
         }
      }

      protected void bntAdicionarOcorrenciaOK_Click(object sender, EventArgs e)
      {
         DataUnbind();
         var proposta = GetMessage<PropostaModel>();
         var ocorrencia = GetMessage<PropostaOcorrencias>("AdicionarOcorrencia");
         ocorrencia.Usuario = UserContext.GetUserData<Usuario>().Id;

         if (ocorrencia.Restritiva == "I")
         {
            PropostaService.GetInstance().InsereOcorrencia(ocorrencia);
            proposta = PropostaService.GetInstance().ObterProposta(proposta.Id);
            rptOcorrencias.DataSource = proposta.Ocorrencias;
            rptOcorrencias.DataBind();
            HiddenTab.Value = "tabOcorrenciasTab";

            SetCrossPageData("Proposta", proposta);
            AddMessage("PropostaModel", proposta);
            DataBind();
         }
         else if (ocorrencia.Restritiva == "S")
         {
            PropostaService.GetInstance().InsereOcorrencia(ocorrencia);
            proposta = PropostaService.GetInstance().ObterProposta(proposta.Id);
            rptOcorrencias.DataSource = proposta.Ocorrencias;
            rptOcorrencias.DataBind();
            HiddenTab.Value = "tabOcorrenciasTab";

            SetCrossPageData("Proposta", proposta);
            AddMessage("PropostaModel", proposta);
            DataBind();
         }
         else if (ocorrencia.Restritiva == "N")
         {
            PropostaService.GetInstance().InsereOcorrencia(ocorrencia);
            proposta = PropostaService.GetInstance().ObterProposta(proposta.Id);
            rptOcorrencias.DataSource = proposta.Ocorrencias;
            rptOcorrencias.DataBind();
            HiddenTab.Value = "tabOcorrenciasTab";

            SetCrossPageData("Proposta", proposta);
            AddMessage("PropostaModel", proposta);
            DataBind();
         }

      }
      #endregion

      #region Ajustes de Tela
      protected void ddlMeioLiberacao_SelectedIndexChanged(object sender, EventArgs e)
      {
         DataUnbind();
         var proposta = GetMessage<PropostaModel>("PropostaModel");

         AjustaMeioLiberacao(proposta);

         DataBind();
      }

      private void AjustaMeioLiberacao(PropostaModel proposta)
      {
         var meioLiquidacao = proposta.Operacoes.MeioLiberacao;
         ddlMeioLiberacao.SelectedValue = meioLiquidacao.ToString();

         if (meioLiquidacao == null)
         {
            divBancoLiberacao.Visible = false;
            divAgenciaLiberacao.Visible = false;
            divContaLiberacao.Visible = false;
            divChavePIX.Visible = false;
            lblAgenciaLiberacao.Visible = false;
            lblBancoLiberacao.Visible = false;
            lblContaLiberacao.Visible = false;
            lblChavePIX.Visible = false;
            txtAgenciaLiberacao.Visible = false;
            txtBancoLiberacao.Visible = false;
            txtContaLiberacao.Visible = false;
            txtChavePIX.Visible = false;
         }
         else
         {
            var parametroLiquidacao = PropostaService.GetInstance().ListarMeiosdeLiberacao().Where(x => x.Id == meioLiquidacao).FirstOrDefault();

            if (parametroLiquidacao.Banco)
            {
               lblBancoLiberacao.Visible = true;
               txtBancoLiberacao.Visible = true;
               divBancoLiberacao.Visible = true;
            }
            else
            {
               lblBancoLiberacao.Visible = false;
               txtBancoLiberacao.Visible = false;
               divBancoLiberacao.Visible = false;
            }

            if (parametroLiquidacao.Agencia)
            {
               lblAgenciaLiberacao.Visible = true;
               txtAgenciaLiberacao.Visible = true;
               divAgenciaLiberacao.Visible = true;
            }
            else
            {
               lblAgenciaLiberacao.Visible = false;
               txtAgenciaLiberacao.Visible = false;
               divAgenciaLiberacao.Visible = false;
            }

            if (parametroLiquidacao.Conta)
            {
               lblContaLiberacao.Visible = true;
               txtContaLiberacao.Visible = true;
               divContaLiberacao.Visible = true;
            }
            else
            {
               lblContaLiberacao.Visible = false;
               txtContaLiberacao.Visible = false;
               divContaLiberacao.Visible = false;
            }

            if (parametroLiquidacao.Chave)
            {
               lblChavePIX.Visible = true;
               txtChavePIX.Visible = true;
               divChavePIX.Visible = true;
            }
            else
            {
               lblChavePIX.Visible = false;
               txtChavePIX.Visible = false;
               divChavePIX.Visible = false;
            }
         }
      }

      private void BloqueiaCampos(PropostaModel proposta)
      {
         AjustaMeioLiberacao(proposta);

         Produtos produto = PropostaService.GetInstance().ObtemProduto(proposta.Operacoes.Produto);

         if (produto.ExibeInstituidor)
         {
            divInstituidor.Visible = true;
         } else
         {
            divInstituidor.Visible = false;
         }

         btnRejeitarProposta.Visible = VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Rejeitar Proposta");

         #region "Permissão as Abas"
         if (!VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Visualizar Aba Consultas"))
         {
            tabConsultasTab.Visible = false;
         }
         else
         {
            tabConsultasTab.Visible = true;
         }

         if (!VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Visualizar Aba Ocorrências"))
         {
            tabOcorrenciasTab.Visible = false;
         }
         else
         {
            tabOcorrenciasTab.Visible = true;
         }

         if (!VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Visualizar Aba Checklist"))
         {
            tabChecklistTab.Visible = false;
         }
         else
         {
            tabChecklistTab.Visible = true;
         }

         //TODO: Trilha Auditoria

         if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Visualizar Aba Histórico de Alterações"))
         {
            tabHistoricoTab.Visible = true;
         }
         else
         {
            tabHistoricoTab.Visible = false;
         }

         if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Visualizar Aba Log"))
         {
            tabLogsTab.Visible = true;
         }
         else
         {
            tabLogsTab.Visible = false;
         }

         if (!VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Visualizar Aba Arquivos"))
         {
            tabArquivosTab.Visible = false;
         }
         else
         {
            tabArquivosTab.Visible = true;
         }

         if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Visualizar Aba Trilha Auditoria"))
         {
            tabTrilhaAuditoriaTab.Visible = true;
         }
         else
         {
            tabTrilhaAuditoriaTab.Visible = false;
         }
         #endregion

         #region Permissões por Fase
         //TODO: Validar os Itens comentados
         if (proposta.Fase == 2) //Captura
         {
            HiddenTab.Value = "tabPropostasTab";
            btnRejeitarProposta.Visible = true;
            btnPendenciar.Visible = false;
            //   //Processo Fisico do INSS
            //   if (proposta.Operacoes[0].TipoProduto.Trim() == "063" || proposta.Operacoes[0].TipoProduto.Trim() == "064" || proposta.Operacoes[0].TipoProduto.Trim() == "070" || proposta.Operacoes[0].TipoProduto.Trim() == "071" || proposta.Operacoes[0].TipoProduto.Trim() == "072" || proposta.Operacoes[0].TipoProduto.Trim() == "076" || proposta.Operacoes[0].TipoProduto.Trim() == "077")
            //   {
            //      mnuRelatorios.Visible = true;
            //      btnCCBNegociavel.Visible = true;
            //      bntRelatorioPO.Visible = false;
            //      bntRelatoriodeVisita.Visible = false;
            //      bntChecklist.Visible = false;
            //      bntComunicadoAnalise.Visible = false;
            //      btnImprimirCCBGerada.Visible = false;
            //   }
            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Desbloquear Proposta na Fase CAPTURA"))
               btnDesbloquearProposta.Visible = PropostaService.GetInstance().PropostaBloqueada(proposta.Id) && proposta.UsuarioProposta != null && proposta.UsuarioProposta != this.UserContext?.GetUserData<Usuario>().Id;
            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Incluir Ocorrências na Fase CAPTURA"))
               btnAdicionarOcorrencia.Enabled = true;
         }
         else if (proposta.Fase == 3) //"MESA PROMOTORA"
         {
            HiddenTab.Value = "tabPropostasTab";

            if (!VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Editar Propostas na Fase MESA PROMOTORA"))
            {
               btnSalvar.Visible = false;
               btnRejeitarProposta.Visible = true;
               fileUpload.Visible = false;
               ddlTipoDocumentoUpload.Visible = false;
               btnCarregarArquivo.Visible = false;
               BloqueiaProposta();
            }
            else
            {
               btnRejeitarProposta.Visible = true;
               fileUpload.Visible = false;
               ddlTipoDocumentoUpload.Visible = false;
               btnCarregarArquivo.Visible = false;

               if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Pendenciar Proposta"))
               {
                  if (!proposta.Pendente)
                  {
                     btnPendenciar.Visible = true;
                  }
                  else
                  {
                     btnPendenciar.Visible = false;
                  }
               }
            }
            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Desbloquear Proposta na Fase MESA PROMOTORA"))
               btnDesbloquearProposta.Visible = PropostaService.GetInstance().PropostaBloqueada(proposta.Id) && proposta.UsuarioProposta != null && proposta.UsuarioProposta != this.UserContext?.GetUserData<Usuario>().Id;
            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Incluir Ocorrências na Fase MESA PROMOTORA"))
               btnAdicionarOcorrencia.Enabled = true;
         }
         else if (proposta.Fase == 4) //"CONSULTA"
         {
            HiddenTab.Value = "tabPropostasTab";
            btnSalvar.Visible = false;
            btnRejeitarProposta.Visible = true;
            BloqueiaProposta();
            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Desbloquear Proposta na Fase CONSULTA"))
               btnDesbloquearProposta.Visible = PropostaService.GetInstance().PropostaBloqueada(proposta.Id) && proposta.UsuarioProposta != null && proposta.UsuarioProposta != this.UserContext?.GetUserData<Usuario>().Id;
            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Incluir Ocorrências na Fase CONSULTA"))
               btnAdicionarOcorrencia.Enabled = true;
         }
         else if (proposta.Fase == 8) //"AVERBAÇÃO"
         {
            HiddenTab.Value = "tabPropostasTab";
            btnSalvar.Visible = false;
            btnRejeitarProposta.Visible = false;
            btnSubmeter.Visible = false;
            btnRejeitarProposta.Visible = true;
            BloqueiaProposta();
            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Desbloquear Proposta na Fase AVERBAÇÃO"))
               btnDesbloquearProposta.Visible = PropostaService.GetInstance().PropostaBloqueada(proposta.Id) && proposta.UsuarioProposta != null && proposta.UsuarioProposta != this.UserContext?.GetUserData<Usuario>().Id;
            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Incluir Ocorrências na Fase AVERBAÇÃO"))
               btnAdicionarOcorrencia.Enabled = true;

         }
         else if (proposta.Fase == 5) //"ANÁLISE BACKOFFICE"
         {
            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Pendenciar Proposta na fase ANÁLISE DE BACKOFFICE"))
            {
               if (!proposta.Pendente)
               {
                  btnPendenciar.Visible = true;
               }
               else
               {
                  btnPendenciar.Visible = false;
               }

            }
            else
            {
               btnPendenciar.Visible = false;
            }

            HiddenTab.Value = "tabPropostasTab";
            btnSalvar.Visible = false;
            btnRejeitarProposta.Visible = true;
            BloqueiaProposta(5);
            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Desbloquear Proposta na Fase ANÁLISE BACKOFFICE"))
               btnDesbloquearProposta.Visible = PropostaService.GetInstance().PropostaBloqueada(proposta.Id) && proposta.UsuarioProposta != null && proposta.UsuarioProposta != this.UserContext?.GetUserData<Usuario>().Id;
            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Incluir Ocorrências na Fase ANÁLISE BACKOFFICE"))
               btnAdicionarOcorrencia.Enabled = true;
         }
         else if (proposta.Fase == 7) //"ASSINATURA DIGITAL"
         {
            HiddenTab.Value = "tabPropostasTab";
            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Reenviar Link Assinatura Digital"))
            {
               btnReenviarLinkAssinatura.Visible = true;
            }
            btnRejeitarProposta.Visible = true;
            fileUpload.Visible = false;
            ddlTipoDocumentoUpload.Visible = false;
            btnCarregarArquivo.Visible = false;
            btnSalvar.Visible = false;
            btnSubmeter.Visible = false;

            BloqueiaProposta();
            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Desbloquear Proposta na Fase ASSINATURA DIGITAL"))
               btnDesbloquearProposta.Visible = PropostaService.GetInstance().PropostaBloqueada(proposta.Id) && proposta.UsuarioProposta != null && proposta.UsuarioProposta != this.UserContext?.GetUserData<Usuario>().Id;
            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Incluir Ocorrências na Fase ASSINATURA DIGITAL"))
               btnAdicionarOcorrencia.Enabled = true;

         }
         else if (proposta.Fase == 6) //"ANALISE PLD"
         {
            HiddenTab.Value = "tabPropostasTab";
            btnRejeitarProposta.Visible = true;
            btnSalvar.Visible = false;

            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Pendenciar Proposta na fase ANÁLISE DE PLD"))
            {
               if (!proposta.Pendente)
               {
                  btnPendenciar.Visible = true;
               }
               else
               {
                  btnPendenciar.Visible = false;
               }
            }
            else
            {
               btnPendenciar.Visible = false;
            }
            BloqueiaProposta();
            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Desbloquear Proposta na Fase ANALISE PLD"))
               btnDesbloquearProposta.Visible = PropostaService.GetInstance().PropostaBloqueada(proposta.Id) && proposta.UsuarioProposta != null && proposta.UsuarioProposta != this.UserContext?.GetUserData<Usuario>().Id;
            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Incluir Ocorrências na Fase ANALISE PLD"))
               btnAdicionarOcorrencia.Enabled = true;
         }
         else if (proposta.Fase == 9) //"INTEGRAÇÃO"
         {
            HiddenTab.Value = "tabPropostasTab";

            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Pendenciar Proposta na fase INTEGRAÇÃO"))
            {
               if (!proposta.Pendente)
               {
                  btnPendenciar.Visible = true;
               }
               else
               {
                  btnPendenciar.Visible = false;
               }

            }
            else
            {
               btnPendenciar.Visible = false;
            }
            btnSalvar.Visible = false;
            btnRejeitarProposta.Visible = true;
            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Anexar Arquivos na Fase de INTEGRAÇÃO"))
            {
               fileUpload.Visible = true;
               ddlTipoDocumentoUpload.Visible = true;
               btnCarregarArquivo.Visible = true;
            }
            else
            {
               fileUpload.Visible = false;
               ddlTipoDocumentoUpload.Visible = false;
               btnCarregarArquivo.Visible = false;
            }
            BloqueiaProposta(9);
            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Desbloquear Proposta na Fase INTEGRAÇÃO"))
               btnDesbloquearProposta.Visible = PropostaService.GetInstance().PropostaBloqueada(proposta.Id) && proposta.UsuarioProposta != null && proposta.UsuarioProposta != this.UserContext?.GetUserData<Usuario>().Id;
            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Incluir Ocorrências na Fase INTEGRAÇÃO"))
               btnAdicionarOcorrencia.Enabled = true;
         }
         else if (proposta.Fase == 10) //"RETORNO CRITICA"
         {
            HiddenTab.Value = "tabPropostasTab";
            btnRejeitarProposta.Visible = false;

            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Submeter Proposta na Fase RETORNO CRITICA"))
            {
               btnSubmeter.Visible = true;
            }
            else
            {
               btnSubmeter.Visible = false;
            }

            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Anexar Arquivos na Fase de RETORNO CRITICA"))
            {
               fileUpload.Visible = true;
               btnCarregarArquivo.Visible = true;
               ddlTipoDocumentoUpload.Visible = true;
            }
            else
            {
               fileUpload.Visible = false;
               btnCarregarArquivo.Visible = false;
               ddlTipoDocumentoUpload.Visible = false;
            }

            BloqueiaProposta();
            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Desbloquear Proposta na Fase RETORNO CRITICA"))
               btnDesbloquearProposta.Visible = PropostaService.GetInstance().PropostaBloqueada(proposta.Id) && proposta.UsuarioProposta != null && proposta.UsuarioProposta != this.UserContext?.GetUserData<Usuario>().Id;
            //if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Incluir Ocorrências na Fase RETORNO CRITICA"))
            //   btnAdicionarOcorrencia.Enabled = true;

         }
         #endregion

         #region Permissões Especificas
         if (produto.BloqueiaProposta)
         {
            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Desbloquear Proposta"))
               btnDesbloquearProposta.Visible = PropostaService.GetInstance().PropostaBloqueada(proposta.Id) && proposta.UsuarioProposta != null && proposta.UsuarioProposta != this.UserContext?.GetUserData<Usuario>().Login;
         }
         else
         {
            btnDesbloquearProposta.Visible = false;
         }

         if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Reenviar Link Combate a Fraude"))
            btnReenviarLinkCombateaFraude.Visible = (PropostaService.GetInstance().ListarOcorrencias(proposta.Id).Where(x => x.Ocorrencia == 9).Where(a => a.Liberada == false).Count() > 0 && proposta.Status != 4);

         if (!VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Excluir Arquivo Anexado"))
         {
            for (int l = 0; l < rptArquivos.Items.Count; l++)
            {
               rptArquivos.Items[l].FindControl("lnkExcluir").Visible = false;
            }
         }
         #endregion

         #region "Permissões por Status"
         if (proposta.Status == 9 || proposta.Status == 12 || proposta.Status == 4)
         {
            HiddenTab.Value = "tabPropostasTab";
            btnSalvar.Visible = false;
            btnSubmeter.Visible = false;
            btnRejeitarProposta.Visible = false;
            btnPendenciar.Visible = false;
            btnReenviarLinkCombateaFraude.Visible = false;
            btnReenviarLinkAssinatura.Visible = false;
            btnReenviarMensagem.Visible = false;

            fileUpload.Visible = false;
            btnCarregarArquivo.Visible = false;
            ddlTipoDocumentoUpload.Visible = false;

            for (int l = 0; l < rptArquivos.Items.Count; l++)
            {
               rptArquivos.Items[l].FindControl("lnkExcluir").Visible = false;
            }

            BloqueiaProposta();
         }

         #endregion

         #region Proposta Bloqueada
         if (proposta.UsuarioProposta != null && proposta.UsuarioProposta != this.UserContext?.GetUserData<Usuario>().Id)
         {
            // bloquear todos os campos
            txtCPF.Enabled = false;
            txtNome.Enabled = false;
            txtDataNascimento.Enabled = false;
            ddlNacionalidade.Enabled = false;
            txtNaturalidade.Enabled = false;
            ddlSexo.Enabled = false;
            ddlEstadoCivil.Enabled = false;
            ddlTipoDocumento.Enabled = false;
            txtNumeroDocumentoIdentidade.Enabled = false;
            ddlEmissorDocumento.Enabled = false;
            ddlUFEmissaoDocumentoIdentidade.Enabled = false;
            txtDataEmissaoDocumentoIdentidade.Enabled = false;
            txtMae.Enabled = false;
            txtPai.Enabled = false;
            ddlPPE.Enabled = false;
            txtCEPResidencial.Enabled = false;
            txtEnderecoResidencial.Enabled = false;
            txtNumeroResidencial.Enabled = false;
            txtComplementoResidencial.Enabled = false;
            txtBairroResidencial.Enabled = false;
            txtCidadeResidencial.Enabled = false;
            txtEstadoResidencial.Enabled = false;
            txtTelefoneResidencial.Enabled = false;
            ddlGerente.Enabled = false;
            txtEmpresa.Enabled = false;
            txtCargo.Enabled = false;
            ddlOcupacao.Enabled = false;
            txtRendimentos.Enabled = false;
            txtOutrosRendimentos.Enabled = false;
            ddlMeioLiberacao.Enabled = false;
            txtBancoLiberacao.Enabled = false;
            txtAgenciaLiberacao.Enabled = false;
            txtContaLiberacao.Enabled = false;
            txtChavePIX.Enabled = false;
            btnCarregarArquivo.Visible = false;
            ddlTipoDocumentoUpload.Visible = false;
            fileUpload.Visible = false;
            btnCarregarArquivo.Visible = false;
            btnJustificativaAprovacaoCancelar.Visible = false;
            btnJustificativaAprovacaoOk.Visible = false;
            btnReenviarMensagem.Visible = false;
            btnRejeitarProposta.Visible = false;
            btnSalvar.Visible = false;
            btnSubmeter.Visible = false;

            ShowMessage(TipoMensagem.Aviso, string.Format("Proposta bloqueada para o usuário {0}", proposta.UsuarioProposta));
         }
         #endregion
      }

      private void BloqueiaProposta(int fase = 0)
      {
         if (fase != 2)
         {
            txtCPF.Enabled = false;
            txtNome.Enabled = false;
            txtDataNascimento.Enabled = false;
            ddlNacionalidade.Enabled = false;
            txtNaturalidade.Enabled = false;
            ddlSexo.Enabled = false;
            ddlEstadoCivil.Enabled = false;
            ddlTipoDocumento.Enabled = false;
            txtNumeroDocumentoIdentidade.Enabled = false;
            ddlEmissorDocumento.Enabled = false;
            ddlUFEmissaoDocumentoIdentidade.Enabled = false;
            txtDataEmissaoDocumentoIdentidade.Enabled = false;
            txtMae.Enabled = false;
            txtPai.Enabled = false;
            ddlPPE.Enabled = false;
            txtCEPResidencial.Enabled = false;
            txtEnderecoResidencial.Enabled = false;
            txtNumeroResidencial.Enabled = false;
            txtComplementoResidencial.Enabled = false;
            txtBairroResidencial.Enabled = false;
            txtCidadeResidencial.Enabled = false;
            txtEstadoResidencial.Enabled = false;
            txtTelefoneResidencial.Enabled = false;
            ddlGerente.Enabled = false;
            txtEmpresa.Enabled = false;
            txtCargo.Enabled = false;
            ddlOcupacao.Enabled = false;
            txtRendimentos.Enabled = false;
            txtOutrosRendimentos.Enabled = false;
            txtBancoLiberacao.Enabled = false;
            txtAgenciaLiberacao.Enabled = false;
            txtContaLiberacao.Enabled = false;
            ddlMeioLiberacao.Enabled = false;
            txtChavePIX.Enabled = false;
            txtInstituidor.Enabled = false;
         }
      }
      #endregion

      #region Metodos Privados
      private void Novo()
      {

      }

      private void Editar(string id)
      {
         try
         {
            var idProposta = int.Parse(id);
            var proposta = PropostaService.GetInstance().ObterProposta(idProposta);
            var proponente = proposta.Proponente;

            ContratosRepeater.DataSource = proposta.ContratosREFIN;
            ContratosRepeater.DataBind();
            rptArquivos.DataSource = this.ListarArquivosPropostaAutorizados(proposta);
            rptArquivos.DataBind();
            rptTrilhaAuditoria.DataSource = PropostaService.GetInstance().ListarTrilhaAuditoriaProposta(proposta.Id, proposta.Operacoes.Simulacao, proposta.Operacoes.Produto).OrderByDescending(x => x.Date);
            rptTrilhaAuditoria.DataBind();
            ConteudoHistoricoAlteracoes.InnerHtml = AuditoriaService.GetInstance().GetHtmlAudit("PropostaModel", proposta.Id);
            rptLog.DataSource = PropostaService.GetInstance().ListarHistorico(proposta.Id, proposta.Operacoes.Simulacao).OrderByDescending(x => x.DataExecucao);
            rptLog.DataBind();
            rptOcorrencias.DataSource = proposta.Ocorrencias;
            rptOcorrencias.DataBind();
            rptOcorrenciasCheckList.DataSource = PropostaService.GetInstance().ListarItensCheckListProposta(proposta.Id);
            rptOcorrenciasCheckList.DataBind();

            MontaTreeView(proposta);

            var produto = PropostaService.GetInstance().ObtemProduto(proposta.Operacoes.Produto);

            //Contratos Refinanciamento
            if (proposta.ContratosREFIN.Count() > 0)
            {
               divContratosRefin.Visible = true;
            }

            AddMessage<PropostaModel>("PropostaModel", proposta);

            #region "Trilha de Auditoria"
            Session["Auditoria"] = proposta;
            #endregion

            DataBind();
         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Editar Proposta"));
         }
      }

      private TreeNode FindInTreeview(string strSearch, TreeNodeCollection Nodes)
      {
         TreeNode retorno = null;

         foreach (TreeNode TrNode in Nodes)
         {
            if (TrNode.Value == strSearch)
            {
               return TrNode;
            }

            if (TrNode.ChildNodes.Count > 0)
            {
               retorno = FindInTreeview(strSearch, TrNode.ChildNodes);
               if (retorno != null)
               {
                  return retorno;
               }
            }
         }
         return retorno;
      }

      private void MontaTreeView(PropostaModel proposta)
      {
         var objTree = new TreeNode();

         string papel = string.Empty;
         treeConsultas.Nodes.Clear();

         foreach (PropostaHierarquiaConsulta i in proposta.Consultas)
         {
            switch (i.Papel)
            {
               case "CL":
                  papel = "Proponente: ";
                  break;
               case "AV":
                  papel = "Devedor Solidário: ";
                  break;
               case "CM":
                  papel = "CPF/CNPJ Complementar: ";
                  break;
               case "SC":
                  papel = "Sócio: ";
                  break;
               case "PR":
                  papel = "Proponente: ";
                  break;
               case "AN":
                  papel = "Anuente: ";
                  break;
               case "CC":
                  papel = "Complementar: ";
                  break;
               case "SD":
                  papel = "Sacado: ";
                  break;
               default:
                  break;
            }

            var auxiliar = string.Empty;
            var cor1 = "#0000FF";
            var cor2 = "#FF0000";
            var cor = cor1;
            var aspasDuplas = ((char)34).ToString(); //aspas duplas

            var pessoa = PropostaService.GetInstance().ObtemPessoa(i.Pessoa);
            var consultas = PropostaService.GetInstance().ListarConsultas(i.Pessoa);

            foreach (PropostaConsultas c in consultas)
            {
               auxiliar += (auxiliar == String.Empty ? "" : ", ") +
                   $"<a href='' id={aspasDuplas + c.IdConsulta.ToString() + aspasDuplas}' class={aspasDuplas}visualizarReport{aspasDuplas}><font color='{cor}'>{c.Consulta}</font></a>";

               if (cor == cor1)
               {
                  cor = cor2;
               }
               else cor = cor1;
            }

            objTree = new TreeNode(papel + pessoa.Nome.ToUpper() + (auxiliar == String.Empty ? "" : "        (" + auxiliar + ")"), pessoa.Id.ToString());

            if (i.PessoaPai == null)
            {
               objTree.Text = "<b>" + objTree.Text + "</b>";
               treeConsultas.Nodes.Add(objTree);
            }
            else
            {
               TreeNode FNode = FindInTreeview(i.PessoaPai.ToString(), treeConsultas.Nodes);
               if (FNode == null)
               {
                  objTree.Text = "<b>" + objTree.Text + "</b>";
                  treeConsultas.Nodes.Add(objTree);

               }
               else
               {
                  FNode.ChildNodes.Add(objTree);
               }
            }
         }
      }
      #endregion

      #region Arquivos
      protected void rptArquivos_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            var o = (PropostaArquivos)e.Item.DataItem;
            ((CustomLabel)e.Item.FindControl("lblTipoArquivo")).Text = o.TipoArquivo;
            ((CustomLabel)e.Item.FindControl("lblArquivo")).Text = o.NomeArquivo;
            ScriptManager scriptMan = ScriptManager.GetCurrent(this.Page);
            scriptMan.RegisterPostBackControl(((CustomLinkButton)e.Item.FindControl("lnkArquivoDownload")));
         }
      }

      protected void rptArquivos_ItemCommand(object source, RepeaterCommandEventArgs e)
      {
         if (e.CommandArgument == null)
            return;

         DataUnbind();
         var proposta = GetMessage<PropostaModel>("PropostaModel");

         if (e.CommandName == "Download")
         {
            var arquivo = PropostaService.GetInstance().ObtemArquivoProposta(int.Parse(e.CommandArgument.ToString()));

            HiddenTab.Value = "tabArquivos";

            Response.Clear();

            Response.ContentType = "application/octet-stream";
            Response.AddHeader("Content-Disposition", "attachment;filename=" + arquivo.NomeArquivo + "");

            string armazenamento = ConfiguracaoService.GetInstance().Obter("fastconsig.armazenamento").Conteudo;

            if (armazenamento == "filesystem")
            {
               Response.AddHeader("Content-Length", new FileInfo(Server.MapPath("~/Arquivos/" + proposta.Id.ToString() + "/") + arquivo.NomeArquivo).Length.ToString());
               var reader = File.ReadAllBytes(Server.MapPath("~/Arquivos/" + proposta.Id.ToString() + "/") + arquivo.NomeArquivo);
               Response.BinaryWrite(reader);
            }
            else if (armazenamento == "database")
            {
               Response.AddHeader("Content-Length", arquivo.Conteudo.Length.ToString());
               var reader = arquivo.Conteudo;
               Response.BinaryWrite(reader);
            }
            else
            {
               throw new Exception("Forma de Armazenamento não Definida nas Configurações");
            }

            Response.End();

         }
         else if (e.CommandName == "Excluir")
         {
            PropostaService.GetInstance().GravarHistoricoProposta(proposta, "ExcluirArquivoAnexado");
            PropostaService.GetInstance().ApagarArquivo(int.Parse(e.CommandArgument.ToString()));

            proposta = PropostaService.GetInstance().ObterProposta(proposta.Id);
            rptArquivos.DataSource = this.ListarArquivosPropostaAutorizados(proposta);
            rptArquivos.DataBind();

            AddMessage("PropostaModel", proposta);
            SetCrossPageData("Proposta", proposta);

            HiddenTab.Value = "tabArquivos";
         }
      }

      protected List<PropostaArquivos> ListarArquivosPropostaAutorizados(PropostaModel proposta)
      {
         List<PropostaArquivos> arquivosRetorno = new List<PropostaArquivos>();

         if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Restringir Visualização de Arquivos"))
         {
            var politica = PropostaService.GetInstance().BuscaParametrosPolitica("FastConsig.Core.Politicas.LiberacaoDocumentoFase", proposta.Operacoes.Produto);

            foreach (var fases in politica.Fases)
            {
               if ((int)fases.Fase == PropostaService.GetInstance().ObtemFase(proposta.Fase).Id)
               {
                  foreach (var tipoDocumento in fases.TipoDocumentos)
                  {
                     foreach (PropostaArquivos arquivo in proposta.Arquivos)
                     {
                        if (arquivo.TipoDocumento == (int?)tipoDocumento.TipoDocumento && (bool)tipoDocumento.Visible)
                        {
                           arquivosRetorno.Add(arquivo);
                        }
                     }
                  }
               }
            }
            return arquivosRetorno;
         }
         else
         {
            return proposta.Arquivos;
         }
      }
      protected void lnkArquivoDownload_Click(object sender, EventArgs e)
      {

      }

      protected void lnkExcluir_Click(object sender, EventArgs e)
      {

      }

      protected void btnCarregarArquivo_Click(object sender, EventArgs e)
      {
         DataBind();
         if (!fileUpload.HasFile)
         {
            ShowMessage(TipoMensagem.Erro, "Arquivo Inválido");
            return;
         }

         DataUnbind();

         if (HdntipoArquivo.Value == "")
         {
            ShowMessage(TipoMensagem.Erro, "Tipo de Documento Inválido");
            return;
         }

         var proposta = GetMessage<PropostaModel>("PropostaModel");

         try
         {
            var filename = fileUpload.FileName;
            var extension = System.IO.Path.GetExtension(filename);

            string armazenamento = ConfiguracaoService.GetInstance().Obter("fastconsig.armazenamento").Conteudo;
            var chaveArquivo = DateTime.Now.ToString("ddMMhhmmss_") + filename;

            PropostaArquivos arquivoProposta = new PropostaArquivos();
            arquivoProposta.Proposta = proposta.Id;
            arquivoProposta.ChaveArquivo = chaveArquivo;
            arquivoProposta.NomeArquivo = filename;
            arquivoProposta.TipoDocumento = int.Parse(HdntipoArquivo.Value);

            if (armazenamento == "filesystem")
            {
               if (!System.IO.Directory.Exists(Server.MapPath("~/Arquivos/" + proposta.Id.ToString() + "/")))
                  System.IO.Directory.CreateDirectory(Server.MapPath("~/Arquivos/" + proposta.Id.ToString() + "/"));

               var arquivo = Server.MapPath("~/Arquivos/") + proposta.Id.ToString() + "/" + chaveArquivo;
               fileUpload.SaveAs(arquivo);
               arquivoProposta.Conteudo = new byte[1];
            }
            else if (armazenamento == "database")
            {
               arquivoProposta.Conteudo = fileUpload.FileBytes;
            }
            else
            {
               throw new Exception("Forma de Armazenamento não Definida nas Configurações");
            }

            PropostaService.GetInstance().SalvarArquivo(arquivoProposta);

            PropostaService.GetInstance().GravarHistoricoProposta(proposta, "AnexarArquivo");

            proposta.Arquivos = PropostaService.GetInstance().ObterProposta(proposta.Id).Arquivos;

         }
         catch (Exception exx)
         {
            ShowMessage(TipoMensagem.Erro, "Erro ao Carregar o Arquivo: " + exx.StackTrace);
            return;
         }

         AddMessage("PropostaModel", proposta);
         SetCrossPageData("Proposta", proposta);



         rptArquivos.DataSource = this.ListarArquivosPropostaAutorizados(proposta);
         rptArquivos.DataBind();
         BloqueiaCampos(proposta);

         HiddenTab.Value = "tabArquivos";

         DataBind();

         ShowMessage(TipoMensagem.Aviso, "Arquivo Carregado com Sucesso!!!");
         return;

      }
      #endregion

      #region Contratos Refinanciamento
      protected void ContratosRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {

      }
      #endregion

      #region Ocorrências
      protected void rptOcorrencias_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {

            var o = (PropostaOcorrencias)e.Item.DataItem;
            ((Label)e.Item.FindControl("lblDataOcorrencia")).Text = o.DataOcorrencia.Value.ToString("dd/MM/yyyy HH:mm:ss");
            ((Label)e.Item.FindControl("lblOcorrencia")).Text = o.DescricaoOcorrencia?.ToString();

            //Complemento da Ocorrência
            if (!VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Restringir Visualização do Complemento da Ocorrência"))
            {
               ((Label)e.Item.FindControl("lblComplemento")).Text = o.Complemento?.ToString();
            }
            else
            {
               if (o.Restritiva == "P")
               {
                  ((Label)e.Item.FindControl("lblComplemento")).Text = o.Complemento?.ToString();
               }
            }

            //Nome do Usuário que gerou a ocorrência
            if (!VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Restringir Visualização do Usuário da Ocorrência"))
            {
               ((Label)e.Item.FindControl("lblUsuario")).Text = o.NomeUsuario?.ToString();
            }
            else
            {
               ((Label)e.Item.FindControl("lblUsuario")).Text = "";
            }

            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Visualizar Detalhes da Ocorrência"))
            {
               ((CustomLinkButton)e.Item.FindControl("lnkVisualizarDetalhesOcorrencia")).Visible = true;
            }
            else
            {
               ((CustomLinkButton)e.Item.FindControl("lnkVisualizarDetalhesOcorrencia")).Visible = false;
            }

            ((CustomLinkButton)e.Item.FindControl("lnkLiberarOcorrencia")).Visible = (o.Restritiva == "S" ? (o.Liberada ? false : true) : false);

            if (proposta.UsuarioProposta != null && proposta.UsuarioProposta != this.UserContext?.GetUserData<Usuario>().Login)
               ((CustomLinkButton)e.Item.FindControl("lnkLiberarOcorrencia")).Visible = false;

            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Complementar Informações em Ocorrências de Pendência na Fase de CAPTURA") && o.Restritiva == "P" && o.Liberada == false)
            {
               ((CustomLinkButton)e.Item.FindControl("lnkLiberarOcorrencia")).Visible = true;
            }

            if (o.Restritiva == "I")
            {
               ((CustomLinkButton)e.Item.FindControl("lnkLiberarOcorrencia")).Visible = false;
            }

            ScriptManager scriptMan = ScriptManager.GetCurrent(this.Page);
            scriptMan.RegisterPostBackControl(((CustomLinkButton)e.Item.FindControl("lnkVisualizarDetalhesOcorrencia")));
            scriptMan.RegisterPostBackControl(((CustomLinkButton)e.Item.FindControl("lnkLiberarOcorrencia")));

         }
      }

      protected void rptOcorrencias_ItemCommand(object source, RepeaterCommandEventArgs e)
      {
         if (e.CommandName == "Liberar")
         {
            DataUnbind();
            var proposta = GetMessage<PropostaModel>("PropostaModel");

            try
            {
               var ocorrencia = PropostaService.GetInstance().ObtemOcorrenciaProposta(int.Parse(e.CommandArgument.ToString()));

               AddMessage<PropostaOcorrencias>("Ocorrencia", ocorrencia);

               DataBind();


               switch (proposta.Fase)
               {
                  case 2:
                     if (!VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Complementar Informações em Ocorrências de Pendência na Fase de CAPTURA") && ocorrencia.Restritiva == "P")
                     {
                        ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                        return;
                     }
                     if (!VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Aprovar/Rejeitar Ocorrências da Fase CAPTURA") && ocorrencia.Restritiva == "S")
                     {
                        ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                        return;
                     }
                     break;
                  case 3:
                     if (!VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Aprovar/Rejeitar Ocorrências da Fase MESA PROMOTORA"))
                     {
                        ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                        return;
                     }
                     break;
                  case 4:
                     if (!VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Aprovar/Rejeitar Ocorrências da Fase CONSULTA"))
                     {
                        ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                        return;
                     }
                     break;
                  case 5:
                     if (!VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Aprovar/Rejeitar Ocorrências da Fase ANÁLISE DE BACKOFFICE"))
                     {
                        ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                        return;
                     }
                     break;
                  case 6:
                     if (!VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Aprovar/Rejeitar Ocorrências da Fase ANÁLISE DE PLD"))
                     {
                        ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                        return;
                     }
                     break;
                  case 7:
                     if (!VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Aprovar/Rejeitar Ocorrências da Fase ASSINATURA DIGITAL"))
                     {
                        ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                        return;
                     }
                     break;
                  case 8:
                     if (!VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Aprovar/Rejeitar Ocorrências da Fase AVERBAÇÃO"))
                     {
                        ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                        return;
                     }
                     break;
                  case 9:
                     if (!VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Aprovar/Rejeitar Ocorrências da Fase INTEGRAÇÃO"))
                     {
                        ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                        return;
                     }
                     break;
                  default:
                     ShowMessage(TipoMensagem.Erro, "Usuário sem Privilégios para esta Ação");
                     return;
               }
               HiddenTab.Value = "tabOcorrencias";
               var masterpage = (SiteMaster)Master;
               pnlPopupJustificativaAprovacao.Visible = true;
               masterpage.RegisterStartupScript("ShowModalJustificativaAprovacao",
                   string.Format("$('#{0}').modal('show');",
                   pnlPopupJustificativaAprovacao.ClientID));
            }
            catch (Exception ex)
            {
               GravarLogErro(ex, ex.Message);
               ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Motivo Aprovação"));
            }
         }
         else if (e.CommandName == "Visualizar")
         {
            var ocorrencia = PropostaService.GetInstance().ObtemOcorrenciaProposta(int.Parse(e.CommandArgument.ToString()));

            AddMessage<PropostaOcorrencias>("DetalheOcorrencia", ocorrencia);
            btnJustificativaAprovacaoOcorrenciaOk.Visible = false;
            btnCancelarOcorrencia.Visible = false;
            btnSairOcorrencia.Visible = true;

            DataBind();

            HiddenTab.Value = "tabOcorrencias";
            var masterpage = (SiteMaster)Master;
            pnlPopupOcorrencia.Visible = true;
            masterpage.RegisterStartupScript("ShowModalOcorrencia",
                string.Format("$('#{0}').modal('show');",
                pnlPopupOcorrencia.ClientID));
         }
      }

      protected void btnJustificativaAprovacaoOk_Click(object sender, EventArgs e)
      {
         DataUnbind();

         var ocorrencia = GetMessage<PropostaOcorrencias>("Ocorrencia");
         var proposta = GetMessage<PropostaModel>("PropostaModel");
         PropostaOcorrencias ocorrenciaOriginal = PropostaService.GetInstance().ObtemOcorrenciaProposta(ocorrencia.Id);
         var usuario = this.UserContext?.GetUserData<Usuario>().Id;
         ocorrenciaOriginal.Motivo = ocorrencia.Motivo;
         ocorrenciaOriginal.Liberada = true;
         ocorrenciaOriginal.UsuarioLiberador = usuario;
         ocorrenciaOriginal.DataHoraLiberacao = DateTime.Now;
         PropostaService.GetInstance().SalvaOcorrencia(ocorrenciaOriginal);
         proposta = PropostaService.GetInstance().ObterProposta(proposta.Id);
         rptOcorrencias.DataSource = proposta.Ocorrencias;
         rptOcorrencias.DataBind();
         AuditoriaService.GetInstance().CreateAuditTrail(AuditActionType.Update, proposta.Id, Session["Auditoria"], proposta, UserContext.GetUserData<Usuario>().Id);
         HiddenTab.Value = "v-pills-ocorrencias";

         SetCrossPageData("Proposta", proposta);
         AddMessage("PropostaModel", proposta);
         DataBind();
      }

      #endregion

      #region Trilha de Auditoria
      protected void rptTrilhaAuditoria_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            var o = (LogInfo)e.Item.DataItem;

            ((CustomLabel)e.Item.FindControl("lblDataLog")).Text = o.Date.ToString("dd/MM/yyyy HH:mm:ss");
            ((CustomLabel)e.Item.FindControl("lblFaseLog")).Text = o.Fase;
            ((CustomLabel)e.Item.FindControl("lblTipoLog")).Text = o.MethodName;
            ((CustomLabel)e.Item.FindControl("lblLog")).Text = JsonConvert.SerializeObject(JsonConvert.DeserializeObject<dynamic>(o.Response), Newtonsoft.Json.Formatting.Indented).Replace("\r\n", "<br/>").Replace(" ", "&nbsp;&nbsp;");
         }
      }
      #endregion

      #region Logs
      protected void rptLog_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            var o = (PropostaHistorico)e.Item.DataItem;

            ((CustomLabel)e.Item.FindControl("lblDataLogHistorico")).Text = o.DataExecucao.Value.ToString("dd/MM/yyyy HH:mm:ss");
            ((CustomLabel)e.Item.FindControl("lblFaseLogHistorico")).Text = o.DescricaoFase;
            ((CustomLabel)e.Item.FindControl("lblAcaoLogHistorico")).Text = o.Acao;
            ((CustomLabel)e.Item.FindControl("lblUsuarioLogHistorico")).Text = (o.Usuario == "System" ? o.Usuario : SegurancaService.GetInstance().BuscarUsuario(SegurancaService.GetInstance().ObtemDominioAtivoUsuario2(o.Usuario) + "\\" + o.Usuario)?.Nome);
         }
      }

      #endregion   
   }
}