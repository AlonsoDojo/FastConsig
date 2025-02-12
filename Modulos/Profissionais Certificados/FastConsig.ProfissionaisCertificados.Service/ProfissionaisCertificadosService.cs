using FastConsig.Common.Loggin;
using FastConsig.ProfissionaisCertificados.Business;
using FastConsig.ProfissionaisCertificados.Entity;
using Framework.Data;
using System;
using System.Collections.Generic;

namespace FastConsig.ProfissionaisCertificados.Service
{
   public class ProfissionaisCertificadosService
   {
      private static ProfissionaisCertificadosService _instance;

      /// <summary>
      /// Obtém a instância do serviço de Profissionais Certificados.
      /// </summary>
      /// <returns></returns>
      public static ProfissionaisCertificadosService GetInstance()
      {
         if (_instance == null)
            _instance = new ProfissionaisCertificadosService();

         return _instance;
      }

      public void IncluirAlterarCertificadora(ProfissionaisCertificadosCertificadora certificadora)
      {
         var cert = new ProfissionaisCertificadosCertificadoraBusiness().Obtem(certificadora.Id);

         if (cert == null)
         {
            new ProfissionaisCertificadosCertificadoraBusiness().Incluir(certificadora);
         }
         else
         {
            new ProfissionaisCertificadosCertificadoraBusiness().Alterar(certificadora);
         }
      }
      public void IncluirAlterarTipoCertificado(ProfissionaisCertificadosTipoCertificado tipoCertificado)
      {
         var tipo = new ProfissionaisCertificadosTipoCertificadoBusiness().Obtem(tipoCertificado.Id);

         if (tipo == null)
         {
            new ProfissionaisCertificadosTipoCertificadoBusiness().Incluir(tipoCertificado);
         }
         else
         {
            new ProfissionaisCertificadosTipoCertificadoBusiness().Alterar(tipoCertificado);
         }
      }
      public void IncluirAlterarProfissional(ProfissionaisCertificadosProfissionais profissional)
      {
         try
         {
            var prof = new ProfissionaisCertificadosProfissionaisBusiness().Obtem(profissional.Id, profissional.Certificadora, profissional.TipoCertificado, profissional.DataAprovacao, profissional.NumeroCertificado);

            if (prof == null)
            {
               new ProfissionaisCertificadosProfissionaisBusiness().Incluir(profissional);
            }
            else
            {
               new ProfissionaisCertificadosProfissionaisBusiness().Alterar(profissional);
            }
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogErro(ex, string.Format("Falha ao Atualizar o Profissional Certificado CPF: {0} - Message: {1} - Stacktrace: {2}", profissional.Cpf, ex.Message, ex.StackTrace));
            throw new Exception(string.Format("Falha ao Atualizar o Profissional Certificado CPF: {0} - Message: {1} - Stacktrace: {2}", profissional.Cpf, ex.Message, ex.StackTrace));
         }
      }

      public List<ProfissionaisCertificadosProfissionais> ObterCertificados(long? cpf)
      {
         return new ProfissionaisCertificadosProfissionaisBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(ProfissionaisCertificadosProfissionais.METADADO.Cpf, Filter.Equal, cpf, Link.And).Add(ProfissionaisCertificadosProfissionais.METADADO.DataValidade, Filter.GreatherOrEqual, DateTime.Now.Date, Link.And));
      }
   }
}
