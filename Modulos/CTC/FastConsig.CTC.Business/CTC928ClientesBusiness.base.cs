
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
	public partial class CTC928ClientesBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTC928Clientes> Listar(WhereBuilder filtro)
		{
			CTC928ClientesData objCTC928ClientesData = new CTC928ClientesData();

			#region Regras de negócio
			#endregion

			return objCTC928ClientesData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTC928Clientes obj)
		{
			CTC928ClientesData objCTC928ClientesData = new CTC928ClientesData();

			#region Regras de negócio
			#endregion

			objCTC928ClientesData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTC928Clientes obj)
		{
			CTC928ClientesData objCTC928ClientesData = new CTC928ClientesData();

			#region Regras de negócio
			#endregion

			objCTC928ClientesData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTC928Clientes Obtem(int? Id)
		{
			CTC928ClientesData objCTC928ClientesData = new CTC928ClientesData();

			#region Regras de negócio
			#endregion

			return objCTC928ClientesData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Arquivo(int? Arquivo)
		{
			CTC928ClientesData objCTC928ClientesData = new CTC928ClientesData();

			#region Regras de negócio
			#endregion

			objCTC928ClientesData.ExcluirPor_Arquivo(Arquivo);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTC928ClientesData objCTC928ClientesData = new CTC928ClientesData();

			#region Regras de negócio
			#endregion

			objCTC928ClientesData.Excluir(Id);
		}
		#endregion

	}
}
