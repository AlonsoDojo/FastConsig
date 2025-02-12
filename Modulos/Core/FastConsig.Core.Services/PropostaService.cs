using FastConsig.Common.Helpers;
using FastConsig.Common.Integracao;
using FastConsig.Common.Loggin;
using FastConsig.Common.Model;
using FastConsig.Common.Services;
using FastConsig.Core.Business;
using FastConsig.Core.Entity;
using FastConsig.Core.Model;
using FastConsig.Core.Model.Exceptions;
using FastConsig.Core.Model.Interfaces;
using FastConsig.ProfissionaisCertificados.Service;
using FastConsig.Seguranca.Business;
using FastConsig.Seguranca.Entity;
using FastConsig.Seguranca.Services;
using Framework.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FastConsig.Core.Services
{
   public class PropostaService
   {
      #region "Instância"
      private static PropostaService _instance;
      private PropostaService()
      {

      }
      public static PropostaService GetInstance()
      {
         if (_instance == null)
            _instance = new PropostaService();

         return _instance;
      }
      #endregion

      #region "Proposta"
      public List<ViewMonitor> ListarPropostasMonitor(MonitorFiltroModel filtro)
      {
         Framework.Data.WhereBuilder where = Framework.Data.WhereBuilder.Create();

         if (filtro.Proposta != null)
         {
            where.Add(ViewMonitor.METADADO.Proposta, Filter.Equal, filtro.Proposta, Link.And);
         }

         if (filtro.DataInicial != null)
         {
            where.Add(ViewMonitor.METADADO.DataCriacao, Filter.GreatherOrEqual, filtro.DataInicial, Link.And);
         }

         if (filtro.DataFinal != null)
         {
            where.Add(ViewMonitor.METADADO.DataCriacao, Filter.LessOrEqual, filtro.DataFinal.Value.AddDays(1), Link.And);
         }

         if (!string.IsNullOrEmpty(filtro.CPF))
         {
            where.Add(ViewMonitor.METADADO.CPFCNPJ, Filter.Equal, $"{filtro.CPF:00000000000000}", Link.And);
         }

         if (!string.IsNullOrEmpty(filtro.Contrato))
         {
            where.Add(ViewMonitor.METADADO.ContratoLegado, Filter.Equal, filtro.Contrato, Link.And);
         }

         if (filtro.Produto != null)
         {
            where.Add(ViewMonitor.METADADO.Produto, Filter.Equal, filtro.Produto, Link.And);
         }

         if (!string.IsNullOrEmpty(filtro.Nome))
         {
            where.Add(ViewMonitor.METADADO.NomeProponente, Filter.Like, filtro.Nome.ToUpper(), Link.And);
         }

         if (filtro.Fase != null)
         {
            where.Add(ViewMonitor.METADADO.Fase, Filter.Equal, filtro.Fase, Link.And);
         }

         if (filtro.Status != null)
         {
            where.Add(ViewMonitor.METADADO.Status, Filter.Equal, filtro.Status, Link.And);
         }

         if (filtro.Promotora != null)
         {
            where.Add(ViewMonitor.METADADO.Promotora, Filter.Equal, filtro.Promotora, Link.And);
         }

         if (filtro.RedeLoja != null)
         {
            where.Add(ViewMonitor.METADADO.RedeLojas, Filter.Equal, filtro.RedeLoja, Link.And);
         }

         if (filtro.Loja != null)
         {
            where.Add(ViewMonitor.METADADO.Loja, Filter.Equal, filtro.Loja, Link.And);
         }

         //Usuário só pode ver as propostas que foram capturadas por ele ou que ele é o gerente
         if (filtro.Usuario != null || filtro.Gerente != null)
         {
            where.Add(Block.Begin);

            if (filtro.Usuario != null)
            {
               where.Add(ViewMonitor.METADADO.Usuario, Filter.Equal, filtro.Usuario, Link.And);
            }

            if (filtro.Gerente != null)
            {
               where.Add(ViewMonitor.METADADO.Gerente, Filter.Equal, filtro.Gerente, Link.And);
            }

            where.Add(Block.End, Link.And);
         }

         //Não pode visualizar as propostas que ele tenha restrição de ver a fase
         if (filtro.RestricaoFase.Count > 0)
         {
            where.Add(Block.Begin);

            foreach (Fases f in filtro.RestricaoFase)
            {
               where.Add(ViewMonitor.METADADO.Fase, Filter.NotEqual, f.Id, Link.And);
            }

            where.Add(Block.End, Link.And);
         }

         //Somente Visualiza os Produtos que está Habilitado a Operar
         if (filtro.ProdutosHabilitados.Count > 0)
         {
            where.Add(Block.Begin);

            foreach (Produtos f in filtro.ProdutosHabilitados)
            {
               where.Add(ViewMonitor.METADADO.Produto, Filter.Equal, f.Id, Link.Or);
            }

            where.Add(Block.End, Link.And);
         }

         if (filtro.DDDCelular != null)
         {
            where.Add(ViewMonitor.METADADO.DDDCelular, Filter.Equal, filtro.DDDCelular, Link.And);
         }

         if (filtro.Celular != null)
         {
            where.Add(ViewMonitor.METADADO.Celular, Filter.Equal, filtro.Celular, Link.And);
         }

         return new ViewMonitorBusiness().Listar(where);
      }

      //TODO: Coisas do Dashboard
      //public List<ViewMonitorSimplificada> ListarOperacoes(FiltroMonitorModel filtro)
      //{
      //   Framework.Data.WhereBuilder where = Framework.Data.WhereBuilder.Create();

      //   if (filtro.Proposta != null)
      //   {
      //      where.Add(ViewMonitorSimplificada.METADADO.Proposta, Filter.Equal, filtro.Proposta, Link.And);
      //   }

      //   if (!string.IsNullOrEmpty(filtro.Contrato))
      //   {
      //      where.Add(ViewMonitorSimplificada.METADADO.ContratoLegado, Filter.Equal, filtro.Contrato, Link.And);
      //   }

      //   return new ViewMonitorSimplificadaBusiness().Listar(where);
      //}


      //public List<DashboardModel> BuscarDadosDashboard(FiltroMonitorModel filtro)
      //{
      //   Framework.Data.WhereBuilder where = Framework.Data.WhereBuilder.Create();

      //   if (filtro.Promotora != null)
      //   {
      //      where.Add(ViewDashboard.METADADO.Promotora, Filter.Equal, filtro.Promotora, Link.And);
      //   }

      //   if (filtro.RedeLoja != null)
      //   {
      //      where.Add(ViewDashboard.METADADO.RedeLojas, Filter.Equal, filtro.RedeLoja, Link.And);
      //   }

      //   if (filtro.Loja != null)
      //   {
      //      where.Add(ViewDashboard.METADADO.Loja, Filter.Equal, filtro.Loja, Link.And);
      //   }

      //   ////Usuário só pode ver as propostas que foram capturadas por ele ou que ele é o gerente
      //   //if (filtro.Usuario != null || filtro.Gerente != null)
      //   //{
      //   //   where.Add(Block.Begin);

      //   //   if (filtro.Usuario != null)
      //   //   {
      //   //      where.Add(ViewDashboard.METADADO.Usuario, Filter.Equal, filtro.Usuario, Link.And);
      //   //   }

      //   //   if (filtro.Gerente != null)
      //   //   {
      //   //      where.Add(ViewDashboard.METADADO.Gerente, Filter.Equal, filtro.Gerente, Link.And);
      //   //   }

      //   //   where.Add(Block.End, Link.And);
      //   //}

      //   //Somente Visualiza os Produtos que está Habilitado a Operar
      //   if (filtro.ProdutosHabilitados.Count > 0)
      //   {
      //      where.Add(Block.Begin);

      //      foreach (Produtos f in filtro.ProdutosHabilitados)
      //      {
      //         where.Add(ViewDashboard.METADADO.Produto, Filter.Equal, f.Id, Link.Or);
      //      }

      //      where.Add(Block.End, Link.And);
      //   }

      //   var info = new ViewDashboardBusiness().Listar(where);

      //   var familia = info.DistinctBy(x => x.FamiliaProduto);

      //   var retorno = new List<DashboardModel>();

      //   foreach (var f in familia)
      //   {
      //      var tipos = info.DistinctBy(x => x.Tipo);

      //      foreach (var t in tipos)
      //      {
      //         retorno.Add(new DashboardModel { FamiliaProduto = f.FamiliaProduto, FamiliaProdutoDescricao = f.DescricaoFamiliaProduto, Tipo = t.Tipo, Qtd = info.Where(x => x.FamiliaProduto == f.FamiliaProduto).ToList().Where(x => x.Tipo == t.Tipo).Sum(x => x.Qtd), Valor = info.Where(x => x.FamiliaProduto == f.FamiliaProduto).ToList().Where(x => x.Tipo == t.Tipo).Sum(x => x.Valor) });
      //      }
      //   }
      //   return retorno;
      //}

      public List<ViewMonitor> ListarPropostasMonitor(Framework.Data.WhereBuilder filtro)
      {
         return new ViewMonitorBusiness().Listar(filtro);
      }

      public List<ViewMonitor> ListarPropostasEmAndamento(MonitorFiltroModel filtro)
      {
         Framework.Data.WhereBuilder where = Framework.Data.WhereBuilder.Create();

         if (filtro.DDDCelular != null)
         {
            where.Add(ViewMonitor.METADADO.DDDCelular, Filter.Equal, filtro.DDDCelular, Link.And);
         }

         if (filtro.Celular != null)
         {
            where.Add(ViewMonitor.METADADO.Celular, Filter.Equal, filtro.Celular, Link.And);
         }

         where.Add(Block.Begin);

         where.Add(ViewMonitor.METADADO.Status, Filter.Equal, 3, Link.Or);
         where.Add(ViewMonitor.METADADO.Status, Filter.Equal, 6, Link.Or);

         where.Add(Block.End, Link.And);

         return new ViewMonitorBusiness().Listar(where);
      }

      public PropostaModel ObterProposta(string contrato)
      {
         int? prop = new PropostaOperacaoBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(PropostaOperacao.METADADO.ContratoLegado, Filter.Equal, contrato)).FirstOrDefault()?.Proposta;

         if (prop == null)
            return null;

         return this.ObterProposta(prop);
      }

      public PropostaModel ObterPropostaLiquidar(string contrato)
      {
         List<PropostaOperacao> prop = new PropostaOperacaoBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(PropostaOperacao.METADADO.ContratoLegado, Filter.Equal, contrato));

         if (prop == null)
            return null;

         PropostaModel proposta = null;

         foreach (PropostaOperacao o in prop)
         {
            proposta = this.ObterProposta(o.Proposta);
            //TODO: Recuperar de parametro qual é a fase ou as fases
            if (proposta.Fase == 9)
            {
               return proposta;
            }
         }

         return proposta;
      }

      public PropostaModel ObterProposta(int? id)
      {
         PropostaModel proposta = new PropostaModel();

         try
         {
            #region "Dados da Proposta"
            var tmpProp = new PropostasBusiness().Obtem(id);
            proposta.DataAlteracao = tmpProp.DataUltimaAlteracao;
            proposta.DataCriacao = tmpProp.DataCriacao;
            proposta.Fase = tmpProp.Fase;
            proposta.Gerente = (tmpProp.Gerente == null ? new Gerentes { Id = tmpProp.Gerente } : new GerentesBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(Gerentes.METADADO.Id, Filter.Equal, tmpProp.Gerente)).FirstOrDefault());
            proposta.Promotora = (tmpProp.Promotora == null ? new Promotoras { Id = tmpProp.Promotora } : new PromotorasBusiness().Obtem(tmpProp.Promotora));
            proposta.Id = tmpProp.Id;
            proposta.Observacoes = tmpProp.Observacoes;
            proposta.Status = tmpProp.Status;
            proposta.Usuario = tmpProp.Usuario.Trim();
            proposta.MotivoRecusa = tmpProp.MotivoRecusa;
            proposta.UsuarioProposta = tmpProp.UsuarioProposta;
            proposta.NomeDigitador = UsuarioService.GetInstance().Obter(tmpProp.Usuario.Trim())?.Nome;
            proposta.ProfissionalCertificado = tmpProp.ProfissionalCertificado;
            proposta.Pendente = tmpProp.Pendente;
            proposta.TipoComunicacao = tmpProp.TipoComunicacao;
            proposta.MensagemInterna = tmpProp.MensagemInterna;
            proposta.Retencao = tmpProp.Retencao;

            if (tmpProp.ProfissionalCertificado != null)
            {
               proposta.NomeProfissionalCertificado = ProfissionaisCertificadosService.GetInstance().ObterCertificados(tmpProp.ProfissionalCertificado).FirstOrDefault()?.Nome;
            }

            #endregion

            #region "Dados do Proponente"
            proposta.Proponente = new PessoasBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(Pessoas.METADADO.Id, Filter.Equal, (
               new CompromissosBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(Compromissos.METADADO.Proposta, Filter.Equal, id, Link.And)
                                                                      .Add(Compromissos.METADADO.TipoCompromisso, Filter.Equal, "CL", Link.And)).FirstOrDefault().Pessoa))
               ).FirstOrDefault();
            #endregion

            #region "Operações"
            proposta.Operacoes = new PropostaOperacaoBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(PropostaOperacao.METADADO.Proposta, Filter.Equal, id, Link.And)).FirstOrDefault();
            #endregion

            //TODO: Avaliar
            //#region "Parcelas"
            //var OperacoesCompleto = new List<PropostaOperacao>();
            //foreach (PropostaOperacao o in proposta.Operacoes)
            //{
            //   o.Parcelas = new PropostaParcelasBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(PropostaParcelas.METADADO.Operacao, Filter.Equal, o.Operacao)).OrderBy(x => x.DataVencimento).ToList();
            //   OperacoesCompleto.Add(o);
            //}
            //proposta.Operacoes = OperacoesCompleto;
            //#endregion

            #region "Contratos REFIN"
            proposta.ContratosREFIN = new PropostaContratosREFINBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(PropostaContratosREFIN.METADADO.Proposta, Filter.Equal, id, Link.And));
            #endregion


            #region "Ocorrências"
            proposta.Ocorrencias = new PropostaOcorrenciasBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(PropostaOcorrencias.METADADO.Proposta, Filter.Equal, id)).OrderBy(x => x.DataOcorrencia).ToList();
            proposta.OcorrenciasRestritivas = PropostaService.GetInstance().QtdOcorrenciasRestritivas(id);
            #endregion


            #region "Hierarquia das Consultas"
            proposta.Consultas = new PropostaHierarquiaConsultaBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(PropostaHierarquiaConsulta.METADADO.Proposta, Filter.Equal, id));
            #endregion

            //TODO: Avaliar
            #region "Historico de Propostas"
            //proposta.HistoricoPropostas = this.ObterPropostasCliente(proposta.Id).OrderByDescending(x => x.DataAtualizacao).ToList();
            #endregion

            #region "Arquivos"
            proposta.Arquivos = new PropostaArquivosBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(PropostaArquivos.METADADO.Proposta, Filter.Equal, proposta.Id));
            #endregion
         }
         catch (Exception ex)
         {

            LogService.GetInstance().GravarLogErro(ex, "Erro ao Carregar a Proposta: " + id + "\r\nMessage: " + ex.Message + "\r\nStacktrace: " + ex.StackTrace);
         }

         return proposta;
      }

      public void AtualizaProposta(PropostaModel proposta)
      {
         #region "Converte os Dados da Proposta para a Entity"
         Propostas prop = new Propostas();
         prop.DataUltimaAlteracao = DateTime.Now;
         prop.DataCriacao = proposta.DataCriacao;
         prop.Fase = proposta.Fase;
         prop.Gerente = proposta.Gerente?.Id;
         prop.Promotora = proposta.Promotora.Id;
         prop.Id = proposta.Id;
         prop.Observacoes = proposta.Observacoes;
         prop.Status = proposta.Status;
         prop.Usuario = proposta.Usuario;
         prop.MotivoRecusa = proposta.MotivoRecusa;
         prop.UsuarioProposta = proposta.UsuarioProposta;
         prop.ProfissionalCertificado = proposta.ProfissionalCertificado;
         prop.Pendente = proposta.Pendente;
         prop.TipoComunicacao = proposta.TipoComunicacao;
         prop.TipoFormalizacao = proposta.TipoFormalizacao;
         prop.MensagemInterna = proposta.MensagemInterna;
         prop.Retencao = proposta.Retencao;
         #endregion

         #region "Atualiza a Proposta"
         new PropostasBusiness().Alterar(prop);
         #endregion
      }

      public int? SalvarProposta(PropostaModel proposta)
      {
         bool IsNew = false;
         Compromissos compromisso;

         #region "Converte os Dados da Proposta para a Entity"
         Propostas prop = new Propostas();
         prop.DataUltimaAlteracao = DateTime.Now;
         prop.DataCriacao = proposta.DataCriacao;
         prop.Fase = proposta.Fase;
         prop.Gerente = proposta.Gerente?.Id;
         prop.Promotora = proposta.Promotora.Id;
         prop.Id = proposta.Id;
         prop.Observacoes = proposta.Observacoes;
         prop.Status = proposta.Status;
         prop.Usuario = proposta.Usuario;
         prop.MotivoRecusa = proposta.MotivoRecusa;
         prop.UsuarioProposta = proposta.UsuarioProposta;
         prop.ProfissionalCertificado = proposta.ProfissionalCertificado;
         prop.Pendente = proposta.Pendente;
         prop.TipoComunicacao = proposta.TipoComunicacao;
         prop.TipoFormalizacao = proposta.TipoFormalizacao;
         prop.MensagemInterna = proposta.MensagemInterna;
         prop.Retencao = proposta.Retencao;
         #endregion

         #region "Atualiza a Proposta"
         if (prop.Id == null)
         {
            IsNew = true;
            new PropostasBusiness().Incluir(prop);
         }
         else
         {
            new PropostasBusiness().Alterar(prop);
         }
         proposta.Id = prop.Id;
         #endregion

         #region "Atualiza o Proponente"
         if (IsNew)
         {
            new PessoasBusiness().Incluir(proposta.Proponente);
            compromisso = new Compromissos();
            compromisso.Proposta = prop.Id;
            compromisso.TipoCompromisso = "CL";
            compromisso.Pessoa = proposta.Proponente.Id;
            new CompromissosBusiness().Incluir(compromisso);
            PropostaHierarquiaConsulta hierarquia = new PropostaHierarquiaConsulta();
            hierarquia.Nivel = 1;
            hierarquia.Papel = "CL";
            hierarquia.Pessoa = proposta.Proponente.Id;
            hierarquia.PessoaPai = 0;
            hierarquia.Proposta = prop.Id;
            new PropostaHierarquiaConsultaBusiness().Incluir(hierarquia);
         }
         else
         {
            new PessoasBusiness().Alterar(proposta.Proponente);
         }
         #endregion

         #region "Atualiza as Operações/Parcelas Propostas"

         if (!IsNew)
         {
            new PropostaOperacaoBusiness().Excluir(prop.Id);
            new PropostaParcelasBusiness().ExcluirPorProposta(prop.Id);
            new PropostaContratosREFINBusiness().ExcluirPorProposta(prop.Id);
         }

         //foreach (PropostaOperacao p in proposta.Operacoes)
         //{
         //   p.Proposta = prop.Id;
         //   new PropostaOperacaoBusiness().Incluir(p);

         //   foreach (PropostaParcelas pp in p.Parcelas)
         //   {
         //      pp.Operacao = p.Operacao;
         //      pp.Proposta = prop.Id;
         //      new PropostaParcelasBusiness().Incluir(pp);
         //   }
         //}

         proposta.Operacoes.Proposta = prop.Id;
         new PropostaOperacaoBusiness().Incluir(proposta.Operacoes);

         foreach (PropostaParcelas pp in proposta.Operacoes.Parcelas)
         {
            pp.Operacao = proposta.Operacoes.Operacao;
            pp.Proposta = prop.Id;
            new PropostaParcelasBusiness().Incluir(pp);
         }


         #endregion

         #region "Busca as Ocorrencias"
         proposta.Ocorrencias = PropostaService.GetInstance().ListarOcorrenciasProposta(proposta.Id);
         if (proposta.Ocorrencias == null)
            proposta.Ocorrencias = new List<PropostaOcorrencias>();
         #endregion

         return prop.Id;
      }

      public void SubmeterProposta(PropostaModel proposta)
      {
         try
         {
            if (proposta.Pendente)
            {
               var pendencia = new PropostaPendenciaBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(PropostaPendencia.METADADO.Proposta, Filter.Equal, proposta.Id, Link.And).Add(PropostaPendencia.METADADO.FaseDestino, Filter.Equal, this.ObtemFase(proposta.Fase).Id, Link.And).Add(PropostaPendencia.METADADO.Concluido, Filter.Equal, false, Link.And)).FirstOrDefault();

               if (!string.IsNullOrEmpty(pendencia.Validacoes))
               {
                  dynamic pol = JsonConvert.DeserializeObject<dynamic>(pendencia.Validacoes);

                  if (!string.IsNullOrEmpty((string)pol.Retorno))
                  {
                     ExecutaPolitica((string)pol.Retorno, proposta, this.ObtemFase(pendencia.FaseAtual).Id, "F");
                  }
               }

               this.GravarHistoricoProposta(proposta, "RetornarPendenciaProposta");
               proposta.Pendente = false;
               proposta.Status = pendencia.StatusAtual;
               proposta.Fase = this.ObtemFase(pendencia.FaseAtual).Id;
               proposta.UsuarioProposta = pendencia.Analista;
               TransactionHelper.Run(TransactionScopeOption.Required, () => this.AtualizaProposta(proposta));
               this.GravarHistoricoProposta(proposta, "");
               //this.DesbloquearProposta(proposta, true);
               pendencia.Concluido = true;

               new PropostaPendenciaBusiness().Alterar(pendencia);

               return;
            }
         }
         catch (NaoMePerturbeBloqueadoException ex)
         {
            proposta.Status = 1;
            this.AtualizaProposta(proposta);
            throw new Exception(ex.Message);
         }
         catch (Exception wz)
         {
            LogService.GetInstance().GravarLogErro(wz, "Falha ao Liberar a Pendência da Proposta: " + proposta.Id + " - Mensagem: " + wz.Message + " - Stacktrace: " + wz.StackTrace);
            throw new Exception("Falha ao Liberar a Pendência - " + wz.Message);
         }

         //Verifica qual a fase da proposta
         int? fase = PropostaService.GetInstance().ObtemFase(proposta.Fase).Id;

         //se for entrada na fase chama as politicas de entrada
         bool entrada = false;
         //se for saida da fase ... chama as politicas de saida
         bool saida = false;

         if (proposta.Id == null)
         {
            entrada = true;
         }
         else
         {
            //Tem que pensar melhor como fazer aqui
            var propostaAnterior = ObterProposta(proposta.Id);

            if (propostaAnterior.Fase != proposta.Fase)
            {
               saida = true;
               //var faseProposta = (Enums.Fase)UtilityHelper.GetEnumValueFromDescription<Enums.Fase>(proposta.Fase);

               //var proximaFase = PropostaService.GetInstance().BuscaProximaFase(fase);

            }
            else
            {
               if (proposta.Status == 8 || proposta.Status == 11 || proposta.Status == 10)
               {
                  proposta.Status = 3;
                  entrada = true;
               }
               else
               {
                  saida = true;

                  var politicasSaida = ListarPoliticasFase(fase, proposta.Operacoes.Produto, proposta.Status, entrada, saida);

                  if (politicasSaida == null || politicasSaida.Count == 0)
                  {
                     saida = false;
                     entrada = true;

                     var politicasEntrada = ListarPoliticasFase(fase, proposta.Operacoes.Produto, proposta.Status, entrada, saida);

                  }


               }
            }
         }

         TransactionHelper.Run(TransactionScopeOption.Required, () => AtualizaProposta(proposta));

         List<PoliticaConfiguracaoExecucao> politicas = null;

         try
         {
            if (!fase.HasValue)
               throw new Exception("Fase não pode ser nulo!");

            if (string.IsNullOrEmpty(proposta.Operacoes.Produto.ToString()))
               throw new Exception("Proposta não tem produto!");

            if (string.IsNullOrEmpty(proposta.Status.ToString()))
               throw new Exception("Proposta não tem status!");

            politicas = ListarPoliticasFase(fase, proposta.Operacoes.Produto, proposta.Status, entrada, saida);

            if (politicas == null)
               throw new Exception("Nenhuma politica foi encontrada!");
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogErro(ex, "Erro ao tentar obter politicas");

            throw new Exception("Erro ao tentar obter politicas", ex);
         }

         foreach (PoliticaConfiguracaoExecucao p in politicas)
         {
            if (proposta.Proponente.TipoPessoa == p.TipoPessoaCodigo)
            {
               try
               {
                  LogService.GetInstance().GravarLogDebug("Executando a Politica: " + p.Metodo, proposta);
                  ExecutaPolitica(p.Metodo, proposta, fase, p.TipoPessoaCodigo);
               }
               catch (WaitException)
               {
                  LogService.GetInstance().GravarLogInfo("Wait Exception encontrato na Politica: " + p.Metodo, proposta);
                  TransactionHelper.Run(TransactionScopeOption.Required, () => AtualizaProposta(proposta));
                  break;
               }
               catch (ValidacaoDadosException ex)
               {
                  if (proposta.Status == 12)
                  {
                     proposta.Status = 6;
                  }

                  LogService.GetInstance().GravarLogWarning(ex, "Erro na Execução da Politica: " + p.Metodo, proposta);

                  TransactionHelper.Run(TransactionScopeOption.Required, () => AtualizaProposta(proposta));
                  proposta = ObterProposta(proposta.Id);
                  throw new Exception(ex.Message, ex);
               }
               catch (Exception ex)
               {
                  if (proposta.Status == 12)
                  {
                     proposta.Status = 6;
                  }

                  LogService.GetInstance().GravarLogErro(ex, "Erro na Execução da Politica: " + p.Metodo, proposta);

                  TransactionHelper.Run(TransactionScopeOption.Required, () => AtualizaProposta(proposta));
                  proposta = ObterProposta(proposta.Id);
                  throw new Exception(ex.Message, ex);
               }
            }
         }

         /*
            Liberando a proposta após a execução das politicas, necessário estar neste ponto para geração do histórico da proposta. 
         */
         DesbloquearProposta(proposta);
      }

      public void SubmeterProposta(int? proposta)
      {
         PropostaModel prop = this.ObterProposta(proposta);
         this.SubmeterProposta(prop);
      }

      public void RejeitaProposta(PropostaModel proposta, string usuario, bool gravarHistorico = true)
      {
         proposta.Status = 4;

         if (gravarHistorico)
            PropostaService.GetInstance().GravarHistoricoProposta(proposta, "RejeitarProposta");

         InsereOcorrencia(proposta.Id, 1, proposta?.MotivoRecusa?.ToUpper(), "S", usuario);

         //TODO: Fazer as outras verificações aqui (remover consignação por exemplo)
         proposta.MensagemInterna = (proposta.MensagemInterna == null ? proposta?.MotivoRecusa?.ToUpper() : proposta.MensagemInterna);

         var produto = PropostaService.GetInstance().ObtemProduto(proposta.Operacoes.Produto);

         this.GravarHistoricoProposta(proposta);
         // liberando a proposta
         DesbloquearProposta(proposta);

         AtualizaProposta(proposta);
      }
      /// <summary>
      /// Bloqueia a proposta para um usuário específico impedindo que outro usuário opere.
      /// </summary>
      /// <param name="idProposta"></param>
      /// <param name="usuario"></param>
      public void BloquearProposta(int? idProposta, string usuario)
      {
         // obtém a proposta a ser bloqueada
         var proposta = ObterProposta(idProposta);

         // proposta já bloqueada
         if (proposta.UsuarioProposta != null)
            return;

         var produto = PropostaService.GetInstance().ObtemProduto(proposta.Operacoes.Produto);
         dynamic parametros = JsonConvert.DeserializeObject(produto.Parametros);

         if (!(bool)parametros.BloquearProposta)
            return;

         //// validando se a proposta já está bloqueada para o mesmo usuário.
         //if (proposta.UsuarioProposta == usuario)
         //    return;

         //// tentativa de um novo bloqueio, como a proposta já está bloqueada para outro usuário neste caso não faz nada.
         //if (proposta.UsuarioProposta != null && proposta.UsuarioProposta != usuario)
         //    return;

         // somente é permitido bloquear a proposta para o usuário quando for uma nova ou houver um desbloqueio antes.
         if (proposta.UsuarioProposta == null)
            proposta.UsuarioProposta = usuario; // Bloqueando a proposta para o usuário

         Propostas prop = new Propostas();
         prop.Id = proposta.Id;
         prop.UsuarioProposta = usuario;

         new PropostasBusiness().Bloquear(prop);

         this.GravarHistoricoProposta(proposta, "BloquearProposta");

         // persistindo alterações
         //SalvarProposta(proposta);
      }
      /// <summary>
      /// Desbloqueia a proposta para outro usuário operar.
      /// </summary>
      /// <param name="novaProposta">Nova Proposta.</param>

      public void DesbloquearProposta(PropostaModel novaProposta, bool forcaDesbloqueio = false)
      {
         // obtém a proposta a ser bloqueada
         var proposta = ObterProposta(novaProposta.Id);

         // validando se a proposta já está desbloqueada, caso já esteja é só sair da função.
         if (proposta.UsuarioProposta == null)
            return;

         // somente ocorre o desbloqueio pelo mesmo usuário que bloqueou ou quem tiver alçada para forçar o desbloqueio
         if (!forcaDesbloqueio && proposta.UsuarioProposta != novaProposta.UsuarioProposta)
            return;

         this.GravarHistoricoProposta(proposta, "DesbloquearProposta");
         // Desbloqueando a proposta para qualquer outro usuário operar.
         novaProposta.UsuarioProposta = null;

         Propostas prop = new Propostas();
         prop.Id = novaProposta.Id;
         prop.UsuarioProposta = null;

         new PropostasBusiness().Desbloquear(prop);

         //SalvarProposta(novaProposta);
      }
      /// <summary>
      /// Proposta está bloqueada?
      /// </summary>
      /// <param name="idProposta"></param>
      /// <returns></returns>
      public bool PropostaBloqueada(int? idProposta) => ObterProposta(idProposta).UsuarioProposta != null;

      public List<ViewMonitor> ListarPropostasCliente(string cpfCnpj, int? dddCelular, int? Celular)
      {
         Framework.Data.WhereBuilder where = Framework.Data.WhereBuilder.Create();

         where.Add(ViewMonitor.METADADO.CPFCNPJ, Filter.Equal, cpfCnpj, Link.Or);

         if (dddCelular != null)
         {
            where.Add(Block.Begin);
            where.Add(ViewMonitor.METADADO.DDDCelular, Filter.Equal, dddCelular, Link.And);
            where.Add(ViewMonitor.METADADO.Celular, Filter.Equal, Celular, Link.And);
            where.Add(Block.End, Link.And);
         }

         return new ViewMonitorBusiness().Listar(where);
      }

      public List<PropostaHistorico> ObterPropostasCliente(long? proposta)
      {
         Framework.Data.WhereBuilder where = Framework.Data.WhereBuilder.Create().Add(PropostaHistorico.METADADO.Proposta, Filter.Equal, proposta, Link.And);

         return new PropostaHistoricoBusiness().Listar(where);
      }

      public void InserirHistoricoRelacionamento(PropostaHistorico historicoRelacionamento)
      {
         new PropostaHistoricoBusiness().Incluir(historicoRelacionamento);
      }

      //TODO: Avaliar
      //public List<Parcelas> CalculaParcelasSicred(PropostaModel proposta)
      //{
      //   CalculoParcelaFlexRequestModel request = new CalculoParcelaFlexRequestModel();

      //   var produto = ObtemProduto(proposta.Operacoes[0].TipoProduto);

      //   dynamic parametros = JsonConvert.DeserializeObject(produto.Parametros);

      //   request.empresa = parametros.empresa;
      //   request.agencia = parametros.agencia;
      //   request.loja = proposta.Operacoes[0].Loja;
      //   request.lojista = proposta.Operacoes[0].RedeLojas;
      //   request.plano = proposta.Operacoes[0].Tabela;
      //   request.produto = parametros.produto;
      //   request.cpf = ("0000000000000000" + proposta.Proponente.CpfCnpj.Trim()).Right(11);
      //   request.parcelasFlex = new List<ParcelasFlex>();

      //   foreach (var x in proposta.Operacoes[0].Parcelas)
      //   {
      //      if (x.ValorParcela > 0)
      //      {
      //         request.parcelasFlex.Add(new ParcelasFlex { valorMaximo = x.ValorParcela, vcto = x.DataVencimento.Value.ToString("yyyy-MM-dd") });
      //      }
      //   }

      //   request.taxa = double.Parse(SICREDServices.GetInstance().ObterPrazo(request.empresa, proposta.Operacoes[0].Tabela, request.parcelasFlex.Count.ToString("000")).Taxa.ToString());

      //   CalculoParcelaFlexResponseModel response = SICREDServices.GetInstance().CalcularParcelasFlex(request);

      //   proposta.Operacoes[0].CETAno = response.cetAno;
      //   proposta.Operacoes[0].CETMes = response.cetMes;
      //   proposta.Operacoes[0].DataEmissao = response.dataEmissao;
      //   proposta.Operacoes[0].DataPrimeiroVencimento = response.dataPrimeiroVencimento;
      //   proposta.Operacoes[0].Prazo = response.prazo;
      //   proposta.Operacoes[0].Taxa = response.taxaMes;
      //   proposta.Operacoes[0].TaxaAno = response.taxaAno;
      //   proposta.Operacoes[0].TaxaMes = response.taxaMes;
      //   proposta.Operacoes[0].ValorEntrada = response.valorEntrada;
      //   proposta.Operacoes[0].ValorFinanciadoTotal = response.valorFinanciadoTotal;
      //   proposta.Operacoes[0].ValorIOF = response.valorIOF;
      //   proposta.Operacoes[0].ValorIOFAdicional = response.valorIOFAdicional;
      //   proposta.Operacoes[0].ValorIOFNormal = response.valorIOFNormal;
      //   proposta.Operacoes[0].ValorLiberado = response.valorLiberado;
      //   proposta.Operacoes[0].ValorOperacao = response.valorSolicitado;
      //   proposta.Operacoes[0].ValorPST = response.valorPST;
      //   proposta.Operacoes[0].ValorSeguro = response.valorSeguro;
      //   proposta.Operacoes[0].ValorTAC = response.valorTAC;
      //   proposta.Operacoes[0].ValorTFC = response.valorTFC;

      //   foreach (var p in response.parcelas)
      //   {
      //      int l = 0;
      //      while (true)
      //      {
      //         if (proposta.Operacoes[0].Parcelas[l].DataVencimento == p.vcto)
      //         {
      //            proposta.Operacoes[0].Parcelas[l].IofAdicional = p.iofAdicional;
      //            proposta.Operacoes[0].Parcelas[l].IofNormal = p.iofNormal;
      //            proposta.Operacoes[0].Parcelas[l].Parcela = p.parcela;
      //            proposta.Operacoes[0].Parcelas[l].Principal = p.principal;
      //            proposta.Operacoes[0].Parcelas[l].Renda = p.renda;
      //            proposta.Operacoes[0].Parcelas[l].ValorParcela = p.pmt;
      //            proposta.Operacoes[0].Parcelas[l].ValorRepasse = (p.principal - (p.iofNormal + p.iofAdicional));
      //            break;
      //         }
      //         l++;
      //      }
      //   }

      //   return proposta.Operacoes[0].Parcelas;
      //}
      public void PendenciarProposta(PropostaModel proposta, int? ocorrencia, string complemento, string usuario)
      {
         var ocorrenciafase = this.ListarOcorrenciasProdutoXOcorrencia(proposta.Operacoes.Produto, this.ObtemFase(proposta.Fase).Id, ocorrencia).FirstOrDefault();

         //Incluir o Histório da pendencia
         new PropostaPendenciaBusiness().Incluir(new PropostaPendencia { Proposta = proposta.Id, Concluido = false, DataHora = DateTime.Now, FaseAtual = this.ObtemFase(proposta.Fase).Id, FaseDestino = ocorrenciafase.FaseDestino, StatusAtual = proposta.Status, Analista = proposta.UsuarioProposta, Validacoes = ocorrenciafase.Validacoes });
         proposta.Pendente = true;
         proposta.Status = 1;
         proposta.Fase = this.ObtemFase(ocorrenciafase.FaseDestino).Id;
         proposta.MensagemInterna = complemento.ToUpper();
         //Inserir a Ocorrência
         this.InsereOcorrencia(proposta.Id, ocorrencia, complemento, "P", usuario);
         this.SalvarProposta(proposta);
         this.GravarHistoricoProposta(proposta, "PendenciarProposta");
      }
      public void PendenciarProposta(PropostaModel proposta, int? faseDestino, PropostaOcorrencias ocorrencia, string usuario)
      {
         var ocorrenciafase = this.ListarOcorrenciasProdutoXFase(proposta.Operacoes?.Produto, ocorrencia.Fase).FirstOrDefault();
         //Incluir o Histório da pendencia
         new PropostaPendenciaBusiness().Incluir(new PropostaPendencia { Proposta = proposta.Id, Concluido = false, DataHora = DateTime.Now, FaseAtual = this.ObtemFase(proposta.Fase).Id, FaseDestino = faseDestino, StatusAtual = proposta.Status, Analista = proposta.UsuarioProposta, Validacoes = ocorrenciafase.Validacoes });
         proposta.Pendente = true;
         proposta.Status = 1;
         proposta.Fase = this.ObtemFase(faseDestino).Id;
         proposta.MensagemInterna = ocorrencia.Complemento.ToUpper();
         //Inserir a Ocorrência
         this.InsereOcorrencia(proposta.Id, ocorrencia.Ocorrencia, ocorrencia.Complemento, ocorrencia.Restritiva, usuario);
         this.SalvarProposta(proposta);
         this.GravarHistoricoProposta(proposta, "PendenciarProposta");
      }

      public List<ViewContratosREFINUtilizados> ContratosRefinUtilizados()
      {
         return new ViewContratosREFINUtilizadosBusiness().Listar(null);
      }

      #endregion

      #region "Pessoas"
      public List<Pessoas> BuscaPessoaPorCelular(int? ddd, int? celular, string cpfCnpj = null, bool excluirCpfCnpjInformado = false)
      {
         Framework.Data.WhereBuilder filtro = Framework.Data.WhereBuilder.Create().Add(Pessoas.METADADO.DDDCelular, Filter.Equal, ddd, Link.And).Add(Pessoas.METADADO.Celular, Filter.Equal, celular);

         if (cpfCnpj != null)
         {
            if (excluirCpfCnpjInformado)
            {
               filtro.Add(Pessoas.METADADO.CpfCnpj, Filter.NotEqual, cpfCnpj);
            }
            else
            {
               filtro.Add(Pessoas.METADADO.CpfCnpj, Filter.Equal, cpfCnpj);
            }
         }

         return new PessoasBusiness().Listar(filtro);
      }

      public List<Pessoas> BuscaPessoaPorEmail(string email, string cpfCnpj = null, bool excluirCpfCnpjInformado = false)
      {
         Framework.Data.WhereBuilder filtro = Framework.Data.WhereBuilder.Create().Add(Pessoas.METADADO.Email, Filter.Equal, email, Link.And);

         if (cpfCnpj != null)
         {
            if (excluirCpfCnpjInformado)
            {
               filtro.Add(Pessoas.METADADO.CpfCnpj, Filter.NotEqual, cpfCnpj);
            }
            else
            {
               filtro.Add(Pessoas.METADADO.CpfCnpj, Filter.Equal, cpfCnpj);
            }
         }

         return new PessoasBusiness().Listar(filtro);
      }

      public List<Pessoas> BuscaPessoaPorCpfCnpj(string cpfCnpj)
      {
         Framework.Data.WhereBuilder filtro = Framework.Data.WhereBuilder.Create();

         if (cpfCnpj != null)
         {
            filtro.Add(Pessoas.METADADO.CpfCnpj, Filter.Equal, cpfCnpj);
         }

         return new PessoasBusiness().Listar(filtro);
      }

      //TODO: Avaliar
      //public Pessoas BuscarUltimoCadastro(string cpfCnpj)
      //{
      //   var monitor = new ViewMonitorBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(ViewMonitor.METADADO.CPFCNPJ, Filter.Equal, cpfCnpj.ToString()).Add(ViewMonitor.METADADO.Fase, Filter.Equal, "FORMALIZAÇÃO")).OrderByDescending(x => x.Proposta).FirstOrDefault();

      //   if (monitor == null)
      //   {
      //      return null;
      //   }
      //   else
      //   {
      //      var pessoa = new CompromissosBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(Compromissos.METADADO.Proposta, Filter.Equal, monitor.Proposta, Link.And).Add(Compromissos.METADADO.TipoCompromisso, Filter.Equal, "CL")).FirstOrDefault();
      //      return new PessoasBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(Pessoas.METADADO.Id, Filter.Equal, pessoa.Pessoa)).FirstOrDefault();
      //   }

      //   //TODO: Talvez o Comercial queira o último cadastro aprovado.... agora esta buscando o último cadastrado

      //}
      public Pessoas ObtemPessoa(long? Id)
      {
         return new PessoasBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(Pessoas.METADADO.Id, Filter.Equal, Id)).FirstOrDefault();
      }
      #endregion

      #region "Simulação"
      public int? SalvarSimulacao(SimulacaoPropostaModel simulacao)
      {
         SimulacaoProposta simulacaoProposta = new SimulacaoProposta();

         if (simulacao.Id == null)
         {
            SimulacaoPessoa pessoa = simulacao.Proponente;

            if (UtilityHelper.IsCpf(pessoa.CpfCnpj))
            {
               pessoa.TipoPessoa = "F";
               pessoa.CpfCnpj = long.Parse(pessoa.CpfCnpj).ToString().PadLeft(11, '0');
            }
            else
            {
               pessoa.TipoPessoa = "J";
               pessoa.CpfCnpj = long.Parse(pessoa.CpfCnpj).ToString().PadLeft(14, '0');
            }

            try
            {
               var celular = simulacao.Celular.Split(' ');

               pessoa.DDDCelular = Convert.ToInt32(celular[0].Replace("(", "").Replace(")", ""));
               pessoa.Celular = Convert.ToInt32(celular[1].Replace("-", ""));
               pessoa.EspecieBeneficio = simulacao.Proponente.EspecieBeneficio;
               pessoa.IndicadorAnalfabetismo = simulacao.Proponente.IndicadorAnalfabetismo;
               pessoa.Orgao = simulacao.Proponente.Orgao;
               pessoa.NumeroBeneficio2 = simulacao.Proponente.NumeroBeneficio2;
            }
            catch (Exception)
            {

            }

            new SimulacaoPessoaBusiness().Incluir(pessoa);

            simulacaoProposta.DataCriacao = DateTime.Now;
            simulacaoProposta.Usuario = simulacao.Usuario;
            simulacaoProposta.Pessoa = pessoa.Id;
            simulacaoProposta.Promotora = simulacao.Promotora;
            simulacaoProposta.Guid = simulacao.Guid;
            simulacaoProposta.TipoComunicacao = simulacao.TipoComunicacao;
            simulacaoProposta.TipoFormalizacao = simulacao.TipoFormalizacao;
            simulacaoProposta.Taxa = simulacao.Taxa;
            simulacaoProposta.Retencao = simulacao.Retencao;

            new SimulacaoPropostaBusiness().Incluir(simulacaoProposta);

            simulacao.Id = simulacaoProposta.Id;

            SimulacaoOperacao operacao = simulacao.Operacao;
            operacao.Simulacao = simulacaoProposta.Id;
            operacao.RedeLojas = operacao.RedeLojas;
            operacao.Loja = operacao.Loja;
            operacao.Tabela = operacao.Tabela;
            operacao.MetodoAmortizacao = simulacao.MetodoAmortizacao;
            operacao.ValorMargem = simulacao.ValorMargem;
            operacao.ValorRenegociacaoTotal = simulacao.Operacao.ValorRenegociacaoTotal;

            new SimulacaoOperacaoBusiness().Incluir(operacao);

            foreach (SimulacaoParcelas p in simulacao.Parcelas)
            {
               p.Simulacao = simulacaoProposta.Id;
               new SimulacaoParcelasBusiness().Incluir(p);
            }

            foreach (SimulacaoContratosREFIN c in simulacao.ContratosREFIN)
            {
               c.Simulacao = simulacaoProposta.Id;
               new SimulacaoContratosREFINBusiness().Incluir(c);
            }

            foreach (SimulacaoParcelasREFIN c in simulacao.ParcelasREFIN)
            {
               c.Simulacao = simulacaoProposta.Id;
               new SimulacaoParcelasREFINBusiness().Incluir(c);
            }
         }
         else
         {
            SimulacaoPessoa pessoa = simulacao.Proponente;

            if (UtilityHelper.IsCpf(pessoa.CpfCnpj))
            {
               pessoa.TipoPessoa = "F";
               pessoa.CpfCnpj = long.Parse(pessoa.CpfCnpj.OnlyNumbers()).ToString().PadLeft(11, '0');
            }
            else
            {
               pessoa.TipoPessoa = "J";
               pessoa.CpfCnpj = long.Parse(pessoa.CpfCnpj.OnlyNumbers()).ToString().PadLeft(14, '0');
            }

            try
            {
               var celular = simulacao.Celular.Split(' ');

               pessoa.DDDCelular = Convert.ToInt32(celular[0].OnlyNumbers().Replace("(", "").Replace(")", ""));
               pessoa.Celular = Convert.ToInt32(celular[1].OnlyNumbers().Replace("-", ""));
            }
            catch (Exception)
            {

            }

            pessoa.EspecieBeneficio = simulacao.Proponente.EspecieBeneficio;

            new SimulacaoPessoaBusiness().Alterar(pessoa);

            simulacaoProposta.Pessoa = pessoa.Id;
            simulacaoProposta.Promotora = simulacao.Promotora;
            simulacaoProposta.Guid = simulacao.Guid;
            simulacaoProposta.TipoComunicacao = simulacao.TipoComunicacao;
            simulacaoProposta.TipoFormalizacao = simulacao.TipoFormalizacao;
            simulacaoProposta.Taxa = simulacao.Taxa;
            simulacaoProposta.DataCriacao = simulacao.DataCriacao;
            simulacaoProposta.Usuario = simulacao.Usuario;
            simulacaoProposta.Autorizacao = simulacao.Autorizacao;
            simulacaoProposta.Guid = simulacao.Guid;
            simulacaoProposta.Id = simulacao.Id;
            simulacaoProposta.Retencao = simulacao.Retencao;

            new SimulacaoPropostaBusiness().Alterar(simulacaoProposta);

            SimulacaoOperacao operacao = simulacao.Operacao;
            operacao.Simulacao = simulacao.Id;
            operacao.RedeLojas = operacao.RedeLojas;
            operacao.Loja = operacao.Loja;
            operacao.Tabela = operacao.Tabela;
            operacao.Id = simulacao.Operacao.Id;
            operacao.MetodoAmortizacao = simulacao.MetodoAmortizacao;
            operacao.ValorMargem = simulacao.ValorMargem;

            new SimulacaoOperacaoBusiness().Alterar(operacao);

            try
            {
               new SimulacaoParcelasBusiness().ExcluirPor_Simulacao(simulacao.Id);
            }
            catch (Exception ex)
            {
               LogService.GetInstance().GravarLogErro(ex, "Falha ao Excluir as Parcelas da Simulação " + simulacao.Id, simulacao);
            }

            foreach (SimulacaoParcelas p in simulacao.Parcelas)
            {
               p.Simulacao = simulacao.Id;
               new SimulacaoParcelasBusiness().Incluir(p);
            }

            if (new SimulacaoContratosREFINBusiness().Listar(WhereBuilder.Create().Add(SimulacaoContratosREFIN.METADADO.Simulacao, Filter.Equal, simulacao.Id)).Count() > 0)
            {
               foreach (SimulacaoContratosREFIN c in simulacao.ContratosREFIN)
               {
                  c.Simulacao = simulacao.Id;
                  new SimulacaoContratosREFINBusiness().Alterar(c);
               }
            }
            else
            {
               foreach (SimulacaoContratosREFIN c in simulacao.ContratosREFIN)
               {
                  c.Simulacao = simulacao.Id;
                  new SimulacaoContratosREFINBusiness().Incluir(c);
               }
            }

            if (new SimulacaoParcelasREFINBusiness().Listar(WhereBuilder.Create().Add(SimulacaoParcelasREFIN.METADADO.Simulacao, Filter.Equal, simulacao.Id)).Count() > 0)
            {
               foreach (SimulacaoParcelasREFIN c in simulacao.ParcelasREFIN)
               {
                  c.Simulacao = simulacao.Id;
                  new SimulacaoParcelasREFINBusiness().Alterar(c);
               }
            }
            else
            {
               foreach (SimulacaoParcelasREFIN c in simulacao.ParcelasREFIN)
               {
                  c.Simulacao = simulacao.Id;
                  new SimulacaoParcelasREFINBusiness().Incluir(c);
               }
            }


         }

         return simulacao.Id;
      }

      public void SubmeterSimulacao(SimulacaoPropostaModel simulacao, bool entrada = true, bool saida = false)
      {
         var politicas = ListarPoliticasSimulacao(simulacao.Operacao.Produto, entrada, saida);

         foreach (PoliticaConfiguracaoExecucaoSimulacao p in politicas)
         {
            if (simulacao.Proponente.TipoPessoa == p.TipoPessoaCodigo)
            {
               try
               {
                  LogService.GetInstance().GravarLogDebug("Processando o Método: " + p.Metodo);
                  ExecutaPoliticaSimulacao(p.Metodo, simulacao);
               }
               catch (InformationException exi)
               {
                  LogService.GetInstance().GravarLogWarning(exi, "Erro ao Processar a Simulação");
                  SalvarSimulacao(simulacao);
                  throw new InformationException(exi.Message, exi.code);
               }
               catch (NaoMePerturbeException exi)
               {
                  LogService.GetInstance().GravarLogWarning(exi, "Erro ao Processar a Simulação");
                  SalvarSimulacao(simulacao);
                  throw new NaoMePerturbeException(exi.Message, exi.code);
               }
               catch (NaoMePerturbeBloqueadoException exi)
               {
                  LogService.GetInstance().GravarLogWarning(exi, "Erro ao Processar a Simulação");
                  SalvarSimulacao(simulacao);
                  throw new NaoMePerturbeBloqueadoException(exi.Message, exi.code);
               }
               catch (INSSException ex)
               {
                  LogService.GetInstance().GravarLogWarning(ex, "Erro ao Processar a Simulação");
                  SalvarSimulacao(simulacao);
                  throw new Exception(ex.Message, ex);
               }
               catch (ValidacaoDadosException ex)
               {
                  LogService.GetInstance().GravarLogWarning(ex, "Erro ao Processar a Simulação");
                  SalvarSimulacao(simulacao);
                  throw new Exception(ex.Message, ex);
               }
               catch (Exception ex)
               {
                  LogService.GetInstance().GravarLogErro(ex, "Erro ao Processar a Simulação");
                  SalvarSimulacao(simulacao);
                  throw new Exception(ex.Message, ex);
               }
            }
         }
      }

      public void EfetivarSimulacao(SimulacaoPropostaModel simulacao, bool entrada = false, bool saida = true)
      {
         var politicas = ListarPoliticasSimulacao(simulacao.Operacao.Produto, entrada, saida);

         foreach (PoliticaConfiguracaoExecucaoSimulacao p in politicas)
         {
            if (simulacao.Proponente.TipoPessoa == p.TipoPessoaCodigo)
            {
               try
               {
                  LogService.GetInstance().GravarLogDebug("Processando a Politica: " + p.Metodo);
                  ExecutaPoliticaSimulacao(p.Metodo, simulacao);
               }
               catch (DataPrevException exi)
               {
                  LogService.GetInstance().GravarLogDebug(exi, "Erro ao Efetivar Simulação");
                  SalvarSimulacao(simulacao);
                  throw new Exception("Falha na comunicação com a DataPrev, favor tente novamente mais tarde!");
               }
               catch (InformationException exi)
               {
                  LogService.GetInstance().GravarLogWarning(exi, "Erro ao Efetivar Simulação");
                  SalvarSimulacao(simulacao);
                  throw new InformationException(exi.Message, exi.code);
               }
               catch (INSSException ex)
               {
                  LogService.GetInstance().GravarLogWarning(ex, "Erro ao Efetivar a Simulação");
                  SalvarSimulacao(simulacao);
                  throw new Exception(ex.Message, ex);
               }
               catch (ValidacaoDadosException ex)
               {
                  LogService.GetInstance().GravarLogWarning(ex, "Erro ao Efetivar a Simulação");
                  SalvarSimulacao(simulacao);
                  throw new Exception(ex.Message, ex);
               }
               catch (Exception ex)
               {
                  LogService.GetInstance().GravarLogErro(ex, "Erro ao Efetivar a Simulação");
                  SalvarSimulacao(simulacao);
                  throw new Exception(ex.Message, ex);
               }
            }
         }
      }

      public SimulacaoPropostaModel ObterSimulacao(int? simulacao)
      {
         SimulacaoPropostaModel retorno = new SimulacaoPropostaModel();
         SimulacaoProposta proposta = new SimulacaoPropostaBusiness().Obtem(simulacao);

         retorno.Id = proposta.Id;
         retorno.DataCriacao = proposta.DataCriacao;
         retorno.Usuario = proposta.Usuario;
         retorno.Promotora = proposta.Promotora;
         retorno.TipoComunicacao = proposta.TipoComunicacao;
         retorno.Taxa = proposta.Taxa;
         retorno.Autorizacao = proposta.Autorizacao;
         retorno.Proponente = new SimulacaoPessoaBusiness().Obtem(proposta.Pessoa);
         retorno.Operacao = new SimulacaoOperacaoBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(SimulacaoOperacao.METADADO.Simulacao, Filter.Equal, simulacao)).FirstOrDefault();
         retorno.Parcelas = new SimulacaoParcelasBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(SimulacaoParcelas.METADADO.Simulacao, Filter.Equal, simulacao));
         retorno.ContratosREFIN = new SimulacaoContratosREFINBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(SimulacaoContratosREFIN.METADADO.Simulacao, Filter.Equal, simulacao));
         retorno.ParcelasREFIN = new SimulacaoParcelasREFINBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(SimulacaoParcelasREFIN.METADADO.Simulacao, Filter.Equal, simulacao));
         retorno.Celular = string.Format("({0}) {1}", retorno.Proponente.DDDCelular.ToString(), retorno.Proponente.Celular.ToString());
         retorno.MetodoAmortizacao = retorno.Operacao.MetodoAmortizacao;
         retorno.TipoFormalizacao = proposta.TipoFormalizacao;
         //retorno.EspecieBeneficio = retorno.Proponente.EspecieBeneficio;
         retorno.ValorMargem = retorno.Operacao.ValorMargem;
         retorno.Guid = proposta.Guid;
         retorno.Retencao = proposta.Retencao;

         return retorno;
      }

      public PropostaModel SubmeterPrecaptura(SimulacaoPropostaModel simulacao)
      {
         if (simulacao.Proponente.CpfCnpj == null)
         {
            throw new Exception("O CPF/CNPJ deve ser Informado...");
         }

         if (simulacao.Operacao.Produto == null)
         {
            throw new Exception("É necessário selecionar um produto para prosseguir...");
         }
         //TODO: Ajustar
         //if (PropostaService.GetInstance().ObtemLoja(simulacao.PropostaOperacao.RedeLojas, simulacao.PropostaOperacao.Loja).FirstOrDefault().DataVigencialFinal < DateTime.Now)
         //{
         //   throw new Exception("Rede/Loja fora de Vigência...");
         //}

         //if (PropostaService.GetInstance().ObtemLoja(simulacao.PropostaOperacao.RedeLojas, simulacao.PropostaOperacao.Loja).FirstOrDefault().DataVigencialInicial > DateTime.Now)
         //{
         //   throw new Exception("Rede/Loja fora de Vigência...");
         //}

         //TODO: Precisa Definir se o Parametro estiver ligado de onde vai buscar
         PessoaModel pessoa = null;
         var produto = PropostaService.GetInstance().ObtemProduto(simulacao.Operacao.Produto);

         //TODO: Ajustar
         //try
         //{
         //   //TODO: Verificar se tem que consultar no Barramento
         //   if (produto.BuscaDadosCadastrais)
         //   {
         //      pessoa = new BarramentoService().ConsultarPessoa(Int64.Parse(simulacao.Proponente.CpfCnpj).ToString());
         //   }
         //   else
         //   {
         //      pessoa = null;
         //   }

         //}
         //catch (Exception ep)
         //{
         //   pessoa = null;
         //}

         if (pessoa != null)
         {
            simulacao.Proponente.Nome = pessoa.Nome.Trim().ToUpper();
         }
         else
         {
            simulacao.Proponente.Nome = "";
         }

         if (string.IsNullOrEmpty(simulacao.Proponente.Nome))
         {
            throw new Exception("Nome/Razão Social do Cliente Inválido...");
         }

         if (!UtilityHelper.IsCnpj(Extensions.FormatCPFCNPJ(Int64.Parse(simulacao.Proponente.CpfCnpj))) && !UtilityHelper.IsCpf(Extensions.FormatCPFCNPJ(Int64.Parse(simulacao.Proponente.CpfCnpj))))
         {
            throw new Exception("CPF/CNPJ do Cliente Inválido...");
         }

         if (produto.ExibeBlocoCelularEmail)
         {
            if (!UtilityHelper.IsValidEmail(simulacao.Proponente.Email?.ToLower()))
            {
               throw new Exception("E-mail Inválido...");
            }
         }

         if (!UtilityHelper.IsCpf(simulacao.Proponente.CpfCnpj))
         {
            if (!UtilityHelper.IsCnpj(simulacao.Proponente.CpfCnpj))
            {
               throw new Exception("CPF/CNPJ do Cliente Inválido...");
            }
         }

         //Remove possiveis acentos que estiverem no e-mail.
         if (!string.IsNullOrEmpty(simulacao.Proponente.Email))
            simulacao.Proponente.Email = simulacao.Proponente.Email.RemoveAccents().Trim();

         //Cria a Proposta         
         Pessoas cliente = new Pessoas();

         //TODO: Ajustar
         //if (simulacao.Prospectivo)
         //{
         cliente.Nome = simulacao.Proponente.Nome.Trim().ToUpper();
         cliente.CpfCnpj = simulacao.Proponente.CpfCnpj;
         cliente.TipoPessoa = (UtilityHelper.IsCpf(simulacao.Proponente.CpfCnpj) ? "F" : "J");

         if (produto.ExibeBlocoCelularEmail)
         {
            var celular = simulacao.Celular.Split(' ');

            cliente.DDDCelular = Convert.ToInt32(celular[0].Replace("(", "").Replace(")", ""));
            cliente.Celular = Convert.ToInt32(celular[1].Replace("-", ""));
            cliente.Email = simulacao.Proponente.Email;
         }

         cliente.EspecieBeneficio = simulacao.Proponente.EspecieBeneficio;
         cliente.NumeroBeneficio = ((simulacao.Proponente.NumeroBeneficio?.Trim().Replace(".", "").Replace("-", "").Replace("/", "")).IsNullOrEmpty() ? simulacao.Proponente.NumeroBeneficioSIAPE?.Trim().Replace(".", "").Replace("-", "").Replace("/", "") : simulacao.Proponente.NumeroBeneficio?.Trim().Replace(".", "").Replace("-", "").Replace("/", ""));
         cliente.NumeroBeneficio2 = simulacao.Proponente.NumeroBeneficio2?.Trim().Replace(".", "").Replace("-", "").Replace("/", "");
         cliente.Orgao = simulacao.Proponente.Orgao;
         cliente.UFBeneficio = simulacao.Proponente.UFBeneficio;
         cliente.IfPagadora = simulacao.Proponente.IfPagadora;
         cliente.AgenciaPagadora = simulacao.Proponente.AgenciaPagadora;
         cliente.ContaCorrente = simulacao.Proponente.ContaCorrente;
         cliente.ValorRenda = simulacao.Proponente.ValorRenda;
         cliente.IndicadorAnalfabetismo = simulacao.Proponente.IndicadorAnalfabetismo;
         cliente.PPE = false;

         if (produto.ExibeBlocoDataNascimento)
         {
            cliente.DataNascimento = simulacao.Proponente.DataNascimento;
         }
         else cliente.DataNascimento = new DateTime(2999, 12, 31);
         //TODO: Avaliar
         //}
         //else
         //{
         //   cliente.CidadeResidencial = pessoa.Endereco.Cidade;
         //   cliente.CpfCnpj = pessoa.Inscricao;
         //   cliente.DataConstituicao = pessoa.Nascimento.Data;
         //   cliente.Endereco = pessoa.Endereco.Logradouro + (pessoa.Endereco.Numero > 0 ? ", " + pessoa.Endereco.Numero.ToString() : "") + (pessoa.Endereco.Complemento != null ? " - " + pessoa.Endereco.Complemento : "") + (pessoa.Endereco.Bairro != null ? " - " + pessoa.Endereco.Bairro : "");
         //   cliente.Estado = pessoa.Endereco.Uf;
         //   cliente.Nome = pessoa.Nome.Trim().ToUpper();
         //   cliente.Porte = pessoa.PorteClienteFormatado;
         //   cliente.RamoAtividade = pessoa.CodigoRamoAtividade.ToString();
         //   cliente.Rating = PropostaService.GetInstance().ListarContas(long.Parse(pessoa.Inscricao)).FirstOrDefault()?.RiscoBacen;
         //   cliente.Conta = PropostaService.GetInstance().ListarContas(long.Parse(pessoa.Inscricao)).FirstOrDefault()?.Conta.ToString();
         //   cliente.TipoPessoa = pessoa.TipoPessoa;
         //   cliente.EspecieBeneficio = simulacao.Proponente.EspecieBeneficio;
         //   cliente.NumeroBeneficio = simulacao.Proponente.NumeroBeneficio?.Trim().Replace(".", "").Replace("-", "").Replace("/", "");
         //   cliente.NumeroBeneficio2 = simulacao.Proponente.NumeroBeneficio2?.Trim().Replace(".", "").Replace("-", "").Replace("/", "");
         //   cliente.Orgao = simulacao.Proponente.Orgao;
         //   cliente.UFBeneficio = simulacao.Proponente.UFBeneficio;
         //   cliente.Orgao = simulacao.Proponente.Orgao;
         //   cliente.IfPagadora = simulacao.Proponente.IfPagadora;
         //   cliente.AgenciaPagadora = simulacao.Proponente.AgenciaPagadora;
         //   cliente.ContaCorrente = simulacao.Proponente.ContaCorrente;
         //   cliente.ValorRenda = simulacao.Proponente.ValorRenda;
         //   cliente.IndicadorAnalfabetismo = simulacao.Proponente.IndicadorAnalfabetismo;
         //   cliente.PPE = "N";

         //   if (produto.ExibeBlocoCelularEmail)
         //   {
         //      cliente.Email = simulacao.Proponente.Email?.Replace(" ", "").ToLower();

         //      var celular = simulacao.Celular?.Split(' ');

         //      if (celular != null)
         //      {
         //         cliente.DDDCelular = Convert.ToInt32(celular[0]?.Replace("(", "").Replace(")", ""));
         //         cliente.Celular = Convert.ToInt32(celular[1]?.Replace("-", ""));
         //      }
         //   }

         //}

         int? ocupacaoPadrao = null;

         if (produto.ExibeSelecaoTabelas)
         {
            dynamic parametros = JsonConvert.DeserializeObject(produto.Parametros);

            string empresa = parametros.empresa.ToString();
            string produtoParametro = parametros.produto.ToString();

            simulacao.Operacao.Tabela = (simulacao.Operacao.Tabela != null ? simulacao.Operacao.Tabela : null);
            simulacao.Operacao.RedeLojas = (simulacao.Operacao.RedeLojas != null ? simulacao.Operacao.RedeLojas : null);
            simulacao.Operacao.Loja = (simulacao.Operacao.Loja != null ? simulacao.Operacao.Loja : null);

            if (parametros.NomeEmpresaPadrao != null)
            {
               cliente.Empresa = parametros.NomeEmpresaPadrao;
            }
            else if (simulacao.Proponente.Orgao != null)
            {
               cliente.Empresa = this.ListarOrgaosSIAPE().Where(x => x.Codigo == simulacao.Proponente.Orgao).FirstOrDefault()?.Descricao;
            }

            if (parametros.CargoPadrao != null)
            {
               cliente.Cargo = parametros.CargoPadrao;
            }

            if (parametros.OcupacaoPadrao != null)
            {
               ocupacaoPadrao = parametros.OcupacaoPadrao;
            }

         }

         //TODO: Ajustar
         //if (produto.PermiteBuscarUltimoCadastro)
         //{
         //   var pessoaResgatada = PropostaService.GetInstance().BuscarUltimoCadastro(simulacao.Proponente.CpfCnpj);

         //   if (pessoaResgatada != null)
         //   {
         //      pessoaResgatada.Nome = simulacao.Proponente.Nome.ToUpper();
         //      pessoaResgatada.Email = simulacao.Proponente.Email.ToLower();

         //      var celular = simulacao.Celular.Split(' ');

         //      pessoaResgatada.DDDCelular = Convert.ToInt32(celular[0].Replace("(", "").Replace(")", ""));
         //      pessoaResgatada.Celular = Convert.ToInt32(celular[1].Replace("-", ""));

         //      pessoaResgatada.DataConstituicao = simulacao.Proponente.DataNascimento;

         //      cliente = pessoaResgatada;
         //      cliente.EspecieBeneficio = simulacao.Proponente.EspecieBeneficio;
         //      cliente.NumeroBeneficio = simulacao.Proponente.NumeroBeneficio;
         //      cliente.NumeroBeneficio2 = simulacao.Proponente.NumeroBeneficio2;
         //      cliente.Orgao = simulacao.Proponente.Orgao;
         //      cliente.UFBeneficio = simulacao.Proponente.UFBeneficio;
         //      cliente.IfPagadora = simulacao.Proponente.IfPagadora;
         //      cliente.AgenciaPagadora = simulacao.Proponente.AgenciaPagadora;
         //      cliente.ContaCorrente = simulacao.Proponente.ContaCorrente;
         //      cliente.ValorRenda = simulacao.Proponente.ValorRenda;
         //      cliente.IndicadorAnalfabetismo = simulacao.Proponente.IndicadorAnalfabetismo;
         //   }
         //}

         long? ProfissionalCertificado = null;

         Usuario usuario = UsuarioService.GetInstance().ObterPorLogin(simulacao.Usuario).FirstOrDefault();

         if (produto.ValidaCertificado || produto.ProfissionalCertificadoObrigatorio)
         {
            ProfissionalCertificado = ProfissionaisCertificadosService.GetInstance().ObterCertificados(usuario.CpfCnpj).FirstOrDefault()?.Cpf;

            if (ProfissionalCertificado == null)
            {
               throw new Exception("Usuário sem Certificação Válida");
            }

            if (produto.ValidaCertificado)
            {
               //TODO: Validar o Tipo de Certificado
               //throw new Exception("Usuário sem Certificação Válida");
            }
         }

         PropostaModel proposta = new PropostaModel { Fase = 1, Status = 8, Proponente = cliente, Gerente = new Gerentes { Id = (pessoa != null ? pessoa.CodigoGerente : produto.GerentePadrao) }, DataCriacao = DateTime.Now, Usuario = usuario.Login, Promotora = new Promotoras { Id = simulacao?.Promotora } };


         proposta.ProfissionalCertificado = ProfissionalCertificado;
         proposta.TipoComunicacao = simulacao.TipoComunicacao;
         proposta.TipoFormalizacao = simulacao.TipoFormalizacao;
         proposta.Retencao = simulacao.Retencao;
         proposta.Operacoes = new PropostaOperacao
         {
            Produto = simulacao.Operacao.Produto,
            Tabela = simulacao.Operacao.Tabela,
            RedeLojas = simulacao.Operacao.RedeLojas,
            Loja = simulacao.Operacao.Loja,
            ValorOperacao = simulacao.Operacao.ValorOperacao,
            Prazo = simulacao.Operacao.Prazo,
            IOFFinaciado = simulacao.Operacao.IOFFinaciado,
            TacFinanciada = simulacao.Operacao.TacFinanciada,
            DataEmissao = simulacao.Operacao.DataEmissao,
            DataPrimeiroVencimento = simulacao.Operacao.DataPrimeiroVencimento,
            ValorEntrada = simulacao.Operacao.ValorEntrada,
            CETAno = simulacao.Operacao.CETAno,
            CETMes = simulacao.Operacao.CETMes,
            Taxa = simulacao.Operacao.Taxa,
            TaxaAno = simulacao.Operacao.TaxaAno,
            TaxaMes = simulacao.Operacao.TaxaMes,
            ValorFinanciadoTotal = simulacao.Operacao.ValorFinanciadoTotal,
            ValorIOF = simulacao.Operacao.ValorIOF,
            ValorIOFNormal = simulacao.Operacao.ValorIOFNormal,
            ValorIOFAdicional = simulacao.Operacao.ValorIOFAdicional,
            ValorLiberado = simulacao.Operacao.ValorLiberado,
            ValorParcela = simulacao.Operacao.ValorParcela,
            ValorPST = simulacao.Operacao.ValorPST,
            ValorSeguro = simulacao.Operacao.ValorSeguro,
            ValorTAC = simulacao.Operacao.ValorTAC,
            ValorTFC = simulacao.Operacao.ValorTFC,
            Autorizacao = simulacao.Autorizacao,
            ValorMargem = simulacao.ValorMargem,
            ValorRenegociacaoTotal = simulacao.Operacao.ValorRenegociacaoTotal,
            Simulacao = simulacao.Id,
            MeioLiberacao = 1
         };

         //TODO: Rever essa regra
         if (produto.ExibeBlocoCelularEmail)
         {
            proposta.Gerente.Id = produto.GerentePadrao;

            var celular = simulacao.Celular.Split(' ');

            var DDDCelular = Convert.ToInt32(celular[0].Replace("(", "").Replace(")", ""));
            var Celular = Convert.ToInt32(celular[1].Replace("-", ""));
         }

         foreach (SimulacaoParcelas p in simulacao.Parcelas)
         {
            proposta.Operacoes.Parcelas.Add(new PropostaParcelas { DataVencimento = p.DataVencimento, IofAdicional = p.IofAdicional, IofNormal = p.IofNormal, Parcela = p.Parcela, Principal = p.Principal, Renda = p.Renda, ValorLimite = p.ValorLimite, ValorParcela = p.ValorParcela, ValorRepasse = p.ValorRepasse, ValorTotal = p.ValorTotal, ValorAmortizacaoSemIOF = p.ValorAmortizacaoSemIOF, ValorJuros = p.ValorJuros, ValorJurosAcumulado = p.ValorJurosAcumulado, ValorSaldo = p.ValorSaldo, ValorSaldoRestante = p.ValorSaldoRestante, ValorReforco = p.ValorReforco, TipoParcela = p.TipoParcela, Dias = p.Dias, IOFTotal = p.IOFTotal, DiasIOF = p.DiasIOF, ValorProjetado = p.ValorProjetado });
         }

         //Refin
         if (simulacao.ContratosREFIN.Count() > 0)
         {
            foreach (SimulacaoContratosREFIN ct in simulacao.ContratosREFIN.Where(x => x.Utilizado == true))
            {
               proposta.ContratosREFIN.Add(new PropostaContratosREFIN { Agencia = ct.Agencia, Contrato = ct.Contrato, CpfCnpj = ct.CpfCnpj, DataSaldoDevedor = ct.DataSaldoDevedor, DataSituacao = ct.DataSituacao, DiasAtraso = ct.DiasAtraso, Emissao = ct.Emissao, Empresa = ct.Empresa, IofAtraso = ct.IofAtraso, Matricula = ct.Matricula, MeioRecebimentoBeneficio = ct.MeioRecebimentoBeneficio, ParcelasEmAberto = ct.ParcelasEmAberto, Prazo = ct.Prazo, Principal = ct.Principal, Produto = ct.Produto, SaldoAtual = ct.SaldoAtual, SaldoDevedor = ct.SaldoDevedor, SaldoPrincipalEmAberto = ct.SaldoPrincipalEmAberto, Seguro = ct.Seguro, Tac = ct.Tac, TaxaAnual = ct.TaxaAnual, TaxaMensal = ct.TaxaMensal, TipoBeneficio = ct.TipoBeneficio, Titularidade = ct.Titularidade, UfBeneficio = ct.UfBeneficio, Utilizado = ct.Utilizado, ValorContrato = ct.ValorContrato, ValorParcela = ct.ValorParcela, ValorTotalAPagar = ct.ValorTotalAPagar, Vencimento = ct.Vencimento });
            }
         }

         PropostaService.GetInstance().SalvarProposta(proposta);

         proposta = PropostaService.GetInstance().ObterProposta(proposta.Id);

         try
         {
            PropostaService.GetInstance().SubmeterProposta(proposta);
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogErro(ex, "Erro ao submeter a proposta - Proposta: " + proposta.Id + " - Message: " + ex.Message + " - Stacktrace: " + ex.StackTrace);
            throw new Exception("Erro ao Submeter a Proposta...");
         }

         return proposta;
      }
      #endregion

      #region "Politicas"
      public List<Politicas> ListarPoliticas()
      {
         try
         {
            return new PoliticasBusiness().Listar(null).ToList();
         }
         catch (Exception ex)
         {
            throw new Exception("Erro ao Listar as Politcas", ex);
         }
      }

      public List<PoliticaConfiguracaoExecucao> ListarPoliticasFase(int? Fase, int? Produto, int? status, bool entrada, bool saida)
      {
         try
         {
            Framework.Data.WhereBuilder where = Framework.Data.WhereBuilder.Create().Add(PoliticaConfiguracaoExecucao.METADADO.Fase, Filter.Equal, Fase, Link.And).Add(PoliticaConfiguracaoExecucao.METADADO.Produto, Filter.Equal, Produto, Link.And);
            where.Add(PoliticaConfiguracaoExecucao.METADADO.Entrada, Filter.Equal, entrada, Link.And);
            where.Add(PoliticaConfiguracaoExecucao.METADADO.Saida, Filter.Equal, saida, Link.And);

            return new PoliticaConfiguracaoExecucaoBusiness().Listar(where)?.OrderBy(x => x.Peso)?.ToList();
         }
         catch (Exception ex)
         {
            throw new Exception("Erro ao Listar as Politicas da Fase", ex);
         }
      }

      public List<PoliticaConfiguracaoExecucao> ListarPoliticasProduto(string Produto)
      {
         try
         {
            WhereBuilder where = WhereBuilder.Create().Add(PoliticaConfiguracaoExecucao.METADADO.Produto, Filter.Equal, Produto, Link.And);

            return new PoliticaConfiguracaoExecucaoBusiness().Listar(where)?.OrderBy(x => x.Peso)?.ToList();
         }
         catch (Exception ex)
         {
            throw new Exception("Erro ao Listar as Politcas da Fase", ex);
         }
      }

      public List<PoliticaConfiguracaoExecucaoSimulacao> ListarPoliticasSimulacao(int? Produto, bool entrada, bool saida)
      {
         Framework.Data.WhereBuilder where = Framework.Data.WhereBuilder.Create().Add(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Produto, Filter.Equal, Produto, Link.And);
         where.Add(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Entrada, Filter.Equal, entrada, Link.And);
         where.Add(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Saida, Filter.Equal, saida, Link.And);

         return new PoliticaConfiguracaoExecucaoSimulacaoBusiness().Listar(where).OrderBy(x => x.Peso).ToList();
      }

      public List<PoliticaConfiguracaoExecucaoSimulacao> ListarPoliticasSimulacao(string Produto)
      {
         Framework.Data.WhereBuilder where = Framework.Data.WhereBuilder.Create().Add(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Produto, Filter.Equal, Produto, Link.And);

         return new PoliticaConfiguracaoExecucaoSimulacaoBusiness().Listar(where).OrderBy(x => x.Peso).ToList();
      }

      public void ExecutaPolitica(string politica, PropostaModel proposta, int? fase, string tipoPessoaPolitica)
      {
         Type t = Type.GetType(politica + ", FastConsig.Core.Politicas");
         dynamic o = Activator.CreateInstance(t) as IPolitica;
         o.Execute(proposta, fase, tipoPessoaPolitica);
      }
      public void ExecutaPoliticaSimulacao(string politica, SimulacaoPropostaModel simulacao)
      {
         Type t = Type.GetType(politica + ", FastConsig.Core.Politicas");
         dynamic o = Activator.CreateInstance(t) as IPoliticaSimulacao;
         o.Execute(simulacao);
      }

      public dynamic BuscaParametrosPolitica(string politica)
      {
         var Politica = new PoliticasBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(Politicas.METADADO.Metodo, Filter.Equal, politica)).FirstOrDefault();

         if (!string.IsNullOrEmpty(Politica.ParametrosDefault))
         {
            return JsonConvert.DeserializeObject<dynamic>(Politica.ParametrosDefault);
         }
         else return null;
      }

      public dynamic BuscaParametrosPolitica(string politica, int? produto)
      {
         LogService.GetInstance().GravarLogDebug("Buscando os Parametros para o Produto " + produto + " da politica " + politica);
         var Politica = new PoliticasBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(Politicas.METADADO.Metodo, Filter.Equal, politica)).FirstOrDefault();

         var parametrosPolitica = new PoliticaParametroProdutoBusiness().Listar(Framework.Data.WhereBuilder.Create()
                                                                                .Add(PoliticaParametroProduto.METADADO.Politica, Filter.Equal, Politica.Id, Link.And)
                                                                                .Add(PoliticaParametroProduto.METADADO.Produto, Filter.Equal, produto, Link.And)).FirstOrDefault();

         //Busca os Parametros especificos do produto
         if (parametrosPolitica == null)
         {
            if (!string.IsNullOrEmpty(Politica.ParametrosDefault))
            {
               LogService.GetInstance().GravarLogDebug("Parametros Default da politica " + politica + " encontrados - Produto " + produto, Politica.ParametrosDefault);
               return JsonConvert.DeserializeObject<dynamic>(Politica.ParametrosDefault);
            }
            else
            {
               LogService.GetInstance().GravarLogDebug("A politica " + politica + " não possui parametros");
               return null;
            }
         }
         else
         {
            //Busca os Parametros especificos do produto
            if (!string.IsNullOrEmpty(parametrosPolitica.Parametros))
            {
               LogService.GetInstance().GravarLogDebug("Parametros para o Produto " + produto + " da politica " + politica + " encontrados", parametrosPolitica.Parametros);
               return JsonConvert.DeserializeObject<dynamic>(parametrosPolitica.Parametros);
            }
            else
            {
               //Caso na encontre os parametros especificos do produto, retorna os parametros especificos da politica
               LogService.GetInstance().GravarLogDebug("Buscando os Parametros Default para a politica " + politica + ", pois não existem parametros especificos para o produto " + produto);
               if (!string.IsNullOrEmpty(Politica.ParametrosDefault))
               {
                  LogService.GetInstance().GravarLogDebug("Parametros Default da politica " + politica + " encontrados - Produto " + produto, Politica.ParametrosDefault);
                  return JsonConvert.DeserializeObject<dynamic>(Politica.ParametrosDefault);
               }
               else
               {
                  LogService.GetInstance().GravarLogDebug("A politica " + politica + " não possui parametros");
                  return null;
               }
            }
         }
      }

      #endregion

      #region "Rede de Lojas"
      public RedeLoja ObtemRedeLojas(int? redeLojas)
      {
         return new RedeLojaBusiness().Obtem(redeLojas);
      }

      public List<RedeLoja> ListarRedeLoja()
      {
         return new RedeLojaBusiness().Listar(null);
      }

      public List<RedeLoja> ListarRedeLoja(int promotora)
      {
         return new RedeLojaBusiness().Listar(WhereBuilder.Create().Add(RedeLoja.METADADO.Promotora, Filter.Equal, promotora));

      }
      public List<RedeLoja> ListarRedeLojasPromotora(int? promotora)
      {
         return new RedeLojaBusiness().Listar(WhereBuilder.Create().Add(RedeLoja.METADADO.Promotora, Filter.Equal, promotora));
      }

      public void SalvarRedeLojas(RedeLoja redeLoja)
      {
         if (redeLoja.Id == null || redeLoja.Id == 0)
         {
            new RedeLojaBusiness().Incluir(redeLoja);
         }
         else
         {
            new RedeLojaBusiness().Alterar(redeLoja);
         }
      }

      public void IncluirRedeLojas(RedeLoja redeLoja)
      {
         new RedeLojaBusiness().Incluir(redeLoja);
      }

      public void AlterarRedeLojas(RedeLoja redeLoja)
      {
         new RedeLojaBusiness().Alterar(redeLoja);
      }

      public void ExcluirRedeLojas(int? redeLoja)
      {
         new RedeLojaBusiness().Excluir(redeLoja);
      }
      #endregion

      #region "Loja"
      public List<Lojas> ObtemLoja(int? redeLojas, int? loja)
      {
         return new LojasBusiness().ListarLojasRede(redeLojas, loja);
      }

      public Lojas ObtemLoja(int? loja)
      {
         return new LojasBusiness().Obtem(loja);
      }

      public List<Lojas> ListarLojas()
      {
         return new LojasBusiness().Listar(null);
      }

      public List<Lojas> ListarLojasRede(int? redeLojas)
      {
         return new LojasBusiness().Listar(WhereBuilder.Create().Add(Lojas.METADADO.RedeLoja, Filter.Equal, redeLojas));
      }

      public void SalvarLoja(Lojas loja)
      {
         if (loja.Id == null || loja.Id == 0)
         {
            new LojasBusiness().Incluir(loja);
         }
         else
         {
            new LojasBusiness().Alterar(loja);
         }
      }

      public void IncluirLoja(Lojas loja)
      {
         new LojasBusiness().Incluir(loja);
      }

      public void AlterarLoja(Lojas loja)
      {
         new LojasBusiness().Alterar(loja);
      }

      public void ExcluirLoja(int? loja)
      {
         new LojasBusiness().Excluir(loja);
      }
      #endregion

      #region Ocorrências
      public List<Ocorrencias> ListarOcorrencias()
      {
         return new OcorrenciasBusiness().Listar(null);
      }
      public List<PropostaOcorrencias> ListarOcorrencias(long? proposta)
      {
         return new PropostaOcorrenciasBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(PropostaOcorrencias.METADADO.Proposta, Filter.Equal, proposta)).OrderByDescending(x => x.DataOcorrencia).ToList();
      }

      public List<OcorrenciaProdutoFase> ListarOcorrenciasProdutoXFase(int? produto, int? fase)
      {
         return new OcorrenciaProdutoFaseBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(OcorrenciaProdutoFase.METADADO.Produto, Filter.Equal, produto, Link.And).Add(OcorrenciaProdutoFase.METADADO.Fase, Filter.Equal, fase, Link.And));
      }

      public List<OcorrenciaProdutoFase> ListarOcorrenciasProdutoXFase(int? produto)
      {
         return new OcorrenciaProdutoFaseBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(OcorrenciaProdutoFase.METADADO.Produto, Filter.Equal, produto, Link.And));
      }

      public List<OcorrenciaProdutoFase> ListarOcorrenciasProdutoXOcorrencia(int? produto, int? fase, int? ocorrencia)
      {
         return new OcorrenciaProdutoFaseBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(OcorrenciaProdutoFase.METADADO.Produto, Filter.Equal, produto, Link.And).Add(OcorrenciaProdutoFase.METADADO.Fase, Filter.Equal, fase, Link.And).Add(OcorrenciaProdutoFase.METADADO.Ocorrencia, Filter.Equal, ocorrencia, Link.And));
      }

      public void InsereOcorrencia(int? Proposta, int? Ocorrencia, string Complemento, string Restritiva, string usuario)
      {
         PropostaOcorrencias ocorrencia = new PropostaOcorrencias { Proposta = Proposta, Ocorrencia = Ocorrencia, DataOcorrencia = DateTime.Now, Complemento = Complemento, Restritiva = Restritiva, Usuario = usuario };
         new PropostaOcorrenciasBusiness().Incluir(ocorrencia);
      }
      public void InsereOcorrencia(int? Proposta, int? Ocorrencia, string Complemento, string Restritiva, string usuario, int? pessoa)
      {
         PropostaOcorrencias ocorrencia = new PropostaOcorrencias { Proposta = Proposta, Ocorrencia = Ocorrencia, DataOcorrencia = DateTime.Now, Complemento = Complemento, Restritiva = Restritiva, Usuario = usuario, Pessoa = pessoa };
         new PropostaOcorrenciasBusiness().Incluir(ocorrencia);
      }
      public void InsereOcorrencia(PropostaOcorrencias ocorrencia)
      {
         new PropostaOcorrenciasBusiness().Incluir(ocorrencia);
      }
      public void SalvaOcorrencia(PropostaOcorrencias ocorrencia)
      {
         if (ocorrencia.Id == null)
         {
            new PropostaOcorrenciasBusiness().Incluir(ocorrencia);
         }
         else
         {
            new PropostaOcorrenciasBusiness().Alterar(ocorrencia);
         }
      }
      public Ocorrencias ObterOcorrencia(int? id)
      {
         return new OcorrenciasBusiness().Obtem(id);
      }

      public Ocorrencias ObtemOcorrencia(int? id)
      {
         return new OcorrenciasBusiness().Obtem(id);
      }

      public void AlterarOcorrencia(Ocorrencias obj)
      {
         new OcorrenciasBusiness().Alterar(obj);
      }

      public void IncluirOcorrencia(Ocorrencias obj)
      {
         new OcorrenciasBusiness().Incluir(obj);
      }

      public void ExcluirOcorrencia(Ocorrencias obj)
      {
         new OcorrenciasBusiness().Excluir(obj.Id);
      }

      public void ExcluirOcorrencia(int? id)
      {
         new OcorrenciasBusiness().Excluir(id);
      }

      public void SalvarOcorrencia(Ocorrencias obj)
      {
         if (obj.Id == null || obj.Id == 0)
         {
            new OcorrenciasBusiness().Incluir(obj);
         }
         else
         {
            new OcorrenciasBusiness().Alterar(obj);
         }
      }

      public PropostaOcorrencias ObtemOcorrenciaProposta(int? id)
      {
         return new PropostaOcorrenciasBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(PropostaOcorrencias.METADADO.Id, Filter.Equal, id)).FirstOrDefault();
      }

      public List<PropostaOcorrencias> ListarOcorrenciasProposta(int? proposta)
      {
         return new PropostaOcorrenciasBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(PropostaOcorrencias.METADADO.Proposta, Filter.Equal, proposta)).OrderByDescending(x => x.DataOcorrencia).ToList();
      }
      public PropostaOcorrencias ObtemOcorrencia(long? Proposta, int? Ocorrencia)
      {
         return new PropostaOcorrenciasBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(PropostaOcorrencias.METADADO.Proposta, Filter.Equal, Proposta).Add(PropostaOcorrencias.METADADO.Ocorrencia, Filter.Equal, Ocorrencia)).FirstOrDefault();
      }
      public PropostaOcorrencias ObtemOcorrencia(long? Proposta, int? Ocorrencia, int? Pessoa)
      {
         return new PropostaOcorrenciasBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(PropostaOcorrencias.METADADO.Proposta, Filter.Equal, Proposta).Add(PropostaOcorrencias.METADADO.Ocorrencia, Filter.Equal, Ocorrencia).Add(PropostaOcorrencias.METADADO.Pessoa, Filter.Equal, Pessoa)).FirstOrDefault();
      }
      public List<PropostaOcorrencias> ObtemOcorrencias(long? Proposta, int? Ocorrencia)
      {
         return new PropostaOcorrenciasBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(PropostaOcorrencias.METADADO.Proposta, Filter.Equal, Proposta).Add(PropostaOcorrencias.METADADO.Ocorrencia, Filter.Equal, Ocorrencia));
      }
      public List<PropostaOcorrencias> ObtemOcorrencias(long? Proposta, int? Ocorrencia, int? Pessoa)
      {
         return new PropostaOcorrenciasBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(PropostaOcorrencias.METADADO.Proposta, Filter.Equal, Proposta).Add(PropostaOcorrencias.METADADO.Ocorrencia, Filter.Equal, Ocorrencia).Add(PropostaOcorrencias.METADADO.Pessoa, Filter.Equal, Pessoa));
      }

      public void LiberarOcorrencia(long? Proposta, int? Ocorrencia, string Usuario, string Complemento)
      {
         PropostaOcorrencias ocorrencia = PropostaService.GetInstance().ObtemOcorrencia(Proposta, Ocorrencia);
         ocorrencia.DataHoraLiberacao = DateTime.Now;
         ocorrencia.Liberada = true;
         ocorrencia.UsuarioLiberador = Usuario;
         ocorrencia.Motivo = Complemento;
         PropostaService.GetInstance().SalvaOcorrencia(ocorrencia);
      }

      public void LiberarOcorrencia(long? Proposta, int? Ocorrencia, string Usuario, string Complemento, int? Pessoa)
      {
         PropostaOcorrencias ocorrencia = PropostaService.GetInstance().ObtemOcorrencia(Proposta, Ocorrencia, Pessoa);
         ocorrencia.DataHoraLiberacao = DateTime.Now;
         ocorrencia.Liberada = true;
         ocorrencia.UsuarioLiberador = Usuario;
         ocorrencia.Motivo = Complemento;
         PropostaService.GetInstance().SalvaOcorrencia(ocorrencia);
      }

      public void LiberarOcorrencias(long? Proposta, int? Ocorrencia, string Usuario, string Complemento, bool complemento = false)
      {
         List<PropostaOcorrencias> ocorrencias = PropostaService.GetInstance().ObtemOcorrencias(Proposta, Ocorrencia);

         foreach (PropostaOcorrencias ocorrencia in ocorrencias)
         {
            if (ocorrencia.Restritiva == "S" && !ocorrencia.Liberada)
            {
               ocorrencia.DataHoraLiberacao = DateTime.Now;
               ocorrencia.Liberada = true;
               ocorrencia.UsuarioLiberador = Usuario;
               ocorrencia.Motivo = Complemento;

               if (complemento)
                  ocorrencia.Complemento = String.Concat(ocorrencia.Complemento, " ", Complemento);

               PropostaService.GetInstance().SalvaOcorrencia(ocorrencia);
            }
         }
      }

      public void LiberarOcorrencias(long? Proposta, int? Ocorrencia, string Usuario, string Complemento, int? Pessoa, bool complemento = false)
      {
         List<PropostaOcorrencias> ocorrencias = PropostaService.GetInstance().ObtemOcorrencias(Proposta, Ocorrencia, Pessoa);

         foreach (PropostaOcorrencias ocorrencia in ocorrencias)
         {
            if (ocorrencia.Restritiva == "S" && !ocorrencia.Liberada)
            {
               ocorrencia.DataHoraLiberacao = DateTime.Now;
               ocorrencia.Liberada = true;
               ocorrencia.UsuarioLiberador = Usuario;
               ocorrencia.Motivo = Complemento;

               if (complemento)
                  ocorrencia.Complemento = String.Concat(ocorrencia.Complemento, " ", Complemento);

               PropostaService.GetInstance().SalvaOcorrencia(ocorrencia);
            }
         }
      }

      public int? QtdOcorrenciasRestritivas(int? Proposta)
      {
         return this.ListarOcorrenciasProposta(Proposta).Where(x => x.Restritiva == "S").Where(x => x.Liberada == false).Count();
      }

      public List<OcorrenciasConsignadoAcao> ListarOcorrenciasConsignadoAcao()
      {
         return new OcorrenciasConsignadoAcaoBusiness().Listar(null);
      }
      #endregion

      #region Ocorrências INSS
      public List<OcorrenciasINSS> ListarOcorrenciasINSS()
      {
         return new OcorrenciasINSSBusiness().Listar(null);
      }

      public OcorrenciasINSS ObterOcorrenciaINSS(int? id)
      {
         return new OcorrenciasINSSBusiness().Obtem(id);
      }

      public OcorrenciasINSS ObtemOcorrenciaINSS(int? id)
      {
         return new OcorrenciasINSSBusiness().Obtem(id);
      }

      public void AlterarOcorrenciaINSS(OcorrenciasINSS obj)
      {
         new OcorrenciasINSSBusiness().Alterar(obj);
      }

      public void IncluirOcorrenciaINSS(OcorrenciasINSS obj)
      {
         new OcorrenciasINSSBusiness().Incluir(obj);
      }

      public void ExcluirOcorrenciaINSS(OcorrenciasINSS obj)
      {
         new OcorrenciasINSSBusiness().Excluir(obj.Id);
      }

      public void ExcluirOcorrenciaINSS(int? id)
      {
         new OcorrenciasINSSBusiness().Excluir(id);
      }

      public void SalvarOcorrenciaINSS(OcorrenciasINSS obj)
      {
         if (obj.Id == null || obj.Id == 0)
         {
            new OcorrenciasINSSBusiness().Incluir(obj);
         }
         else
         {
            new OcorrenciasINSSBusiness().Alterar(obj);
         }
      }
      #endregion

      #region Ocorrências SIAPE
      public List<OcorrenciasSIAPE> ListarOcorrenciasSIAPE()
      {
         return new OcorrenciasSIAPEBusiness().Listar(null);
      }

      public OcorrenciasSIAPE ObterOcorrenciaSIAPE(int? id)
      {
         return new OcorrenciasSIAPEBusiness().Obtem(id);
      }

      public OcorrenciasSIAPE ObtemOcorrenciaSIAPE(int? id)
      {
         return new OcorrenciasSIAPEBusiness().Obtem(id);
      }

      public void AlterarOcorrenciaSIAPE(OcorrenciasSIAPE obj)
      {
         new OcorrenciasSIAPEBusiness().Alterar(obj);
      }

      public void IncluirOcorrenciaSIAPE(OcorrenciasSIAPE obj)
      {
         new OcorrenciasSIAPEBusiness().Incluir(obj);
      }

      public void ExcluirOcorrenciaSIAPE(OcorrenciasSIAPE obj)
      {
         new OcorrenciasSIAPEBusiness().Excluir(obj.Id);
      }

      public void ExcluirOcorrenciaSIAPE(int? id)
      {
         new OcorrenciasSIAPEBusiness().Excluir(id);
      }

      public void SalvarOcorrenciaSIAPE(OcorrenciasSIAPE obj)
      {
         if (obj.Id == null || obj.Id == 0)
         {
            new OcorrenciasSIAPEBusiness().Incluir(obj);
         }
         else
         {
            new OcorrenciasSIAPEBusiness().Alterar(obj);
         }
      }
      #endregion

      #region Arquivos
      public void SalvarArquivo(PropostaArquivos arquivo) => new PropostaArquivosBusiness().Incluir(arquivo);

      public void ApagarArquivo(int? id) => new PropostaArquivosBusiness().Excluir(id);

      public byte[] ObterDocumento(long idProposta, int tipoDocumento)
      {
         var config = new ConfiguracaoRequestModel
         {
            Url = ConfiguracaoService.GetInstance().Config<string>("fastConsig.url")
         };

         //Create obj request
         var execute = new ExecuteRequest(config.Url, config.Token, "Proposta/ObterDocumento", true);

         //create parameters
         var parameters = new Dictionary<string, string> { { "proposta", idProposta.ToString() }, { "tipoDocumento", tipoDocumento.ToString() } };

         //execute request produtos
         var response = execute.Request(string.Empty, parameters);

         //Status: 200 - Execução com sucesso.
         if (response.StatusCode == System.Net.HttpStatusCode.OK)
         {
            var result = JsonConvert.DeserializeObject<byte[]>(response.Content);
            return result; //convert obj to movimento model.
         }

         if (response.StatusCode == System.Net.HttpStatusCode.Forbidden) //Status: 403 - Token inválido.
            throw new Exception(string.Format("Token inválido ({0} - {1})", response.StatusCode, response.StatusDescription));
         else if (response.ErrorException != null) //Erro generico
            throw response.ErrorException;
         else
            throw new Exception(string.Format("{0} - {1}", response.StatusCode, response.StatusDescription));
      }

      public PropostaArquivos ObtemArquivoProposta(int? id)
      {
         return new PropostaArquivosBusiness().Obtem(id);
      }

      #endregion

      #region "Consultas"
      public List<PropostaConsultas> ListarConsultas(long? Pessoa)
      {
         return new PropostaConsultasBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(PropostaConsultas.METADADO.Pessoa, Filter.Equal, Pessoa));
      }

      public void RegistraConsulta(int? Pessoa, int? Proposta, int? Id, string Consulta)
      {
         var consulta = new PropostaConsultas();
         consulta.Pessoa = Pessoa;
         consulta.Proposta = Proposta;
         consulta.IdConsulta = Id;
         consulta.Consulta = Consulta;

         new PropostaConsultasBusiness().Incluir(consulta);
      }

      public List<PropostaConsultas> ListarConsultas(long? Pessoa, long? Proposta, string Consulta)
      {
         return new PropostaConsultasBusiness().Listar(Framework.Data.WhereBuilder.Create()
            .Add(PropostaConsultas.METADADO.Pessoa, Filter.Equal, Pessoa, Link.And)
            .Add(PropostaConsultas.METADADO.Proposta, Filter.Equal, Proposta, Link.And)
            .Add(PropostaConsultas.METADADO.Consulta, Filter.Equal, Consulta, Link.And)
            );
      }
      #endregion

      #region "Fases"
      public int? BuscaProximaFase(int? produto, int? faseAtual)
      {
         //busca a sequencia da fase atual
         var sequencia = new FasesProdutoBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(FasesProduto.METADADO.Produto, Filter.Equal, produto, Link.And).Add(FasesProduto.METADADO.Fase, Filter.Equal, faseAtual, Link.And)).FirstOrDefault().Ordem;

         //Busca a Próxima Fase
         var novaFase = new FasesProdutoBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(FasesProduto.METADADO.Produto, Filter.Equal, produto, Link.And).Add(FasesProduto.METADADO.Ordem, Filter.GreatherThan, sequencia, Link.And)).OrderBy(x => x.Ordem).FirstOrDefault();

         if (novaFase == null)
         {
            throw new Exception("Sem Fases do Processo a Seguir");
         }

         return novaFase.Fase;
      }

      public int? BuscaFaseAnterior(int produto, int? faseAtual)
      {
         //busca a sequencia da fase atual
         var sequencia = new FasesProdutoBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(FasesProduto.METADADO.Produto, Filter.Equal, produto, Link.And).Add(FasesProduto.METADADO.Fase, Filter.Equal, faseAtual, Link.And)).FirstOrDefault().Ordem;

         //Busca a Fase Anterior
         var novaFase = new FasesProdutoBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(FasesProduto.METADADO.Produto, Filter.Equal, produto, Link.And).Add(FasesProduto.METADADO.Ordem, Filter.LessThan, sequencia, Link.And)).OrderByDescending(x => x.Ordem).FirstOrDefault();


         return novaFase.Fase;
      }

      public Fases ObtemFase(int fase)
      {
         return new FasesBusiness().Obtem(fase);
      }
      public void ExcluirFase(int? fase)
      {
         new FasesBusiness().Excluir(fase);
      }

      public void SalvarFase(Fases fase)
      {
         if (fase.Id == null || fase.Id == 0)
         {
            new FasesBusiness().Incluir(fase);
         }
         else
         {
            new FasesBusiness().Alterar(fase);
         }
      }

      public Fases ObtemFase(int? fase)
      {
         return new FasesBusiness().Obtem(fase);
      }

      public List<Fases> ListarFases()
      {
         return new FasesBusiness().Listar(null);
      }

      public List<FasesProduto> ListarFasesProduto(string produto)
      {
         return new FasesProdutoBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(FasesProduto.METADADO.Produto, Filter.Equal, produto, Link.And)).OrderBy(x => x.Ordem).ToList();
      }
      #endregion

      #region Status
      public List<Status> ListarStatus()
      {
         return new StatusBusiness().Listar(null);
      }

      public Status ObtemStatus(int? status)
      {
         return new StatusBusiness().Obtem(status);
      }
      public void ExcluirStatus(int? status)
      {
         new StatusBusiness().Excluir(status);
      }

      public void SalvarStatus(Status status)
      {
         if (status.Id == null || status.Id == 0)
         {
            new StatusBusiness().Incluir(status);
         }
         else
         {
            new StatusBusiness().Alterar(status);
         }
      }

      #endregion

      #region Promotoras
      public List<Promotoras> ListarPromotoras()
      {
         return new PromotorasBusiness().Listar(null).OrderBy(p => p.Nome).ToList();
      }
      public Promotoras ObtemPromotora(int? promotora)
      {
         return new PromotorasBusiness().Obtem(promotora);
      }

      public Promotoras BuscarPromotora(string cnpj)
      {
         return new PromotorasBusiness().Listar(WhereBuilder.Create().Add(Promotoras.METADADO.Cnpj, Filter.Equal, cnpj)).FirstOrDefault(); ;
      }

      public void AlterarPromotora(Promotoras promotora)
      {
         new PromotorasBusiness().Alterar(promotora);
      }

      public void IncluirPromotora(Promotoras promotora)
      {
         new PromotorasBusiness().Incluir(promotora);
      }
      public void SalvarPromotora(Promotoras promotora)
      {
         if (promotora.Id == null || promotora.Id == 0)
         {
            new PromotorasBusiness().Incluir(promotora);
         }
         else
         {
            new PromotorasBusiness().Alterar(promotora);
         }
      }

      public void ExcluirPromotora(int? promotora)
      {
         new PromotorasBusiness().Excluir(promotora);
      }
      #endregion

      #region "Produto"
      public List<Produtos> ListarProdutos()
      {
         return new ProdutosBusiness().Listar(null).OrderBy(p => p.Nome).ToList();
      }
      public Produtos ObtemProduto(int? id)
      {
         return new ProdutosBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(Produtos.METADADO.Id, Filter.Equal, id)).FirstOrDefault();
      }
      public string BuscarPaginaPadrao(int? produto)
      {
         return new ProdutosBusiness().Obtem(produto).PaginaPadrao;
      }
      public ProdutoModel ObterProduto(int id)
      {
         ProdutoModel produto = new ProdutoModel();

         //TODO: Avaliar
         produto.Produto = ObtemProduto(id);
         //produto.Fases = ListarFasesProduto(id);
         //produto.OcorrenciaFase = ListarOcorrenciasProdutoXFase(id);
         //produto.PoliticaConfiguracaoExecucao = ListarPoliticasProduto(id);
         //produto.PoliticaConfiguracaoExecucaoSimulacao = ListarPoliticasSimulacao(id);

         return produto;
      }
      #endregion

      #region Gerente
      public List<Gerentes> ListarGerente()
      {
         return new GerentesBusiness().Listar(null).OrderBy(x => x.Nome).ToList();
      }
      public Gerentes ObtemGerente(int? CodigoGerente)
      {
         return new GerentesBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(Gerentes.METADADO.Id, Filter.Equal, CodigoGerente)).OrderBy(x => x.Nome).FirstOrDefault();
      }
      public int? ObterGerente(long? CpfCnpj)
      {
         return new GerentesBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(Gerentes.METADADO.Cpf, Filter.Equal, CpfCnpj)).FirstOrDefault()?.Id;
      }

      public void SalvarGerente(Gerentes gerente)
      {
         if (gerente.Id == null || gerente.Id == 0)
         {
            new GerentesBusiness().Incluir(gerente);
         }
         else
         {
            new GerentesBusiness().Alterar(gerente);
         }
      }

      public void AlterarGerente(Gerentes gerente)
      {
         new GerentesBusiness().Alterar(gerente);
      }

      public void IncluirGerente(Gerentes gerente)
      {
         new GerentesBusiness().Incluir(gerente);
      }

      public void ExcluirGerente(int? gerente)
      {
         new GerentesBusiness().Excluir(gerente);
      }
      #endregion

      #region "Tipo de Comunicação"
      public List<TipoComunicacao> ListarTipoComunicacao()
      {
         return new TipoComunicacaoBusiness().Listar(null);
      }

      public List<TipoComunicacaoModel> ListarTipoComunicacao(bool model)
      {
         var lista = new TipoComunicacaoBusiness().Listar(null);

         List<TipoComunicacaoModel> retorno = new List<TipoComunicacaoModel>();

         foreach (var l in lista)
         {
            retorno.Add(new TipoComunicacaoModel { Id = l.Id, Descricao = l.Descricao, EMail = l.EMail, Fisico = l.Fisico, SMS = l.SMS, Whatsapp = l.Whatsapp });
         }

         return retorno;
      }

      public List<TipoComunicacao> ListarTipoComunicacao(Framework.Data.WhereBuilder filtro)
      {
         return new TipoComunicacaoBusiness().Listar(filtro);
      }

      public TipoComunicacao ObtemTipoComunicacao(int? id)
      {
         return new TipoComunicacaoBusiness().Obtem(id);
      }

      public void IncluirTipoComunicacao(TipoComunicacao obj)
      {
         new TipoComunicacaoBusiness().Incluir(obj);
      }
      public void AlterarTipoComunicacao(TipoComunicacao obj)
      {
         new TipoComunicacaoBusiness().Alterar(obj);
      }
      public void ExcluirTipoComunicacao(TipoComunicacao obj)
      {
         new TipoComunicacaoBusiness().Excluir(obj.Id);
      }
      public void ExcluirTipoComunicacao(int? id)
      {
         new TipoComunicacaoBusiness().Excluir(id);
      }
      #endregion

      #region "Tipo de Documento"
      public List<TipoDocumento> ListarTiposDocumentoSelecionaveis()
      {
         return new TipoDocumentoBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(TipoDocumento.METADADO.Selecionavel, Filter.Equal, true)).OrderBy(x => x.Descricao).ToList();
      }
      public List<TipoDocumento> ListarTiposDocumento()
      {
         return new TipoDocumentoBusiness().Listar(null).OrderBy(x => x.Descricao).ToList();
      }
      public TipoDocumento ObtemTiposDocumento(int? id)
      {
         return new TipoDocumentoBusiness().Obtem(id);
      }
      public void SalvarTiposDocumento(TipoDocumento tipoDocumento)
      {
         if (tipoDocumento.Id == null || tipoDocumento.Id == 0)
         {
            new TipoDocumentoBusiness().Incluir(tipoDocumento);
         }
         else
         {
            new TipoDocumentoBusiness().Alterar(tipoDocumento);
         }
      }
      public void ExcluirTiposDocumento(int? id)
      {
         new TipoDocumentoBusiness().Excluir(id);
      }
      #endregion

      #region "Orgãos SIAPE"
      public List<OrgaoSIAPE> ListarOrgaosSIAPE()
      {
         return new OrgaoSIAPEBusiness().Listar(null);
      }
      #endregion

      #region Tipos de Beneficio INSS
      public List<TipoBeneficioINSS> ListarTiposBeneficioINSS(bool aceitoPolitica = true)
      {
         return new TipoBeneficioINSSBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(TipoBeneficioINSS.METADADO.Aceito, Filter.Equal, aceitoPolitica));
      }

      public List<TipoBeneficioINSS> ListarTipoBeneficioINSS()
      {
         return new TipoBeneficioINSSBusiness().Listar(null);
      }

      public TipoBeneficioINSS ObterTipoBeneficioINSS(int? id)
      {
         return new TipoBeneficioINSSBusiness().Obtem(id);
      }

      public TipoBeneficioINSS ObtemTipoBeneficioINSS(int? id)
      {
         return new TipoBeneficioINSSBusiness().Obtem(id);
      }

      public void IncluirTipoBeneficioINSS(TipoBeneficioINSS obj)
      {
         new TipoBeneficioINSSBusiness().Incluir(obj);
      }

      public void AlterarTipoBeneficioINSS(TipoBeneficioINSS obj)
      {
         new TipoBeneficioINSSBusiness().Alterar(obj);
      }

      public void ExcluirTipoBeneficioINSS(TipoBeneficioINSS obj)
      {
         new TipoBeneficioINSSBusiness().Excluir(obj.Id);
      }

      public void ExcluirTipoBeneficioINSS(int? id)
      {
         new TipoBeneficioINSSBusiness().Excluir(id);
      }

      public void SalvarTipoBeneficioINSS(TipoBeneficioINSS obj)
      {
         if (obj.Id == null || obj.Id == 0)
         {
            new TipoBeneficioINSSBusiness().Incluir(obj);
         }
         else
         {
            new TipoBeneficioINSSBusiness().Alterar(obj);
         }
      }
      #endregion

      #region "Motivo de Bloqueio"
      public List<MotivoBloqueio> ListarMotivosBloqueio()
      {
         return new MotivoBloqueioBusiness().Listar(null);
      }
      public MotivoBloqueio ObtemMotivoBloqueio(int? id)
      {
         return new MotivoBloqueioBusiness().Obtem(id);
      }

      public void IncluirMotivoBloqueio(MotivoBloqueio obj)
      {
         new MotivoBloqueioBusiness().Incluir(obj);
      }

      public void AlterarMotivoBloqueio(MotivoBloqueio obj)
      {
         new MotivoBloqueioBusiness().Alterar(obj);
      }

      public void ExcluirMotivoBloqueio(int? id)
      {
         new MotivoBloqueioBusiness().Excluir(id);
      }

      public void SalvarMotivoBloqueio(MotivoBloqueio motivoBloqueio)
      {
         if (motivoBloqueio.Id == null || motivoBloqueio.Id == 0)
         {
            new MotivoBloqueioBusiness().Incluir(motivoBloqueio);
         }
         else
         {
            new MotivoBloqueioBusiness().Alterar(motivoBloqueio);
         }
      }
      #endregion

      #region "Estado Civil"
      public List<EstadoCivil> ListarEstadoCivil()
      {
         return new EstadoCivilBusiness().Listar(null).OrderBy(p => p.Descricao).ToList();
      }
      public EstadoCivil BuscarEstadoCivil(int? Id)
      {
         return new EstadoCivilBusiness().Obtem(Id);
      }
      public EstadoCivil BuscarEstadoCivil(string codigoSicred)
      {
         return new EstadoCivilBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(EstadoCivil.METADADO.CodigoIntegracaoSicred, Filter.Equal, codigoSicred)).FirstOrDefault();
      }
      #endregion

      #region "Tipo Documento de Identidade"
      public List<TipoDocumentoIdentidade> ListarTipoDocumentoIdentidade()
      {
         return new TipoDocumentoIdentidadeBusiness().Listar(null).OrderBy(p => p.Descricao).ToList();
      }
      public TipoDocumentoIdentidade BuscarTipoDocumentoIdentidade(int? Id)
      {
         return new TipoDocumentoIdentidadeBusiness().Obtem(Id);
      }
      public TipoDocumentoIdentidade BuscarTipoDocumentoIdentidade(string codigoSicred)
      {
         return new TipoDocumentoIdentidadeBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(TipoDocumentoIdentidade.METADADO.CodigoIntegracaoSicred, Filter.Equal, codigoSicred)).FirstOrDefault();
      }
      #endregion

      #region "Órgão Emissor"
      public List<OrgaoEmissor> ListarOrgaoEmissor()
      {
         return new OrgaoEmissorBusiness().Listar(null).OrderBy(p => p.Descricao).ToList();
      }
      public OrgaoEmissor BuscarOrgaoEmissor(int? Id)
      {
         return new OrgaoEmissorBusiness().Obtem(Id);
      }
      public OrgaoEmissor BuscarOrgaoEmissor(string codigoSicred)
      {
         return new OrgaoEmissorBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(OrgaoEmissor.METADADO.CodigoIntegracaoSicred, Filter.Equal, codigoSicred)).FirstOrDefault();
      }
      public OrgaoEmissor BuscarOrgaoEmissorDescricao(string descricao)
      {
         return new OrgaoEmissorBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(OrgaoEmissor.METADADO.Descricao, Filter.Equal, descricao)).FirstOrDefault();
      }
      #endregion

      #region "Nacionalidades"
      public List<Nacionalidade> ListarNacionalidades()
      {
         return new NacionalidadeBusiness().Listar(null).OrderBy(p => p.Descricao).ToList();
      }
      public Nacionalidade BuscarNacionalidade(int? Id)
      {
         return new NacionalidadeBusiness().Obtem(Id);
      }
      public Nacionalidade BuscarNacionalidade(string codigoSicred)
      {
         return new NacionalidadeBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(Nacionalidade.METADADO.CodigoIntegracaoSicred, Filter.Equal, codigoSicred)).FirstOrDefault();
      }
      #endregion

      #region CheckList
      public List<CheckList> ListarCheckList()
      {
         return new CheckListBusiness().Listar(null).OrderBy(x => x.Descricao).ToList();
      }

      public CheckList ObtemCheckList(int id)
      {
         return new CheckListBusiness().Obtem(id);
      }

      public void SalvarCheckList(CheckList checklist)
      {
         if (checklist.Id == null || checklist.Id == 0)
         {
            new CheckListBusiness().Incluir(checklist);
         }
         else
         {
            new CheckListBusiness().Alterar(checklist);
         }
      }

      public void ExcluirCheckList(CheckList checklist)
      {
         if (checklist.Id >= 0)
         {
            new CheckListBusiness().Excluir(checklist.Id);
         }
         else
         {
            throw new Exception("Falha na Deleação do Item");
         }
      }

      public List<CheckListItens> ObtemItensCheckList(int? checklist)
      {
         return new CheckListItensBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(CheckListItens.METADADO.CheckList, Filter.Equal, checklist)).OrderBy(x => x.Descricao).ToList();
      }

      public void InserirItemCheckListProposta(PropostaChecklist item)
      {
         new PropostaChecklistBusiness().Incluir(item);
      }

      public List<ViewPropostaCheckList> ListarItensCheckListProposta(long? proposta)
      {
         return new ViewPropostaCheckListBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(ViewPropostaCheckList.METADADO.Proposta, Filter.Equal, proposta));
      }
      #endregion

      #region BlackList
      //TODO: Avaliar
      //public List<ClientesBlacklist> ObtemDadosBlackList(long? cpfcnpj)
      //{
      //   return new ClientesBlacklistBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(ClientesBlacklist.METADADO.CpfCnpj, Filter.Equal, cpfcnpj, Link.And).Add(ClientesBlacklist.METADADO.Ativo, Filter.Equal, true, Link.And));
      //}
      //public List<ClientesBlacklist> ListarBlackList()
      //{
      //   return new ClientesBlacklistBusiness().Listar(null);
      //}
      //public ClientesBlacklist ObtemBlackList(int? id)
      //{
      //   return new ClientesBlacklistBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(ClientesBlacklist.METADADO.Id, Filter.Equal, id, Link.And)).FirstOrDefault();
      //}
      //public void InserirBlackList(ClientesBlacklist obj)
      //{
      //   new ClientesBlacklistBusiness().Incluir(obj);
      //}
      //public void AlterarBlackList(ClientesBlacklist obj)
      //{
      //   new ClientesBlacklistBusiness().Alterar(obj);
      //}
      //public void ExcluirBlackList(ClientesBlacklist obj)
      //{
      //   new ClientesBlacklistBusiness().Excluir(obj.Id);
      //}
      //public void ExcluirBlackList(int? id)
      //{
      //   new ClientesBlacklistBusiness().Excluir(id);
      //}
      #endregion

      #region "Genéricos: (Sim/Não) / Sexo / Estados / Meio Liberação / Tipo de Compromisso"
      public List<ComboValueModel> ListarSimNao()
      {
         var retorno = new List<ComboValueModel>();
         retorno.Add(new ComboValueModel { Id = "S", Descricao = "SIM" });
         retorno.Add(new ComboValueModel { Id = "N", Descricao = "NÃO" });

         return retorno;
      }
      public List<ComboValueBoleanoModel> ListarSimNaoBoleano()
      {
         var retorno = new List<ComboValueBoleanoModel>();
         retorno.Add(new ComboValueBoleanoModel { Id = true, Descricao = "SIM" });
         retorno.Add(new ComboValueBoleanoModel { Id = false, Descricao = "NÃO" });

         return retorno;
      }
      public List<ComboValueModel> ListarSexo()
      {
         var retorno = new List<ComboValueModel>();
         retorno.Add(new ComboValueModel { Id = "M", Descricao = "MASCULINO" });
         retorno.Add(new ComboValueModel { Id = "F", Descricao = "FEMININO" });

         return retorno;
      }
      public List<Estados> ListarEstados()
      {
         return new EstadosBusiness().Listar(null).OrderBy(x => x.Nome).ToList();
      }
      public List<MeioLiberacao> ListarMeiosdeLiberacao()
      {
         return new MeioLiberacaoBusiness().Listar(null).OrderBy(p => p.Descricao).ToList();
      }
      public List<TipoFormalizacao> ListarTipoFormalizacao()
      {
         return new TipoFormalizacaoBusiness().Listar(null);
      }
      #endregion

      #region "Autorização Digital"
      public void AutorizacaoDigital(long? cpf, int? tipocomunicacao, int? ddd, long? celular, string nome, int? simulacao)
      {
         new AutorizacaoDigitalConsignadoBusiness().Incluir(new AutorizacaoDigitalConsignado { Cpf = cpf, TipoComunicacao = tipocomunicacao, DDD = ddd, Celular = celular, DataHoraInicio = DateTime.Now, Nome = nome, Simulacao = simulacao });
      }

      public void AtualizaAutorizacaoDigital(AutorizacaoDigitalConsignado autorizacao)
      {
         new AutorizacaoDigitalConsignadoBusiness().Alterar(autorizacao);
      }

      public AutorizacaoDigitalConsignado BuscarAutorizacaoDigital(int? autorizacao)
      {
         return new AutorizacaoDigitalConsignadoBusiness().Obtem(autorizacao);
      }

      public AutorizacaoDigitalConsignado BuscaUltimaSolicitacaoAutorizacaoDigital(long? cpf, int? tipocomunicacao, int? ddd, long? celular)
      {
         return new AutorizacaoDigitalConsignadoBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(AutorizacaoDigitalConsignado.METADADO.Cpf, Filter.Equal, cpf, Link.And).Add(AutorizacaoDigitalConsignado.METADADO.TipoComunicacao, Filter.Equal, tipocomunicacao, Link.And).Add(AutorizacaoDigitalConsignado.METADADO.DDD, Filter.Equal, ddd, Link.And).Add(AutorizacaoDigitalConsignado.METADADO.Celular, Filter.Equal, celular, Link.And)).OrderByDescending(x => x.Id).FirstOrDefault();
      }
      #endregion

      #region Trilha Auditoria
      public List<LogInfo> ListarTrilhaAuditoriaProposta(long? proposta, int? simulacao, int? produto)
      {
         //TODO: Ajustar
         //return Consignado.ConsignadoService.GetInstance().ObterLogs(proposta, simulacao, produto).Where(x => x.Message.Contains(" - Exited.")).ToList();
         return new List<LogInfo>();
      }
      #endregion

      #region CEP
      public Cep ConsultarCEP(string CEP)
      {
         return new CepBusiness().Listar(WhereBuilder.Create().Add(Cep.METADADO.CEP, Filter.Equal, CEP)).FirstOrDefault();
      }
      #endregion

      #region Motivo de Recusa
      public List<MotivoRecusa> ListarMotivosRecusa()
      {
         return new MotivoRecusaBusiness().Listar(null);
      }

      public MotivoRecusa ObtemMotivoRecusa(int? id)
      {
         return new MotivoRecusaBusiness().Obtem(id);
      }

      public void SalvarMotivoRecusa(MotivoRecusa motivoRecusa)
      {
         if (motivoRecusa.Id == null || motivoRecusa.Id == 0)
         {
            new MotivoRecusaBusiness().Incluir(motivoRecusa);
         }
         else
         {
            new MotivoRecusaBusiness().Alterar(motivoRecusa);
         }

      }

      public void ExcluirMotivoRecusa(int? id)
      {
         new MotivoRecusaBusiness().Excluir(id);
      }
      #endregion

      #region Familia Produto
      public List<FamiliaProduto> ListarFamiliaProduto()
      {
         return new FamiliaProdutoBusiness().Listar(null);
      }

      public void SalvarFamiliaProdutos(FamiliaProduto familiaProduto)
      {
         if (familiaProduto.Id == null || familiaProduto.Id == 0)
         {
            new FamiliaProdutoBusiness().Incluir(familiaProduto);
         }
         else
         {
            new FamiliaProdutoBusiness().Alterar(familiaProduto);
         }

      }

      public void ExcluirFamiliaProduto(int? id)
      {
         new FamiliaProdutoBusiness().Excluir(id);
      }

      public FamiliaProduto ObtemFamiliaProduto(int? id)
      {
         return new FamiliaProdutoBusiness().Obtem(id);
      }
      #endregion

      #region Bancos
      public List<Bancos> ListarBancos()
      {
         return new BancosBusiness().Listar(null);
      }

      public Bancos ObtemBanco(string banco)
      {
         return new BancosBusiness().Obtem(banco);
      }

      public void IncluirBanco(Bancos banco)
      {
         new BancosBusiness().Incluir(banco);
      }

      public void ExcluirBanco(string banco)
      {
         new BancosBusiness().Excluir(banco);
      }

      public void AlterarBanco(Bancos banco)
      {
         new BancosBusiness().Alterar(banco);
      }

      public void SalvarBanco(Bancos banco)
      {
         if (banco.Id == null || banco.Id == 0)
         {
            new BancosBusiness().Incluir(banco);
         }
         else
         {
            new BancosBusiness().Alterar(banco);
         }
      }
      #endregion

      #region Ramo Atividade
      public List<RamoAtividade> ListarRamoAtividade(string tipoPessoa = null)
      {
         if (tipoPessoa == null)
         {
            return new RamoAtividadeBusiness().Listar(null).OrderBy(x => x.Descricao).ToList();
         }
         else
         {
            return new RamoAtividadeBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(RamoAtividade.METADADO.TipoPessoa, Filter.Equal, tipoPessoa)).OrderBy(x => x.Descricao).ToList();
         }
      }
      public RamoAtividade ObtemRamoAtividade(long? CodigoRamoAtividade)
      {
         return new RamoAtividadeBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(RamoAtividade.METADADO.Id, Filter.Equal, CodigoRamoAtividade, Link.And)).OrderBy(x => x.Descricao).FirstOrDefault();
      }
      #endregion

      #region Histórico Proposta
      public void GravarHistoricoProposta(PropostaModel novaProposta, string acao = null) => this.IncluirHistorico(
          new PropostaHistorico { Proposta = novaProposta.Id, DataExecucao = DateTime.Now, Fase = novaProposta.Fase, Usuario = novaProposta.UsuarioProposta ?? "System", Acao = (acao == null ? "SubmeterProposta" : acao) });

      public List<PropostaHistorico> ListarHistorico() => new PropostaHistoricoBusiness().Listar(null);

      public PropostaHistorico ObtemHistorico(int? historico) => new PropostaHistoricoBusiness().Obtem(historico);

      public void AlterarHistorico(PropostaHistorico historicoProposta) => new PropostaHistoricoBusiness().Alterar(historicoProposta);

      public void IncluirHistorico(PropostaHistorico historicoProposta) => new PropostaHistoricoBusiness().Incluir(historicoProposta);

      public List<PropostaHistorico> ListarHistorico(long? proposta, int? simulacao)
      {
         WhereBuilder where = WhereBuilder.Create();

         if (proposta != null)
         {
            where.Add(PropostaHistorico.METADADO.Proposta, Filter.Equal, proposta, Link.Or);
         }

         if (simulacao != null)
         {
            where.Add(PropostaHistorico.METADADO.Simulacao, Filter.Equal, simulacao, Link.Or);
         }

         return new PropostaHistoricoBusiness().Listar(where).OrderBy(c => c.DataExecucao).ToList();
      }
      #endregion
   }
}
