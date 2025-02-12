
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.ProfissionaisCertificados.Entity;
using FastConsig.ProfissionaisCertificados.Data;
#endregion

namespace FastConsig.ProfissionaisCertificados.Business
{
	public partial class ProfissionaisCertificadosProfissionaisBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<ProfissionaisCertificadosProfissionais> Listar(WhereBuilder filtro)
		{
			ProfissionaisCertificadosProfissionaisData objProfissionaisCertificadosProfissionaisData = new ProfissionaisCertificadosProfissionaisData();

			#region Regras de negócio
			#endregion

			return objProfissionaisCertificadosProfissionaisData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(ProfissionaisCertificadosProfissionais obj)
		{
			ProfissionaisCertificadosProfissionaisData objProfissionaisCertificadosProfissionaisData = new ProfissionaisCertificadosProfissionaisData();

			#region Regras de negócio
			#endregion

			objProfissionaisCertificadosProfissionaisData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(ProfissionaisCertificadosProfissionais obj)
		{
			ProfissionaisCertificadosProfissionaisData objProfissionaisCertificadosProfissionaisData = new ProfissionaisCertificadosProfissionaisData();

			#region Regras de negócio
			#endregion

			objProfissionaisCertificadosProfissionaisData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual ProfissionaisCertificadosProfissionais Obtem(long? Id, int? Certificadora, int? TipoCertificado, DateTime? DataAprovacao, string NumeroCertificado)
		{
			ProfissionaisCertificadosProfissionaisData objProfissionaisCertificadosProfissionaisData = new ProfissionaisCertificadosProfissionaisData();

			#region Regras de negócio
			#endregion

			return objProfissionaisCertificadosProfissionaisData.Obtem(Id, Certificadora, TipoCertificado, DataAprovacao, NumeroCertificado);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Certificadora(int? Certificadora)
		{
			ProfissionaisCertificadosProfissionaisData objProfissionaisCertificadosProfissionaisData = new ProfissionaisCertificadosProfissionaisData();

			#region Regras de negócio
			#endregion

			objProfissionaisCertificadosProfissionaisData.ExcluirPor_Certificadora(Certificadora);
		}
		public void ExcluirPor_TipoCertificado(int? TipoCertificado)
		{
			ProfissionaisCertificadosProfissionaisData objProfissionaisCertificadosProfissionaisData = new ProfissionaisCertificadosProfissionaisData();

			#region Regras de negócio
			#endregion

			objProfissionaisCertificadosProfissionaisData.ExcluirPor_TipoCertificado(TipoCertificado);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(long? Id, int? Certificadora, int? TipoCertificado, DateTime? DataAprovacao, string NumeroCertificado)
		{
			ProfissionaisCertificadosProfissionaisData objProfissionaisCertificadosProfissionaisData = new ProfissionaisCertificadosProfissionaisData();

			#region Regras de negócio
			#endregion

			objProfissionaisCertificadosProfissionaisData.Excluir(Id, Certificadora, TipoCertificado, DataAprovacao, NumeroCertificado);
		}
		#endregion

	}
}
