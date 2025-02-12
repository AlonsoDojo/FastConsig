using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.CTC.Politicas
{
   public class RecepcaoArquivo : IPolicitaCTCArquivo
   {
      public void Execute(CTCArquivos arquivo)
      {
         CTCDominioArquivo tipoArquivo = CTCService.GetInstance().BuscarArquivosDominio(arquivo.DominioArquivo);
         try
         {
            Type typeProcess = Type.GetType(tipoArquivo.Process + ", FastConsig.CTC.Helpers");
            dynamic classeProcess = Activator.CreateInstance(typeProcess) as IACTCProcess;
            IACTCProcess process = classeProcess.Execute(arquivo.Id);
            arquivo.SituacaoArquivo = 2;
            arquivo.Status = "CONCLUIDO";

         }
         catch (Exception ex)
         {
            arquivo.Mensagem = "Mensagem: " + ex.Message + " - Stacktrace: " + ex.StackTrace;
            arquivo.SituacaoArquivo = 2;
            arquivo.Status = "COM ERRO";
         }
      }
   }
}
