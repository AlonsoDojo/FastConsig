using FastConsig.Core.Entity;
using FastConsig.Core.Model;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using FastConsig.Seguranca.Entity;
using FastConsig.Seguranca.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace FastConsig.Core.Web.Credito
{
   public partial class MonitorPropostas : FastConsigPageBase
   {
      public MonitorFiltroModel Filtro
      {
         get => ((MonitorFiltroModel)Session["__Filtro__"]);
         set => Session["__Filtro__"] = value;
      }

      protected override void OnPreRenderComplete(EventArgs e)
      {
         HtmlMeta meta = new HtmlMeta();
         meta.HttpEquiv = "Refresh";
         //TODO: Adicionar
         //meta.Content = ObterPreferenciaUsuario().tempoRefreshPadrao.ToString(); 
         this.Page.Header.Controls.Add(meta);

         base.OnPreRenderComplete(e);
      }
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso();

         AddMessageCollection<Fases>(PropostaService.GetInstance().ListarFases().OrderBy(x => x.Descricao).ToList());
         AddMessageCollection<Status>(PropostaService.GetInstance().ListarStatus().OrderBy(x => x.Descricao).ToList());
         DataBind();

         if (!IsPostBack)
         {
            MonitorFiltroModel filtro = this.Filtro;

            if (filtro == null)
            {
               filtro = new MonitorFiltroModel
               {
                  DataFinal = DateTime.Now,
                  DataInicial = DateTime.Now.AddMonths(-1) //TODO: Buscar da Preferência do Usuário
               };

               AddMessage<MonitorFiltroModel>("MonitorFiltroModel", filtro);
               this.Filtro = filtro;
               DataBind();

               var usuario = this.UserContext?.GetUserData<Usuario>();

               var produtosHabilitados = SegurancaService.GetInstance().ListarProdutosHabilitados(usuario.Id);

               List<Produtos> produtos = new List<Produtos>();

               if (produtosHabilitados != null)
               {
                  foreach (UsuarioProduto u in produtosHabilitados)
                  {
                     produtos.Add(PropostaService.GetInstance().ObtemProduto(u.Produto));
                  }
                  produtos = produtos.OrderBy(x => x.Nome).ToList();
               }

               AddMessageCollection(produtos, "Produtos");

               btnPesquisar_Click(sender, e);
            }
            else
            {
               var usuario = this.UserContext?.GetUserData<Usuario>();

               var produtosHabilitados = SegurancaService.GetInstance().ListarProdutosHabilitados(usuario.Id);

               List<Produtos> produtos = new List<Produtos>();

               if (produtosHabilitados == null)
               {
                  produtos.Add(new Produtos { Id = 0 });
               }
               else
               {
                  foreach (UsuarioProduto u in produtosHabilitados)
                  {
                     produtos.Add(PropostaService.GetInstance().ObtemProduto(u.Produto));
                  }
                  produtos = produtos.OrderBy(x => x?.Nome).ToList();
               }

               AddMessageCollection(produtos, "Produtos");
               AddMessage<MonitorFiltroModel>("MonitorFiltroModel", filtro);
               DataBind();

               btnPesquisar_Click(sender, e);
            }

            DataBind();
         }
      }

      protected void btnPesquisar_Click(object sender, EventArgs e)
      {
         DataUnbind();

         MonitorFiltroModel filtro = GetMessage<MonitorFiltroModel>("MonitorFiltroModel");

         if (filtro == null)
         {
            filtro = this.Filtro;
         }

         filtro.RestricaoFase = new List<Fases>();

         var fases = PropostaService.GetInstance().ListarFases();

         foreach (Fases f in fases)
         {
            if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Restringir Visualização de Propostas na Fase " + f.Descricao.Trim()))
            {
               filtro.RestricaoFase.Add(PropostaService.GetInstance().ObtemFase(f.Id));
            }
         }

         if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Restringir Visualização Somentes as Propostas Capturadas ou sob Gerência"))
         {
            Usuario usuario = UsuarioService.GetInstance().Obter(UserContext?.GetUserData<Usuario>().Id);
            filtro.Usuario = usuario.Login;
            filtro.Gerente = PropostaService.GetInstance().ObterGerente(usuario.CpfCnpj);
         }
         else
         {
            filtro.Usuario = null;
            filtro.Gerente = null;
         }

         if (VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Restringir Visualização Somente as Propostas da Promotora"))
         {
            int? promotora = UsuarioService.GetInstance().Obter(UserContext?.GetUserData<Usuario>().Id).Promotora;
            filtro.Promotora = promotora;
         }
         else
         {
            filtro.Promotora = null;
         }

         List<UsuarioProduto> produtosHabilitados = UsuarioService.GetInstance().ListarProdutos(UserContext?.GetUserData<Usuario>().Id);

         filtro.ProdutosHabilitados.Clear();

         if (produtosHabilitados.Count == 0)
         {
            produtosHabilitados.Add(new UsuarioProduto { Usuario = UserContext?.GetUserData<Usuario>().Id, Produto = 0 });
         }

         if (UserContext?.GetUserData<Usuario>().Loja != 1)
         {
            filtro.Loja = UserContext?.GetUserData<Usuario>().Loja;
         }
         else
         {
            if (!VerificarPermissaoAcessoAcaoUrl("/Credito/MonitorPropostas.aspx", "Master Promotora"))
            {
               filtro.Loja = UserContext?.GetUserData<Usuario>().Loja;
            }
         }

         foreach (UsuarioProduto produto in produtosHabilitados)
         {
            filtro.ProdutosHabilitados.Add(new Produtos { Id = produto.Produto });
         }

         AddMessageCollection<Fases>(PropostaService.GetInstance().ListarFases().OrderBy(x => x.Descricao).ToList());
         AddMessageCollection<Status>(PropostaService.GetInstance().ListarStatus().OrderBy(x => x.Descricao).ToList());

         AddMessage<MonitorFiltroModel>("MonitorFiltroModel", filtro);
         this.Filtro = filtro;

         DataBind();

      }

      protected void PropostasRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
      {

      }

      protected void lnkEditar_Click(object sender, EventArgs e)
      {

      }

      protected void btnPost_Click(object sender, EventArgs e)
      {
         string id = hfProposta.Value;
         PropostaModel proposta = PropostaService.GetInstance().ObterProposta(int.Parse(id));
         SetCrossPageData("Proposta", proposta);
         Response.Redirect(PropostaService.GetInstance().BuscarPaginaPadrao(proposta.Operacoes.Produto) + "?Comando=Editar", false);
      }
   }
}