using FastConsig.CTC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.CTC.Model.Interfaces
{
   public interface IPolicitaCTCArquivo
   {
      void Execute(CTCArquivos arquivo);
   }
}
