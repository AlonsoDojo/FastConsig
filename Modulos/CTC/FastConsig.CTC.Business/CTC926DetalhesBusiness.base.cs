
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Data;
#endregion

namespace FastConsig.CTC.Business
{
	public partial class CTC926DetalhesBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTC926Detalhes> Listar(WhereBuilder filtro)
		{
			CTC926DetalhesData objCTC926DetalhesData = new CTC926DetalhesData();

			#region Regras de negócio
			#endregion

			return objCTC926DetalhesData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTC926Detalhes obj)
		{
			CTC926DetalhesData objCTC926DetalhesData = new CTC926DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC926DetalhesData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTC926Detalhes obj)
		{
			CTC926DetalhesData objCTC926DetalhesData = new CTC926DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC926DetalhesData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTC926Detalhes Obtem(int? Id)
		{
			CTC926DetalhesData objCTC926DetalhesData = new CTC926DetalhesData();

			#region Regras de negócio
			#endregion

			return objCTC926DetalhesData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_CTC926(int? CTC926)
		{
			CTC926DetalhesData objCTC926DetalhesData = new CTC926DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC926DetalhesData.ExcluirPor_CTC926(CTC926);
		}
		public void ExcluirPor_TipoArquivo(string TipoArquivo)
		{
			CTC926DetalhesData objCTC926DetalhesData = new CTC926DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC926DetalhesData.ExcluirPor_TipoArquivo(TipoArquivo);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTC926DetalhesData objCTC926DetalhesData = new CTC926DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC926DetalhesData.Excluir(Id);
		}
		#endregion

	}
}
