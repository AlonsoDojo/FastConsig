using FastConsig.Common.Loggin;
using FastConsig.Core.Entity;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using FastConsig.Seguranca.Entity;
using FastConsig.Seguranca.Services;
using Framework.Web.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace FastConsig.Core.Web.Seguranca
{
   public partial class EditarPerfil : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("Perfis.aspx");

         if (!IsPostBack)
         {
            if (Request.Params["Comando"] == "Editar")
            {
               Perfil perfil = GetCrossPageData<Perfil>("Perfil");
               Editar(perfil.Id);
            }
            else if (Request.Params["Comando"] == "Novo")
            {
               Novo();
            }

            phFuncionalidades.Visible = true;
         }
      }

      protected void btnSalvar_Click(object sender, EventArgs e)
      {
         try
         {
            this.DataUnbind();
            var perfil = this.GetMessage<Perfil>();

            var usuarioService = UsuarioService.GetInstance();
            if (!perfil.Id.HasValue)
            {
               usuarioService.IncluirPerfil(perfil);

               btnExcluir.Visible = false;
               phFuncionalidades.Visible = true;
               //*------- Grava as permissões...
               var associados = new List<PerfilFuncionalidade>();
               var perfilEventosfuncionalidade = new List<PerfilEventoFuncionalidade>();

               foreach (RepeaterItem row in FuncionalidadesRepeater.Items)
               {
                  var chk = row.FindControl("chkFuncionalidade") as CheckBox;
                  if (chk?.Checked == true)
                  {
                     int idFuncionalidade = int.Parse(((Label)row.FindControl("lblFuncionalidadeId")).Text);
                     associados.Add(new PerfilFuncionalidade
                     {
                        IdFuncionalidade = idFuncionalidade,
                        IdPerfil = perfil.Id
                     });
                  }

                  //repeater dos eventos
                  var rptEventosFuncionalidade = ((Repeater)row.FindControl("rptEventosFuncionalidade"));
                  if (rptEventosFuncionalidade != null)
                  {
                     foreach (RepeaterItem repeater in rptEventosFuncionalidade.Items)
                     {
                        var evento = new PerfilEventoFuncionalidade();

                        evento.IdPerfil = perfil.Id;
                        evento.IdEventoFuncionalidade = int.Parse(((Label)repeater.FindControl("Id")).Text);
                        evento.Habilitado = ((CheckBox)(repeater.FindControl("chkEventoFuncionalidade"))).Checked;

                        perfilEventosfuncionalidade.Add(evento);
                     }
                  }
               }

               //*------- Grava as informaçÕes do perfil e suas permissões...
               usuarioService.AlterarPerfilUsuario(perfil, associados, perfilEventosfuncionalidade);

            }
            else
            {
               //*------- Grava as permissões...
               var associados = new List<PerfilFuncionalidade>();
               var perfilEventosfuncionalidade = new List<PerfilEventoFuncionalidade>();

               foreach (RepeaterItem row in FuncionalidadesRepeater.Items)
               {
                  var chk = row.FindControl("chkFuncionalidade") as CheckBox;
                  if (chk?.Checked == true)
                  {
                     int idFuncionalidade = int.Parse(((Label)row.FindControl("lblFuncionalidadeId")).Text);
                     associados.Add(new PerfilFuncionalidade
                     {
                        IdFuncionalidade = idFuncionalidade,
                        IdPerfil = perfil.Id
                     });
                  }

                  //repeater dos eventos
                  var rptEventosFuncionalidade = ((Repeater)row.FindControl("rptEventosFuncionalidade"));
                  if (rptEventosFuncionalidade != null)
                  {
                     foreach (RepeaterItem repeater in rptEventosFuncionalidade.Items)
                     {
                        var evento = new PerfilEventoFuncionalidade();

                        evento.IdPerfil = perfil.Id;
                        evento.IdEventoFuncionalidade = int.Parse(((Label)repeater.FindControl("Id")).Text);
                        evento.Habilitado = ((CheckBox)(repeater.FindControl("chkEventoFuncionalidade"))).Checked;

                        perfilEventosfuncionalidade.Add(evento);
                     }
                  }
               }

               //*------- Grava as informaçÕes do perfil e suas permissões...
               usuarioService.AlterarPerfilUsuario(perfil, associados, perfilEventosfuncionalidade);
            }

            AddMessage(perfil);

            this.DataBind();
            ShowMessage(TipoMensagem.Aviso, MensagemTexto.MsgDadosSalvosComSucesso);
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogDebug(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, ex.Message);
         }
      }

      protected void btnExcluir_Click(object sender, EventArgs e)
      {
         DataUnbind();

         Perfil perfil = GetMessage<Perfil>("Perfil");

         UsuarioService.GetInstance().ExcluirPerfil(perfil.Id);

         this.AddMessage<Perfil>(perfil);

         btnExcluir.Visible = false;
         btnSalvar.Visible = false;

         ShowMessage(TipoMensagem.Aviso, "Dados Eliminados com Sucesso!");

         Response.Redirect("/Seguranca/Perfis.aspx", false);
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Seguranca/Perfis.aspx", false);
      }

      private void Novo()
      {
         Perfil perfil = new Perfil();
         this.AddMessage<Perfil>(perfil);
         btnExcluir.Visible = false;
         CarregarFuncionalidades();
         this.DataBind();
      }

      private void Editar(int? id)
      {
         try
         {
            Perfil perfil = UsuarioService.GetInstance().ObtemPerfil(id);

            this.AddMessage<Perfil>(perfil);

            CarregarFuncionalidades();

            btnExcluir.Visible = false;

            this.DataBind();
         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Editar Perfil"));
         }
      }

      protected void FuncionalidadesRepeater_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            var o = (Funcionalidade)e.Item.DataItem;
            ((Label)e.Item.FindControl("lblFuncionalidadeId")).Text = o.Id?.ToString();
            ((Label)e.Item.FindControl("lblNomeGrupo")).Text = o.NomeGrupo;
            ((Label)e.Item.FindControl("lblNomeFuncionalidade")).Text = o.Nome;
            ((Label)e.Item.FindControl("lblUrl")).Text = o.Url;
            ((Label)e.Item.FindControl("lblHabilitado")).CssClass = o.Habilitado ? "fa fa-check" : "fa fa-ban";
         }
      }

      private void CarregarFuncionalidades()
      {
         //*------- Preenche o grig de funcionalidades...
         var funcionalidadeSrv = FuncionalidadeService.GetInstance();
         var funcionalidades = funcionalidadeSrv.Listar();
         FuncionalidadesRepeater.DataSource = funcionalidades?.OrderBy(f => f.NomeGrupo)
                                                              .ThenBy(f => f.Sequencia)
                                                              .ThenBy(f => f.Nome);
         FuncionalidadesRepeater.DataBind();

         //*------- Carrega as permissões do perfil...
         var perfil = GetMessage<Perfil>();
         if (!perfil.Id.HasValue)
         {
            perfil = new Perfil() {Id = 0 };
         }

         var associados = funcionalidadeSrv.ListarPerfilFuncionalidades(perfil.Id.Value);

         //Localiza cada funcionalidade parar marcar no grid...
         foreach (RepeaterItem row in FuncionalidadesRepeater.Items)
         {
            int idFuncionalidade = int.Parse(((Label)row.FindControl("lblFuncionalidadeId")).Text);

            CheckBox chk = row.FindControl("chkFuncionalidade") as CheckBox;
            if (chk != null)
            {
               var o = associados.Find(a => a.IdFuncionalidade == idFuncionalidade);
               chk.Checked = o != null;
            }

            //buscano os eventos da funcionalidade de acordo com o perfil
            var eventosPerfilFuncionalidade = FuncionalidadeService.GetInstance().ListarEventoPerfilFuncionalidade(idFuncionalidade, perfil.Id.Value);
            var eventosFuncionalidade = FuncionalidadeService.GetInstance().ListarEventoFuncionalidade(idFuncionalidade);

            //repeater dos eventos
            var rptEventosFuncionalidade = ((Repeater)row.FindControl("rptEventosFuncionalidade"));
            if (rptEventosFuncionalidade != null && eventosFuncionalidade.Count > 0)
            {
               rptEventosFuncionalidade.DataSource = eventosFuncionalidade;
               rptEventosFuncionalidade.DataBind();

               foreach (RepeaterItem repeater in rptEventosFuncionalidade.Items)
               {
                  int idEventosFuncionalidade = int.Parse(((Label)repeater.FindControl("Id")).Text);

                  CheckBox chkEventoFuncionalidade = repeater.FindControl("chkEventoFuncionalidade") as CheckBox;
                  if (chk != null)
                  {
                     var o = eventosPerfilFuncionalidade.Find(a => a.Id == idEventosFuncionalidade && a.Habilitado == true);
                     chkEventoFuncionalidade.Checked = o != null;
                  }
               }
            }
         }
      }

      protected void rptEventosFuncionalidade_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            var o = (EventoFuncionalidade)e.Item.DataItem;
            ((Label)e.Item.FindControl("Id")).Text = o.Id?.ToString();
            ((Label)e.Item.FindControl("Nome")).Text = o.Nome;
         }
      }

   }
}