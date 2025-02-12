
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
	public partial class MotivoRecusaBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<MotivoRecusa> Listar(WhereBuilder filtro)
		{
			MotivoRecusaData objMotivoRecusaData = new MotivoRecusaData();

			#region Regras de negócio
			#endregion

			return objMotivoRecusaData.Listar(filtro);
		}
		#endregion

		#region Inserir
		public void Incluir(MotivoRecusa obj)
		{
			MotivoRecusaData objMotivoRecusaData = new MotivoRecusaData();

			#region Regras de negócio
			#endregion

			objMotivoRecusaData.Incluir(obj);
		}
      #endregion

      #region Alterar
      public void Alterar(MotivoRecusa obj)
      {
         MotivoRecusaData objMotivoRecusaData = new MotivoRecusaData();

         #region Regras de negócio
         #endregion

         objMotivoRecusaData.Alterar(obj);
      }
      #endregion

      #region Obtem
      public virtual MotivoRecusa Obtem(int? Id)
		{
			MotivoRecusaData objMotivoRecusaData = new MotivoRecusaData();

			#region Regras de negócio
			#endregion

			return objMotivoRecusaData.Obtem(Id);
		}
      #endregion

      #region Excluir
      public virtual void Excluir(int? Id)
      {
         MotivoRecusaData objMotivoRecusaData = new MotivoRecusaData();

         #region Regras de negócio
         #endregion

         objMotivoRecusaData.Excluir(Id);
      }
      #endregion
   }
}
