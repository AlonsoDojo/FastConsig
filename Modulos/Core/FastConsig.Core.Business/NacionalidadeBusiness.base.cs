
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
	public partial class NacionalidadeBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<Nacionalidade> Listar(WhereBuilder filtro)
		{
			NacionalidadeData objNacionalidadeData = new NacionalidadeData();

			#region Regras de negócio
			#endregion

			return objNacionalidadeData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(Nacionalidade obj)
		{
			NacionalidadeData objNacionalidadeData = new NacionalidadeData();

			#region Regras de negócio
			#endregion

			objNacionalidadeData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(Nacionalidade obj)
		{
			NacionalidadeData objNacionalidadeData = new NacionalidadeData();

			#region Regras de negócio
			#endregion

			objNacionalidadeData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual Nacionalidade Obtem(int? Id)
		{
			NacionalidadeData objNacionalidadeData = new NacionalidadeData();

			#region Regras de negócio
			#endregion

			return objNacionalidadeData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			NacionalidadeData objNacionalidadeData = new NacionalidadeData();

			#region Regras de negócio
			#endregion

			objNacionalidadeData.Excluir(Id);
		}
		#endregion

	}
}
