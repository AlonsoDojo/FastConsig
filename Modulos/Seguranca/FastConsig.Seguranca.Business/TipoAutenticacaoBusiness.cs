using FastConsig.Seguranca.Data;
using FastConsig.Seguranca.Entity;
using Framework.Data;
using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Seguranca.Business
{
   public partial class TipoAutenticacaoBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<TipoAutenticacao> Listar(WhereBuilder filtro)
      {
         TipoAutenticacaoData objTipoAutenticacaoData = new TipoAutenticacaoData();

         #region Regras de negócio
         #endregion

         return objTipoAutenticacaoData.Listar(filtro);
      }
      #endregion

      #region Alterar
      public void Alterar(TipoAutenticacao obj)
      {
         TipoAutenticacaoData objTipoAutenticacaoData = new TipoAutenticacaoData();

         #region Regras de negócio
         #endregion

         objTipoAutenticacaoData.Alterar(obj);
      }
      #endregion

      #region Inserir
      public void Incluir(TipoAutenticacao obj)
      {
         TipoAutenticacaoData objTipoAutenticacaoData = new TipoAutenticacaoData();

         #region Regras de negócio
         #endregion

         objTipoAutenticacaoData.Incluir(obj);
      }
      #endregion

      #region Obtem
      public virtual TipoAutenticacao Obtem(int? Id)
      {
         TipoAutenticacaoData objTipoAutenticacaoData = new TipoAutenticacaoData();

         #region Regras de negócio
         #endregion

         return objTipoAutenticacaoData.Obtem(Id);
      }
      #endregion

      #region Excluir por FKs
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
      {
         TipoAutenticacaoData objTipoAutenticacaoData = new TipoAutenticacaoData();

         #region Regras de negócio
         #endregion

         objTipoAutenticacaoData.Excluir(Id);
      }
      #endregion

   }
}
