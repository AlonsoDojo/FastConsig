
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.Core.Entity;
using FastConsig.Core.Data;
#endregion

namespace FastConsig.Core.Business
{
	public partial class LojasBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<Lojas> Listar(WhereBuilder filtro)
		{
			LojasData objLojasData = new LojasData();

			#region Regras de negócio
			#endregion

			return objLojasData.Listar(filtro);
		}

      public virtual List<Lojas> ListarLojasRede(int? redeLojas, int? loja)
      {
         LojasData objLojasData = new LojasData();

         WhereBuilder where = WhereBuilder.Create().Add(Lojas.METADADO.RedeLoja, Filter.Equal, redeLojas, Link.And).Add(Lojas.METADADO.Loja, Filter.Equal, loja);

         #region Regras de negócio
         #endregion

         return objLojasData.Listar(where);
      }

      #endregion

      #region Alterar
      public void Alterar(Lojas obj)
		{
			LojasData objLojasData = new LojasData();

			#region Regras de negócio
			#endregion

			objLojasData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(Lojas obj)
		{
			LojasData objLojasData = new LojasData();

			#region Regras de negócio
			#endregion

			objLojasData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual Lojas Obtem(int? Id)
		{
			LojasData objLojasData = new LojasData();

			#region Regras de negócio
			#endregion

			return objLojasData.Obtem(Id);
		}
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_RedeLoja(int? RedeLoja)
		{
			LojasData objLojasData = new LojasData();

			#region Regras de negócio
			#endregion

			objLojasData.ExcluirPor_RedeLoja(RedeLoja);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			LojasData objLojasData = new LojasData();

			#region Regras de negócio
			#endregion

			objLojasData.Excluir(Id);
		}
		#endregion

	}
}
