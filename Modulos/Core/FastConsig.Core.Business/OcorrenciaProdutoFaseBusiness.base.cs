
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
	public partial class OcorrenciaProdutoFaseBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<OcorrenciaProdutoFase> Listar(WhereBuilder filtro)
		{
			OcorrenciaProdutoFaseData objOcorrenciaProdutoFaseData = new OcorrenciaProdutoFaseData();

			#region Regras de negócio
			#endregion

			return objOcorrenciaProdutoFaseData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(OcorrenciaProdutoFase obj)
		{
			OcorrenciaProdutoFaseData objOcorrenciaProdutoFaseData = new OcorrenciaProdutoFaseData();

			#region Regras de negócio
			#endregion

			objOcorrenciaProdutoFaseData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(OcorrenciaProdutoFase obj)
		{
			OcorrenciaProdutoFaseData objOcorrenciaProdutoFaseData = new OcorrenciaProdutoFaseData();

			#region Regras de negócio
			#endregion

			objOcorrenciaProdutoFaseData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual OcorrenciaProdutoFase Obtem(int? Id)
		{
			OcorrenciaProdutoFaseData objOcorrenciaProdutoFaseData = new OcorrenciaProdutoFaseData();

			#region Regras de negócio
			#endregion

			return objOcorrenciaProdutoFaseData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Ocorrencia(int? Ocorrencia)
		{
			OcorrenciaProdutoFaseData objOcorrenciaProdutoFaseData = new OcorrenciaProdutoFaseData();

			#region Regras de negócio
			#endregion

			objOcorrenciaProdutoFaseData.ExcluirPor_Ocorrencia(Ocorrencia);
		}
		public void ExcluirPor_Produto(int? Produto)
		{
			OcorrenciaProdutoFaseData objOcorrenciaProdutoFaseData = new OcorrenciaProdutoFaseData();

			#region Regras de negócio
			#endregion

			objOcorrenciaProdutoFaseData.ExcluirPor_Produto(Produto);
		}
		public void ExcluirPor_Fase(int? Fase)
		{
			OcorrenciaProdutoFaseData objOcorrenciaProdutoFaseData = new OcorrenciaProdutoFaseData();

			#region Regras de negócio
			#endregion

			objOcorrenciaProdutoFaseData.ExcluirPor_Fase(Fase);
		}
		public void ExcluirPor_FaseDestino(int? FaseDestino)
		{
			OcorrenciaProdutoFaseData objOcorrenciaProdutoFaseData = new OcorrenciaProdutoFaseData();

			#region Regras de negócio
			#endregion

			objOcorrenciaProdutoFaseData.ExcluirPor_FaseDestino(FaseDestino);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			OcorrenciaProdutoFaseData objOcorrenciaProdutoFaseData = new OcorrenciaProdutoFaseData();

			#region Regras de negócio
			#endregion

			objOcorrenciaProdutoFaseData.Excluir(Id);
		}
		#endregion

	}
}
