
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Framework;
using Framework.Data;
#endregion

namespace FastConsig.Consignado.Entity
{
	public partial class JobStatus
	{
      public const string AGUARDANDO = "A";

      /// <summary>Job está sendo executado.</summary>
      public const string PROCESSANDO = "P";

      /// <summary>Processado com sucesso. (Tudo OK)</summary>
      public const string PROCESSADO = "O";

      /// <summary>Processado com erro. (Algum erro ocorreu no processamento)</summary>
      public const string ERRO = "E";

      /// <summary>Processado encerrado. (Algum erro ocorreu e por isso está sendo encerrado)</summary>
      public const string ENCERRADO = "C";

      /// <summary>Processado com sucesso. (Tudo OK)</summary>
      //public const string REVISAR = "R";
   }
}
