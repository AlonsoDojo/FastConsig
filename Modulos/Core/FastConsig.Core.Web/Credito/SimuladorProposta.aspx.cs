using FastConsig.Barramento.Services;
using FastConsig.Common.Helpers;
using FastConsig.Common.Loggin;
using FastConsig.Common.Services;
using FastConsig.Core.Entity;
using FastConsig.Core.Model;
using FastConsig.Core.Services;
using FastConsig.Core.Web.Helpers;
using FastConsig.Core.Web.Seguranca;
using FastConsig.Seguranca.Entity;
using FastConsig.Seguranca.Services;
using Framework.Web.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace FastConsig.Core.Web.Credito
{
   public partial class SimuladorProposta : FastConsigPageBase
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         VerificarPermissaoAcesso();

         if (!IsPostBack)
         {
            SimulacaoPropostaModel model = new SimulacaoPropostaModel();
            
            AddMessageCollection<ComboValueBoleanoModel>(PropostaService.GetInstance().ListarSimNaoBoleano().OrderBy(x => x.Descricao).ToList(), "IndicadorAnafalbetismo");
            AddMessageCollection<Promotoras>(PropostaService.GetInstance().ListarPromotoras().OrderBy(x => x.Nome).ToList());
            AddMessageCollection<TipoComunicacao>(PropostaService.GetInstance().ListarTipoComunicacao().OrderBy(x => x.Descricao).ToList());
            AddMessageCollection<TipoBeneficioINSS>(PropostaService.GetInstance().ListarTipoBeneficioINSS().Where(x => x.Aceito).OrderBy(x => x.Descricao).ToList());
            AddMessageCollection<OrgaoSIAPE>(PropostaService.GetInstance().ListarOrgaosSIAPE().OrderBy(x => x.Descricao).ToList());
            AddMessageCollection<Lojas>(new List<Lojas>(), "Lojas");
            AddMessageCollection(new List<RedeLoja>(), "RedeLoja");
            AddMessageCollection(new List<Produtos>(), "Produtos");

            var usuario = this.UserContext?.GetUserData<Usuario>();
            var produtosHabilitados = SegurancaService.GetInstance().ListarProdutosHabilitados(usuario.Id);

            if (usuario.Promotora != null)
            {
               model.Promotora = usuario.Promotora;
               model.Operacao.RedeLojas = usuario.RedeLojas;
               model.Operacao.Loja = usuario.Loja;
               Identificacao.Visible = false;
            } else
            {
               Identificacao.Visible = true;
            }

            AddMessage<SimulacaoPropostaModel>(model);

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

            DataBind();
         }
      }

      protected void ddlPromotora_SelectedIndexChanged(object sender, EventArgs e)
      {
         DataUnbind();

         SimulacaoPropostaModel simulacao = GetMessage<SimulacaoPropostaModel>();

         if (simulacao.Promotora != null)
         {
            List<RedeLoja> redeLoja = PropostaService.GetInstance().ListarRedeLojasPromotora(simulacao.Promotora);
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

         SimulacaoPropostaModel simulacao = GetMessage<SimulacaoPropostaModel>();

         if (simulacao.Operacao.RedeLojas != null)
         {
            AddMessageCollection<Lojas>(PropostaService.GetInstance().ListarLojasRede(simulacao.Operacao.RedeLojas).OrderBy(x => x.Nome).ToList());
         }
         else
         {
            AddMessageCollection<Lojas>(new List<Lojas>(), "Lojas");
         }

         DataBind();
      }

      protected void ddlProduto_SelectedIndexChanged(object sender, EventArgs e)
      {
         DataUnbind();

         SimulacaoPropostaModel simulacao = GetMessage<SimulacaoPropostaModel>();

         if (simulacao.Operacao.Produto != null)
         {
            Produtos produto = PropostaService.GetInstance().ObtemProduto(simulacao.Operacao.Produto);

            if (produto.FamiliaProduto == 1 || produto.FamiliaProduto == 3)
            {
               INSS.Visible = true;
               SIAPE.Visible = false;
            } else if (produto.FamiliaProduto == 2 || produto.FamiliaProduto == 4)
            {
               INSS.Visible = false;
               SIAPE.Visible = true;

               if (produto.ExibeInstituidor)
               {
                  labelInstituidor.Visible = true;
                  txtInstituidor.Visible = true;
               } else
               {
                  labelInstituidor.Visible = false;
                  txtInstituidor.Visible = false;
               }
            }

            DadosCliente.Visible = true;
            DadosOperacao.Visible = true;
            if (produto.FamiliaProduto == 3 || produto.FamiliaProduto == 4)
            {
               btnBuscarContratos.Visible = true;
               btnSimular.Visible = false;
            } else
            {
               btnSimular.Visible = true;
               btnBuscarContratos.Visible = false;
            }
            
         } else
         {
            INSS.Visible = false;
            SIAPE.Visible = false;
            DadosCliente.Visible = false;
            DadosOperacao.Visible = false;
            btnSimular.Visible = false;
            btnEnviarAutorizacao.Visible = false;
            btnNovaSimulacao.Visible = false;
            btnSubmeter.Visible = false;
         }

         AddMessageCollection(BarramentoService.GetInstance().ListarTabelas(simulacao.Promotora, simulacao.Operacao.Produto), "TabelaFinanceiraModel");

         DataBind();
      }

      protected void btnSimular_Click(object sender, EventArgs e)
      {

      }

      protected void btnNovaSimulacao_Click(object sender, EventArgs e)
      {

      }

      protected void btnSubmeter_Click(object sender, EventArgs e)
      {

      }

      protected void btnBuscarContratos_Click(object sender, EventArgs e)
      {

      }

      protected void btnEnviarAutorizacao_Click(object sender, EventArgs e)
      {

      }
   }
}