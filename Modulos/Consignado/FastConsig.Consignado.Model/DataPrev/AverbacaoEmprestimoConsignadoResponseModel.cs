using FastConsig.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class AverbacaoEmprestimoConsignadoResponseModel : PropostaBaseModel
   {
      public decimal? CompetenciaInicioDesconto { get; set; }
      public string Mensagem { get; set; }
      public string NumeroContrato { get; set; }
      public string CodigoSucesso { get; set; }
      public decimal? HashOperacao { get; set; }

      public AverbacaoEmprestimoConsignadoErroModel Erros { get; set; }
   }
}
