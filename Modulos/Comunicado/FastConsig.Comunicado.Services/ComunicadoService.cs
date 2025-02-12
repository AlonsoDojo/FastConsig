using FastConsig.Comunicado.Business;
using FastConsig.Comunicado.Entity;
using FastConsig.Comunicado.Services.Exceptions;
using FastConsig.Comunicado.Services.Validators;
using FastConsig.Seguranca.Entity;
using Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Comunicado.Services
{
   public class ComunicadoService
   {
      #region "Instância"
      private static ComunicadoService _instance;
      private ComunicadoService()
      {

      }
      public static ComunicadoService GetInstance()
      {
         if (_instance == null)
            _instance = new ComunicadoService();

         return _instance;
      }
      #endregion

      public List<Comunicados> ListarComunicados()
      {
         return new ComunicadosBusiness().ListarComunicados(null);
      }

      public List<ViewComunicados> ListarComunicadosUsuario(string usuario)
      {
         return new ViewComunicadosBusiness().Listar(WhereBuilder.Create().Add(ViewComunicados.METADADO.Usuario, Filter.Equal, usuario));
      }

      public void ExcluirComunicado(int? id)
      {
         new ComunicadosArquivosBusiness().ExcluirPor_Comunicado(id);
         new ComunicadosBusiness().Excluir(id);
      }

      public void SalvarComunicado(Comunicados comunicado)
      {
         if (comunicado.Id == null || comunicado.Id == 0)
         {
            new ComunicadosBusiness().Incluir(comunicado);
         } else
         {
            new ComunicadosBusiness().Alterar(comunicado);
         }
      }

      public long? SalvarComunicado(Comunicados comunicado, Usuario usuario, ComunicadosArquivos comunicadoArquivo = null)
      {
         if (comunicado == null)
            throw new Exception("Comunicado não pode ser nulo!");

         if (comunicadoArquivo != null && !comunicadoArquivo.Comunicado.HasValue)
            throw new ComunicadoException("Para anexar um arquivo é necessário antes salvar o comunicado.");

         comunicado.PaginaPrincipal = "N";

         if (comunicado.Id == null)
         {
            comunicado.Usuario = usuario.Id;
            comunicado.DataCriacao = DateTime.Now;
            comunicado.Publicado = false;
         }
         else
         {
            comunicado.UsuarioAlteracao = usuario.Id;
            comunicado.DataAlteracao = DateTime.Now;
         }

         try
         {
            // validação do modelo
            var validate = new ComunicadoValidator().Validate(comunicado);

            if (!validate.IsValid)
               throw new ComunicadoException(String.Join("\r", validate.Errors.Select(c => c.ErrorMessage)));

            if (comunicadoArquivo != null)
               IncluirArquivoComunicado(comunicadoArquivo);

            if (comunicado.Id == null)
               new ComunicadosBusiness().Incluir(comunicado);
            else
               new ComunicadosBusiness().Alterar(comunicado);
         }
         catch (ComunicadoException ex)
         {
            throw ex;
         }
         catch (Exception ex)
         {
            throw new Exception("Não foi possível validar o modelo!", ex);
         }

         return comunicado.Id;
      }

      public Comunicados ObtemComunicado(int? id)
      {
         return new ComunicadosBusiness().Obtem(id);
      }

      public List<ComunicadosStatus> ListarStatus()
      {
         return new ComunicadosStatusBusiness().Listar(null);
      }

      public List<ComunicadosArquivos> ListarArquivos(int? comunicado)
      {
         return new ComunicadosArquivosBusiness().Listar(WhereBuilder.Create().Add(ComunicadosArquivos.METADADO.Comunicado, Filter.Equal, comunicado));
      }

      protected void IncluirArquivoComunicado(ComunicadosArquivos obj)
      {
         new ComunicadosArquivosBusiness().Incluir(obj);
      }

      public ComunicadosArquivos ObtemArquivoComunicado(int? id) => new ComunicadosArquivosBusiness().Obtem(id);

      public void ExcluirArquivoComunicado(int? id) => new ComunicadosArquivosBusiness().Excluir(id);

      public void Publicar(int? id, string usuario)
      {
         var comunicado = ObtemComunicado(id);

         comunicado.Publicado = true;
         comunicado.DataPublicacao = DateTime.Now;
         comunicado.UsuarioPublicador = usuario;

         new ComunicadosBusiness().Alterar(comunicado);
      }

      public void DesativarPublicacao(int? id, string usuario)
      {
         var comunicado = ObtemComunicado(id);

         comunicado.Publicado = false;
         comunicado.DataDesativacao = DateTime.Now;
         comunicado.UsuarioDesativacao = usuario;

         new ComunicadosBusiness().Alterar(comunicado);
      }

      public Comunicados ObtemComunicado(int? id, string login)
      {
         try
         {
            var comunicado = new ComunicadosBusiness().Obtem(id);

            GravarConfirmacaoLeitura(id, login);

            return comunicado;
         }
         catch (Exception ex)
         {
            throw new Exception("Erro ao tentar gerar obter comunicado para ser visualizado pelo usuário.", ex);
         }
      }

      protected void GravarConfirmacaoLeitura(int? id, string login)
      {
         try
         {
            var confirmacaoAnterior = new ComunicadosConfirmacaoLeituraBusiness().Listar(WhereBuilder.Create().Add(ComunicadosConfirmacaoLeitura.METADADO.Comunicado, Filter.Equal, id, Link.And).Add(ComunicadosConfirmacaoLeitura.METADADO.Usuario, Filter.Equal, login, Link.And));

            if (confirmacaoAnterior.Count == 0)
            {
               new ComunicadosConfirmacaoLeituraBusiness().Incluir(new ComunicadosConfirmacaoLeitura { Comunicado = id, Usuario = login, DataLeitura = DateTime.Now });
            }

         }
         catch (Exception ex)
         {
            throw new Exception("Erro ao tentar gerar confirmação de leitura.", ex);
         }
      }
   }
}
