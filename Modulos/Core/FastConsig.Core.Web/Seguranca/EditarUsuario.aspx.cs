using FastConsig.Common.Helpers;
using FastConsig.Common.Loggin;
using FastConsig.Common.Services;
using FastConsig.Core.Entity;
using FastConsig.Core.Model;
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
   public partial class EditarUsuario : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso("Usuarios.aspx");

         if (!IsPostBack)
         {
            AddMessageCollection<Dominio>(SegurancaService.GetInstance().ListarDominios().OrderBy(x => x.Descricao).ToList());
            AddMessageCollection<Promotoras>(PropostaService.GetInstance().ListarPromotoras().OrderBy(x => x.Nome).ToList());
            AddMessageCollection<Lojas>(new List<Lojas>(), "Lojas");
            AddMessageCollection(new List<RedeLoja>(), "RedeLoja");

            if (Request.Params["Comando"] == "Editar")
            {
               Usuario usuario = GetCrossPageData<Usuario>("Usuario");
               Editar(usuario.Id);
               txtCodigo.Enabled = false;
            }
            else if (Request.Params["Comando"] == "Novo")
            {
               Novo();
            }

            DataBind();
         }
      }

      protected void btnSalvar_Click(object sender, EventArgs e)
      {
         try
         {
            this.DataUnbind();

            var usuarioService = UsuarioService.GetInstance();
            var usuario = this.GetMessage<Usuario>();
            usuario.DataRegistro = DateTime.Now;
            usuario.UsuarioRegistro = Contexto.GetUserData<Usuario>()?.Login;
            string msgRetorno = "";
            string novaSenha = new CryptoHelper().RandomPassword(8, 10);

            if (usuario.Promotora != null)
            {
               if (usuario.RedeLojas == null)
               {
                  ShowMessage(TipoMensagem.Erro, "Quando Informado uma Promotora o Código de Rede de Lojas e Loja deve ser Informado");
                  return;
               }

               if (usuario.Loja == null)
               {
                  ShowMessage(TipoMensagem.Erro, "Quando Informado uma Promotora o Código de Rede de Lojas e Loja deve ser Informado");
                  return;
               }
            }


            if (string.IsNullOrEmpty(usuario.Id?.ToString()))
            {
               usuario.Senha = CryptoHelper.GenerateHashPassword(novaSenha);
               usuario = UtilityHelper.Clone(usuario);
               usuario.Id = Guid.NewGuid().ToString().ToUpper();

               usuarioService.IncluirUsuario(usuario);

               usuario = SegurancaService.GetInstance().ObterInformacoesUsuario(usuario.Id);

               if (usuario.TipoAutenticacao == 2)
               {
                  var xpto = new Dictionary<string, object> { };
                  xpto.Add("{{email.to}}", usuario.Email);
                  xpto.Add("{{pessoa.nome}}", usuario.Nome);

                  //TODO: Enviar a Notificação com a Senha
                  //EnviarNotificacao(new MailConfig { EmailFrom = ConfiguracaoService.GetInstance().Config<string>("portalpaulista.mail.from"), SmtpServer = ConfiguracaoService.GetInstance().Obter("STMP_SERVER").Conteudo }, xpto, "Senha de Acesso", "Sua nova senha de acesso ao sistema Credit Manager é " + novaSenha);
                  msgRetorno = "Senha de Acesso enviado para o e-mail do usuário";
               }

               ddlDominio.Enabled = false;
               txtCodigo.Enabled = false;
               btnExcluir.Visible = true;
               txtCPF.Enabled = false;
               phPerfis.Visible = true;
               phProdutos.Visible = true;
            }

            //*------- Grava as permissões...
            var associados = new List<UsuarioPerfil>();
            foreach (RepeaterItem row in PerfisRepeater.Items)
            {
               var chk = row.FindControl("chkPerfil") as CheckBox;
               if (chk?.Checked == true)
               {
                  int idPerfil = int.Parse(((Label)row.FindControl("lblPerfilId")).Text);
                  associados.Add(new UsuarioPerfil
                  {
                     IdUsuario = usuario.Id,
                     IdPerfil = idPerfil
                  });
               }
            }
            //*--------Grava os Produtos
            var produtos = new List<UsuarioProduto>();
            foreach (RepeaterItem rowProduto in ProdutosRepeater.Items)
            {
               var chkProduto = rowProduto.FindControl("chkProduto") as CheckBox;
               if (chkProduto?.Checked == true)
               {
                  string idProduto = ((Label)rowProduto.FindControl("lblProdutoId")).Text.Trim();
                  produtos.Add(new UsuarioProduto
                  {
                     Usuario = usuario.Id,
                     Produto = int.Parse(idProduto)
                  });
               }

            }

            //*------- Grava o usuário...
            usuarioService.AlterarUsuario(usuario, associados, produtos);

            AddMessage(usuario);
            this.DataBind();

            CarregarPerfis();
            this.CarregarProdutos();

            ShowMessage(TipoMensagem.Aviso, "Dados Salvos com Sucesso!");
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

         Usuario usuario = GetMessage<Usuario>("Usuario");

         UsuarioService.GetInstance().ExcluirUsuario(usuario.Id);

         this.AddMessage<Usuario>(usuario);

         btnExcluir.Visible = false;
         btnSalvar.Visible = false;

         ShowMessage(TipoMensagem.Aviso, "Dados Eliminados com Sucesso!");

         Response.Redirect("/Seguranca/Usuarios.aspx", false);
      }

      protected void btnVoltar_Click(object sender, EventArgs e)
      {
         Response.Redirect("/Seguranca/Usuarios.aspx", false);
      }

      private void Novo()
      {
         Usuario usuario = new Usuario();
         usuario.Promotora = UserContext.GetUserData<Usuario>().Promotora;
         usuario.Dominio = UserContext.GetUserData<Usuario>().Dominio;
         usuario.RedeLojas = UserContext.GetUserData<Usuario>().RedeLojas;
         usuario.Loja = UserContext.GetUserData<Usuario>().Loja;
         AddMessageCollection(PropostaService.GetInstance().ListarRedeLojasPromotora(usuario.Promotora), "RedeLoja");
         AddMessageCollection<Lojas>(PropostaService.GetInstance().ListarLojasRede(usuario.RedeLojas).OrderBy(x => x.Nome).ToList());
         this.AddMessage<Usuario>(usuario);
         btnExcluir.Visible = false;
         CarregarPerfis();
         CarregarProdutos(UserContext.GetUserData<Usuario>().Id);
         this.DataBind();
      }

      private void Editar(string id)
      {
         try
         {
            Usuario usuario = UsuarioService.GetInstance().Obter(id);

            this.AddMessage<Usuario>(usuario);
            CarregarPerfis();
            CarregarProdutos(UserContext.GetUserData<Usuario>().Id);

            if (usuario.RedeLojas != null)
            {
               AddMessageCollection<RedeLoja>(PropostaService.GetInstance().ListarRedeLojasPromotora(usuario.Promotora), "RedeLoja");
               DataBind();
            }

            if (usuario.Loja != null)
            {
               AddMessageCollection<Lojas>(PropostaService.GetInstance().ListarLojasRede(usuario.RedeLojas).OrderBy(x => x.Nome).ToList(), "Lojas");
               DataBind();
            }

            

            this.DataBind();

         }
         catch (Exception ex)
         {
            GravarLogErro(ex, ex.Message);
            ShowMessage(TipoMensagem.Erro, string.Format(MensagemTexto.MsgPadraoErro, "Editar Usuário"));
         }
      }

      protected void ddlPromotora_SelectedIndexChanged(object sender, EventArgs e)
      {
         DataUnbind();

         Usuario usuario = GetMessage<Usuario>();

         if (usuario.Promotora != null)
         {
            List<RedeLoja> redeLoja = PropostaService.GetInstance().ListarRedeLojasPromotora(usuario.Promotora);
            AddMessageCollection<Lojas>(new List<Lojas>(), "Lojas");
            AddMessageCollection(redeLoja, "RedeLoja");
         }
         else
         {
            AddMessageCollection(new List<RedeLoja>(), "RedeLoja");
            AddMessageCollection<Lojas>(new List<Lojas>(), "Lojas");
         }

         DataBind();
      }

      protected void ddlRedeLojas_SelectedIndexChanged(object sender, EventArgs e)
      {
         DataUnbind();

         Usuario usuario = GetMessage<Usuario>();

         if (usuario.RedeLojas != null)
         {
            AddMessageCollection<Lojas>(PropostaService.GetInstance().ListarLojasRede(usuario.RedeLojas).OrderBy(x => x.Nome).ToList());
         }
         else
         {
            AddMessageCollection<Lojas>(new List<Lojas>(), "Lojas");
         }

         DataBind();
      }

      protected void PerfisRepeater_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            var o = (Perfil)e.Item.DataItem;

            ((Label)e.Item.FindControl("lblPerfilId")).Text = o.Id?.ToString();
            ((Label)e.Item.FindControl("lblNomePerfil")).Text = o.Nome;
            ((Label)e.Item.FindControl("lblHabilitado")).CssClass = o.Habilitado ? "fa fa-check" : "fa fa-ban";
         }
      }

      protected void ProdutosRepeater_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
      {
         if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
         {
            var o = (Produtos)e.Item.DataItem;

            ((Label)e.Item.FindControl("lblProdutoId")).Text = o.Id.ToString();
            ((Label)e.Item.FindControl("lblProduto")).Text = o.Nome;
         }
      }

      private void CarregarProdutos()
      {
         //*------- Preenche o grig de perfis...
         var usuarioSrv = UsuarioService.GetInstance();
         var produtos = PropostaService.GetInstance().ListarProdutos();
         ProdutosRepeater.DataSource = produtos?.OrderBy(f => f.Nome);
         ProdutosRepeater.DataBind();

         //*------- Carrega as permissões do perfil...
         var usuario = GetMessage<Usuario>();
         if (string.IsNullOrEmpty(usuario.Id))
            return;

         var associados = usuarioSrv.ListarProdutos(usuario.Id);

         //Localiza cada funcionalidade parar marcar no grid...
         foreach (RepeaterItem row in ProdutosRepeater.Items)
         {
            var chk = row.FindControl("chkProduto") as CheckBox;
            if (chk != null)
            {
               int idProduto = int.Parse(((Label)row.FindControl("lblProdutoId")).Text);
               var o = associados.Find(a => a.Produto == idProduto);
               chk.Checked = o != null;
            }
         }
      }

      private void CarregarProdutos(string idUsuario)
      {
         //*------- Preenche o grig de perfis...
         var usuarioSrv = UsuarioService.GetInstance();
         var produtos = UsuarioService.GetInstance().ListarProdutosDoUsuario(UserContext.GetUserData<Usuario>().Id);
         ProdutosRepeater.DataSource = produtos?.OrderBy(f => f.Nome);
         ProdutosRepeater.DataBind();

         //*------- Carrega as permissões do perfil...
         var usuario = GetMessage<Usuario>();
         if (string.IsNullOrEmpty(usuario.Id))
            return;

         var associados = usuarioSrv.ListarProdutos(usuario.Id);

         //Localiza cada funcionalidade parar marcar no grid...
         foreach (RepeaterItem row in ProdutosRepeater.Items)
         {
            var chk = row.FindControl("chkProduto") as CheckBox;
            if (chk != null)
            {
               int idProduto = int.Parse(((Label)row.FindControl("lblProdutoId")).Text.Trim());
               var o = associados.Find(a => a.Produto == idProduto);
               chk.Checked = o != null;
            }

            if (!VerificarPermissaoAcessoAcaoUrl("/Seguranca/Usuarios.aspx", "Editar Usuário"))
            {
               chk.Enabled = false;
            }
         }
      }

      private void CarregarPerfis()
      {
         //*------- Preenche o grig de perfis...
         var usuarioSrv = UsuarioService.GetInstance();
         var perfis = UsuarioService.GetInstance().ListarPerfis(true);
         PerfisRepeater.DataSource = perfis?.OrderBy(f => f.Nome);
         PerfisRepeater.DataBind();

         //*------- Carrega as permissões do perfil...
         var usuario = GetMessage<Usuario>();
         if (string.IsNullOrEmpty(usuario.Id))
            return;

         var associados = usuarioSrv.ListarPerfis(usuario.Id);

         //Localiza cada funcionalidade parar marcar no grid...
         foreach (RepeaterItem row in PerfisRepeater.Items)
         {
            var chk = row.FindControl("chkPerfil") as CheckBox;
            if (chk != null)
            {
               int idPerfil = int.Parse(((Label)row.FindControl("lblPerfilId")).Text);
               var o = associados.Find(a => a.IdPerfil == idPerfil);
               chk.Checked = o != null;
            }

            if (!VerificarPermissaoAcessoAcaoUrl("/Seguranca/UsuariosAdmin.aspx", "Editar Usuário"))
            {
               chk.Enabled = false;
            }
         }
      }
   }
}