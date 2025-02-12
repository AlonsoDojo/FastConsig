
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
	public partial class AutorizacaoDigitalConsignadoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<AutorizacaoDigitalConsignado> Listar(WhereBuilder filtro)
		{
			AutorizacaoDigitalConsignadoData objAutorizacaoDigitalConsignadoData = new AutorizacaoDigitalConsignadoData();

			#region Regras de negócio
			#endregion

			return objAutorizacaoDigitalConsignadoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(AutorizacaoDigitalConsignado obj)
		{
			AutorizacaoDigitalConsignadoData objAutorizacaoDigitalConsignadoData = new AutorizacaoDigitalConsignadoData();

			#region Regras de negócio
			#endregion

			objAutorizacaoDigitalConsignadoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(AutorizacaoDigitalConsignado obj)
		{
			AutorizacaoDigitalConsignadoData objAutorizacaoDigitalConsignadoData = new AutorizacaoDigitalConsignadoData();

			#region Regras de negócio
			#endregion

			objAutorizacaoDigitalConsignadoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual AutorizacaoDigitalConsignado Obtem(int? Id)
		{
			AutorizacaoDigitalConsignadoData objAutorizacaoDigitalConsignadoData = new AutorizacaoDigitalConsignadoData();

			#region Regras de negócio
			#endregion

			return objAutorizacaoDigitalConsignadoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			AutorizacaoDigitalConsignadoData objAutorizacaoDigitalConsignadoData = new AutorizacaoDigitalConsignadoData();

			#region Regras de negócio
			#endregion

			objAutorizacaoDigitalConsignadoData.Excluir(Id);
		}
		#endregion

	}
}
