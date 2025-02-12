using FastConsig.Seguranca.Entity;
using FastConsig.Seguranca.Business;
using System.Collections.Generic;

namespace FastConsig.Seguranca.Services
{
   public class DominioService
   {
      private static DominioService _instance;

      private DominioService()
      {

      }

      public static DominioService GetInstance() => _instance ?? (_instance = new DominioService());

      public List<Dominio> Listar() => new DominioBusiness().Listar(null);

      public void Alterar(Dominio dominio) => new DominioBusiness().Alterar(dominio);

      public void Incluir(Dominio dominio) => new DominioBusiness().Incluir(dominio);

      public Dominio Obter(int? Id) => new DominioBusiness().Obtem(Id);

      public void Excluir(int? Id) => new DominioBusiness().Excluir(Id);

      public List<TipoAutenticacao> ObterTipoAutenticacao() => new TipoAutenticacaoBusiness().Listar(null);
   }
}
