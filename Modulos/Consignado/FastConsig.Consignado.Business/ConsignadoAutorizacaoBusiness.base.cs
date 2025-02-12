
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.Consignado.Entity;
using FastConsig.Consignado.Data;
#endregion

namespace FastConsig.Consignado.Business
{
	public partial class ConsignadoAutorizacaoBusiness : BusinessBase
	{
      public List<ConsignadoAutorizacao> ConsultarAutorizacaoCPF(long? cpf) => Listar(WhereBuilder.Create().Add(ConsignadoAutorizacao.METADADO.Cpf, Filter.Equal, cpf));

      public List<ConsignadoAutorizacao> ConsultarAutorizacao(long? cpf, int? codigoOrgao, int? codigoMatricula)
      {
         return Listar(WhereBuilder.Create()
            .Add(ConsignadoAutorizacao.METADADO.Cpf, Filter.Equal, cpf)
            .Add(ConsignadoAutorizacao.METADADO.CodigoOrgao, Filter.Equal, codigoOrgao)
            .Add(ConsignadoAutorizacao.METADADO.CodigoMatricula, Filter.Equal, codigoMatricula));
      }

      public ConsignadoAutorizacao ConsultarAutorizacao(int? id) => Listar(WhereBuilder.Create().Add(ConsignadoAutorizacao.METADADO.Id, Filter.Equal, id)).FirstOrDefault();

      #region Listar todos
      public virtual List<ConsignadoAutorizacao> Listar(WhereBuilder filtro)
		{
			ConsignadoAutorizacaoData objConsignadoAutorizacaoData = new ConsignadoAutorizacaoData();

			#region Regras de negócio
			#endregion

			return objConsignadoAutorizacaoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(ConsignadoAutorizacao obj)
		{
			ConsignadoAutorizacaoData objConsignadoAutorizacaoData = new ConsignadoAutorizacaoData();

			#region Regras de negócio
			#endregion

			objConsignadoAutorizacaoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(ConsignadoAutorizacao obj)
		{
			ConsignadoAutorizacaoData objConsignadoAutorizacaoData = new ConsignadoAutorizacaoData();

			#region Regras de negócio
			#endregion

			objConsignadoAutorizacaoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual ConsignadoAutorizacao Obtem(int? Id)
		{
			ConsignadoAutorizacaoData objConsignadoAutorizacaoData = new ConsignadoAutorizacaoData();

			#region Regras de negócio
			#endregion

			return objConsignadoAutorizacaoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			ConsignadoAutorizacaoData objConsignadoAutorizacaoData = new ConsignadoAutorizacaoData();

			#region Regras de negócio
			#endregion

			objConsignadoAutorizacaoData.Excluir(Id);
		}
		#endregion

	}
}
