using FastConsig.Common.Loggin;
using FastConsig.Scheduler.Services;
using FastConsig.Scheduler.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using FastConsig.Common.Services;
using FastConsig.ProfissionaisCertificados.Entity;
using FastConsig.ProfissionaisCertificados.Service;
using System.IO.Compression;

namespace FastConsig.Scheduler.Tarefas
{
   public class ProfissionaisCertificados : IJob
   {
      public void Execute(string args)
      {
         try
         {
            LogService.GetInstance().GravarLogInfo("Atualização dos Profissionais Certificados");

            string dataProcessamento = "";

            dataProcessamento = DateTime.Now.Date.ToString("yyyy-MM-dd");

            string arquivoCertificadoras = "CRCP-Certificadoras-";
            string arquivoTipos = "CRCP-TiposCert-";
            string arquivoProfissionais = "CRCP-Full-";
            string arquivoIO = "CRCP-IO-";

            LogService.GetInstance().GravarLogInfo("Efetuando o Download dos Arquivos");

            DownloadFile(arquivoCertificadoras + dataProcessamento + ".txt");
            DownloadFile(arquivoTipos + dataProcessamento + ".txt");
            DownloadFile(arquivoProfissionais + dataProcessamento + ".txt");
            DownloadFile(arquivoIO + dataProcessamento + ".txt");
            ImportaCertificadoras(arquivoCertificadoras + dataProcessamento + ".txt");

            try
            {
               ImportaTipoCertificados(arquivoTipos + dataProcessamento + ".txt");
            }
            catch (Exception)
            {

            }

            ImportaProfissionais(arquivoProfissionais + dataProcessamento + ".txt");

            string diretorioDestino = ConfiguracaoService.GetInstance().Config<string>("crcp.diretorio.download.temp");

            var zip = new ZipArchive(File.Create(diretorioDestino + "CRCP-" + dataProcessamento + ".zip"), ZipArchiveMode.Create);
            zip.CreateEntry(diretorioDestino + arquivoCertificadoras + dataProcessamento + ".txt");
            zip.CreateEntry(diretorioDestino + arquivoTipos + dataProcessamento + ".txt");
            zip.CreateEntry(diretorioDestino + arquivoProfissionais + dataProcessamento + ".txt");
            zip.CreateEntry(diretorioDestino + arquivoIO + dataProcessamento + ".txt");
            zip.Dispose();

            System.IO.File.Delete(diretorioDestino + arquivoCertificadoras + dataProcessamento + ".txt");
            System.IO.File.Delete(diretorioDestino + arquivoTipos + dataProcessamento + ".txt");
            System.IO.File.Delete(diretorioDestino + arquivoProfissionais + dataProcessamento + ".txt");
            System.IO.File.Delete(diretorioDestino + arquivoIO + dataProcessamento + ".txt");

            LogService.GetInstance().GravarLogInfo("Termino da Atualização dos Profissionais Certificados");
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogErro(ex, "Falha na Atualização dos Profissionais Certificados - Message: " + ex.Message + " - Stacktrace: " + ex.StackTrace);
         }
      }

      private static void DownloadFile(string arquivo)
      {
         try
         {
            string diretorioDestino = ConfiguracaoService.GetInstance().Config<string>("crcp.diretorio.download.temp");

            LogService.GetInstance().GravarLogDebug("Baixando o arquivo: " + arquivo + " em " + diretorioDestino);

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ConfiguracaoService.GetInstance().Config<string>("crcp.febraban.ftp.url") + "/" + arquivo);
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            request.Credentials = new NetworkCredential(ConfiguracaoService.GetInstance().Config<string>("crcp.febraban.ftp.user"), ConfiguracaoService.GetInstance().Config<string>("crcp.febraban.ftp.password"));

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            StreamWriter fs = new StreamWriter(Path.Combine(diretorioDestino, arquivo));

            string line;

            while ((line = reader.ReadLine()) != null)
            {
               fs.WriteLine(line);
            }

            fs.Close();
            reader.Close();

            LogService.GetInstance().GravarLogDebug(string.Format("Download do arquivo {0} Completo, status {1}", arquivo, response.StatusDescription));

            reader.Close();
            response.Close();
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogErro(ex, string.Format("Falha ao Baixar o arquivo {0}", arquivo, ex.Message, ex.StackTrace));
            throw;
         }
      }

