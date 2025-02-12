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
   public partial class ConfiguracaoBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<Configuracao> Listar(WhereBuilder filtro)
      {
         ConfiguracaoData objConfiguracaoData = new ConfiguracaoData();

         #region Regras de negócio
         #endregion

         return objConfiguracaoData.Listar(filtro);
      }
      #endregion

      #region Alterar
      public void Alterar(Configuracao obj)
      {
         ConfiguracaoData objConfiguracaoData = new ConfiguracaoData();

         #region Regras de negócio
         #endregion

         objConfiguracaoData.Alterar(obj);
      }
      #endregion

      #region Inserir
      public void Incluir(Configuracao obj)
      {
         ConfiguracaoData objConfiguracaoData = new ConfiguracaoData();

         #region Regras de negócio
         #endregion

         objConfiguracaoData.Incluir(obj);
      }
      #endregion

      #region Obtem
      public virtual Configuracao Obtem(string Chave)
      {
         ConfiguracaoData objConfiguracaoData = new ConfiguracaoData();

         #region Regras de negócio
         #endregion

         return objConfiguracaoData.Obtem(Chave);
      }
      #endregion

      #region Excluir por FKs
      #endregion

      #region Excluir por PK
      public void Excluir(string Chave)
      {
         ConfiguracaoData objConfiguracaoData = new ConfiguracaoData();

         #region Regras de negócio
         #endregion

         objConfiguracaoData.Excluir(Chave);
      }
      #endregion

   }
}
