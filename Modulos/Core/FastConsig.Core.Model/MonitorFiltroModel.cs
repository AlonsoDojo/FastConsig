using FastConsig.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Core.Model
{
   [Serializable]
   public class MonitorFiltroModel
   {
      public int? Proposta { get; set; }
      public DateTime? DataInicial { get; set; }
      public DateTime? DataFinal { get; set; }
      public string CPF { get; set; }
      public string Nome { get; set; }
      public int? Fase { get; set; }
      public int? Status { get; set; }
      public List<Fases> RestricaoFase { get; set; }
      public string Usuario { get; set; }
      public int? Promotora { get; set; }
      public int? DDDCelular { get; set; }
      public int? Celular { get; set; }
      public int? Produto { get; set; }
      public string Contrato { get; set; }
      public int? RedeLoja { get; set; }
      public int? Loja { get; set; }
      public int? Gerente { get; set; }
      public string Telefone { get; set; }
      public List<Produtos> ProdutosHabilitados { get; set; }
      public MonitorFiltroModel()
      {
         this.RestricaoFase = new List<Fases>();
         this.ProdutosHabilitados = new List<Produtos>();
      }

   }
}
