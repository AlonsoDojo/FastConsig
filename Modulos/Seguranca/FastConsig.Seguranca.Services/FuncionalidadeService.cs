using FastConsig.Common.Helpers;
using FastConsig.Seguranca.Business;
using FastConsig.Seguranca.Entity;
using Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FastConsig.Seguranca.Services
{
   public class FuncionalidadeService
   {
      /// <summary>Instância do serviço de funcionalidades.</summary>
      private static FuncionalidadeService _instance;

      private FuncionalidadeService()
      {
      }

      /// <summary>
      /// Obtém a instância do serviço de Funcionalidades.
      /// </summary>
      /// <returns></returns>
      public static FuncionalidadeService GetInstance()
      {
         if (_instance == null)
            _instance = new FuncionalidadeService();

         return _instance;
      }

      #region *------- Funcionalidades -------*

      /// <summary>
      /// Lista todas as funcionalidades disponíveis do sistema.
      /// </summary>
      /// <returns></returns>
      public List<Funcionalidade> Listar()
      {
         return new FuncionalidadeBusiness().Listar(null);
      }

      /// <summary>
      /// Lista todas as funcionalidades disponíveis do sistema.
      /// </summary>
      /// <returns></returns>
      public List<Funcionalidade> ListarPorSistema()
      {
         return new FuncionalidadeBusiness().Listar(null);
      }

      /// <summary>
      /// Obtém as informações de uma determinada funcionalidades do sistema.
      /// </summary>
      /// <returns></returns>
      public Funcionalidade Obter(int? idFuncionalidade)
      {
         return new FuncionalidadeBusiness().Obtem(idFuncionalidade);
      }

      /// <summary>
      /// Exclui a funcionalidades do sistema.
      /// </summary>
      /// <returns></returns>
      public void Excluir(int? idFuncionalidade)
      {
         new FuncionalidadeBusiness().Excluir(idFuncionalidade);
      }

      /// <summary>
      /// Inclui a funcionalidades do sistema.
      /// </summary>
      /// <returns></returns>
      public void Incluir(Funcionalidade funcionalidade)
      {
         new FuncionalidadeBusiness().Incluir(funcionalidade);
      }

      /// <summary>
      /// Altera a funcionalidades do sistema.
      /// </summary>
      /// <returns></returns>
      public void Alterar(Funcionalidade funcionalidade)
      {
         new FuncionalidadeBusiness().Alterar(funcionalidade);
      }

      #endregion

      #region *------- Grupo de funcionalidades -------*

      /// <summary>
      /// Lista todas os grupos de funcionalidades disponíveis do sistema.
      /// </summary>
      /// <returns></returns>
      public List<GrupoFuncionalidade> ListarGrupos()
      {
         return new GrupoFuncionalidadeBusiness().Listar(null);
      }

      /// <summary>
      /// Lista todas os grupos de funcionalidades disponíveis do sistema.
      /// </summary>
      /// <returns></returns>
      public List<GrupoFuncionalidade> ListarGrupos(string sistemaId)
      {
         return new GrupoFuncionalidadeBusiness().Listar(null);
      }

      /// <summary>
      /// Obtém as informações de um determinado grupo de funcionalidades do sistema.
      /// </summary>
      /// <returns></returns>
      public GrupoFuncionalidade ObterGrupo(int? idGrupoFuncionalidade)
      {
         return new GrupoFuncionalidadeBusiness().Obtem(idGrupoFuncionalidade);
      }

      /// <summary>
      /// Exclui o grupo de funcionalidades do sistema.
      /// </summary>
      /// <returns></returns>
      public void ExcluirGrupo(int? idGrupoFuncionalidade)
      {
         new GrupoFuncionalidadeBusiness().Excluir(idGrupoFuncionalidade);
      }

      /// <summary>
      /// Inclui um grupo de funcionalidades do sistema.
      /// </summary>
      /// <returns></returns>
      public void Incluir(GrupoFuncionalidade grupo)
      {
         new GrupoFuncionalidadeBusiness().Incluir(grupo);
      }

      /// <summary>
      /// Altera a funcionalidades do sistema.
      /// </summary>
      /// <returns></returns>
      public void Alterar(GrupoFuncionalidade grupo)
      {
         new GrupoFuncionalidadeBusiness().Alterar(grupo);
      }

      #endregion

      #region *------- ViewPerfilFuncionalidade -------*

      public List<ViewPerfilFuncionalidade> ListarPerfilFuncionalidades(int? idPerfil)
      {
         return new ViewPerfilFuncionalidadeBusiness().Listar(idPerfil.Value);
      }

      #endregion

      #region *------- Eventos Funcionalidade -------*

      public List<EventoFuncionalidade> ListarEventoFuncionalidade(int idFuncionalidade)
      {
         WhereBuilder filtro = WhereBuilder.Create();
         filtro.Add(EventoFuncionalidade.METADADO.IdFuncionalidade, Filter.Equal, idFuncionalidade);

         return new EventoFuncionalidadeBusiness().Listar(filtro);

      }

      public List<ViewPerfilEventoFuncionalidade> ListarEventoPerfilFuncionalidade(int funcionalidadeId, int perfilId)
      {
         WhereBuilder filtro = WhereBuilder.Create();

         filtro.Add(ViewPerfilEventoFuncionalidade.METADADO.IdFuncionalidade, Filter.Equal, funcionalidadeId)
               .Add(ViewPerfilEventoFuncionalidade.METADADO.IdPerfil, Filter.Equal, perfilId);

         return new ViewPerfilEventoFuncionalidadeBusiness().Listar(filtro);

      }

      public EventoFuncionalidade ObterEventoFuncionalidade(int? id)
      {
         return new EventoFuncionalidadeBusiness().Obtem(id);
      }

      public void ExcluirEventoFuncionalidade(int? id)
      {
         TransactionHelper.Run(TransactionScopeOption.Required, () =>
         {
            new PerfilEventoFuncionalidadeBusiness().ExcluirPor_IdEventoFuncionalidade(id);
            new EventoFuncionalidadeBusiness().Excluir(id);

         });
      }

      public void SalvarEventoFuncionalidade(EventoFuncionalidade model)
      {
         if (model.Id.HasValue)
            new EventoFuncionalidadeBusiness().Alterar(model);
         else
            new EventoFuncionalidadeBusiness().Incluir(model);
      }


      #endregion
   }
}
