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
   public partial class UsuarioProdutoBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<UsuarioProduto> Listar(WhereBuilder filtro)
      {
         UsuarioProdutoData objUsuarioProdutoData = new UsuarioProdutoData();

         #region Regras de negócio
         #endregion

         return objUsuarioProdutoData.Listar(filtro);
      }
      #endregion

      #region Alterar
      public void Alterar(UsuarioProduto obj)
      {
         UsuarioProdutoData objUsuarioProdutoData = new UsuarioProdutoData();

         #region Regras de negócio
         #endregion

         objUsuarioProdutoData.Alterar(obj);
      }
      #endregion

      #region Inserir
      public void Incluir(UsuarioProduto obj)
      {
         UsuarioProdutoData objUsuarioProdutoData = new UsuarioProdutoData();

         #region Regras de negócio
         #endregion

         objUsuarioProdutoData.Incluir(obj);
      }
      #endregion

      #region Obtem
      public virtual UsuarioProduto Obtem(int? Id)
      {
         UsuarioProdutoData objUsuarioProdutoData = new UsuarioProdutoData();

         #region Regras de negócio
         #endregion

         return objUsuarioProdutoData.Obtem(Id);
      }
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_Usuario(string Usuario)
      {
         UsuarioProdutoData objUsuarioProdutoData = new UsuarioProdutoData();

         #region Regras de negócio
         #endregion

         objUsuarioProdutoData.ExcluirPor_Usuario(Usuario);
      }
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
      {
         UsuarioProdutoData objUsuarioProdutoData = new UsuarioProdutoData();

         #region Regras de negócio
         #endregion

         objUsuarioProdutoData.Excluir(Id);
      }
      #endregion

   }
}