      private static void ImportaCertificadoras(string arquivo)
      {
         string diretorio = ConfiguracaoService.GetInstance().Config<string>("crcp.diretorio.download.temp");

         try
         {
            LogService.GetInstance().GravarLogDebug(string.Format("Importando o Arquivo {0}", arquivo));

            StreamReader fs = new StreamReader(Path.Combine(diretorio, arquivo));

            string line;

            while ((line = fs.ReadLine()) != null)
            {
               if (line.Trim() == "")
               {

               }
               else if (line.Substring(0, 9) == "CABECALHO" || line.Substring(0, 6) == "RODAPE")
               {

               }
               else
               {
                  ProfissionaisCertificadosCertificadora certificadora = new ProfissionaisCertificadosCertificadora();
                  certificadora.Id = int.Parse(line.Substring(0, 2));
                  certificadora.Descricao = line.Substring(2).Trim();

                  ProfissionaisCertificadosService.GetInstance().IncluirAlterarCertificadora(certificadora);

               }
            }
            fs.Close();
            LogService.GetInstance().GravarLogDebug(string.Format("Termino da Importação do Arquivo {0}", arquivo));
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogErro(ex, string.Format("Falha na Importação do Arquivo {0}", arquivo));
            throw;
         }
      }

      private static void ImportaTipoCertificados(string arquivo)
      {
         string diretorio = ConfiguracaoService.GetInstance().Config<string>("crcp.diretorio.download.temp");

         try
         {
            LogService.GetInstance().GravarLogDebug(string.Format("Importando o Arquivo {0}", arquivo));

            StreamReader fs = new StreamReader(Path.Combine(diretorio, arquivo));

            string line;

            while ((line = fs.ReadLine()) != null)
            {
               if (line.Trim() == "")
               {

               }
               else if (line.Substring(0, 9) == "CABECALHO" || line.Trim() == "" || line.Substring(0, 6) == "RODAPE")
               {

               }
               else
               {
                  ProfissionaisCertificadosTipoCertificado tipoCertificao = new ProfissionaisCertificadosTipoCertificado();
                  tipoCertificao.Id = int.Parse(line.Substring(0, 4));
                  tipoCertificao.Descricao = line.Substring(4, 100).Trim();
                  tipoCertificao.Codigo = line.Substring(104).Trim();

                  ProfissionaisCertificadosService.GetInstance().IncluirAlterarTipoCertificado(tipoCertificao);

               }
            }
            fs.Close();

            LogService.GetInstance().GravarLogDebug(string.Format("Termino da Importação do Arquivo {0}", arquivo));
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogErro(ex, string.Format("Falha na Importação do Arquivo {0} ", arquivo));
            throw;
         }
      }

      private static void ImportaProfissionais(string arquivo)
      {
         string diretorio = ConfiguracaoService.GetInstance().Config<string>("crcp.diretorio.download.temp");

         try
         {
            LogService.GetInstance().GravarLogDebug(string.Format("Importando o Arquivo {0}", arquivo));

            StreamReader fs = new StreamReader(Path.Combine(diretorio, arquivo));

            string line;

            while ((line = fs.ReadLine()) != null)
            {
               if (line.Trim() == "")
               {

               }
               else if (line.Substring(0, 9) == "CABECALHO" || line.Trim() == "" || line.Substring(0, 6) == "RODAPE")
               {

               }
               else
               {
                  ProfissionaisCertificadosProfissionais profissionais = new ProfissionaisCertificadosProfissionais();
                  profissionais.Id = int.Parse(line.Substring(7, 12));
                  profissionais.Certificadora = int.Parse(line.Substring(19, 2));
                  profissionais.TipoCertificado = int.Parse(line.Substring(21, 4));
                  profissionais.Cpf = long.Parse(line.Substring(25, 11));
                  profissionais.Nome = line.Substring(36, 100).Trim();
                  profissionais.DataAprovacao = DateTime.ParseExact(line.Substring(136, 10).Trim(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                  profissionais.DataValidade = DateTime.ParseExact(line.Substring(146, 10).Trim(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                  profissionais.NumeroCertificado = line.Substring(156).Trim();

                  ProfissionaisCertificadosService.GetInstance().IncluirAlterarProfissional(profissionais);
               }
            }
            fs.Close();
            LogService.GetInstance().GravarLogDebug(string.Format("Término da Importação do Arquivo {0}", arquivo));
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogErro(ex, string.Format("Falha na Importação do Arquivo {0}", arquivo));
         }
      }

   }

}
