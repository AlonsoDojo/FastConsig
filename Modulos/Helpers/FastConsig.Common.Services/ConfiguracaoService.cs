using FastConsig.Seguranca.Business;
using FastConsig.Seguranca.Entity;
using FastConsig.Common.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Common.Services
{
   public class ConfiguracaoService
   {
      #region *------- Propriedades para controle da lista de configurações (CACHE) -------*

      private static int _timeoutCacheConfigInMinutes = -1;

      private DateTime _lastConfigUpdate;

      private List<Configuracao> _configuracoes = null;

      #endregion

      private object _lock = new object();

      private static ConfiguracaoService _instance;

      private ConfiguracaoService()
      {
      }

      public static ConfiguracaoService GetInstance()
      {
         return _instance ?? (_instance = new ConfiguracaoService());
      }

      public List<Configuracao> Listar()
      {
         return new ConfiguracaoBusiness().Listar(null);
      }

      public Configuracao Obter(string chave)
      {
         return new ConfiguracaoBusiness().Obtem(chave);
      }

      public void Excluir(string chave)
      {
         new ConfiguracaoBusiness().Excluir(chave);
      }

      public void Salvar(Configuracao config)
      {
         if (config == null)
            return;

         var configBiz = new ConfiguracaoBusiness();

         config.Chave = config.Chave?.Trim();
         var configDb = configBiz.Obtem(config.Chave);
         if (configDb != null)
         {
            configBiz.Alterar(config);
         }
         else
         {
            configBiz.Incluir(config);
         }
      }

      public void Salvar(List<Configuracao> configs)
      {
         if (configs == null)
            return;

         TransactionHelper.Run(System.Transactions.TransactionScopeOption.Required, () =>
         {
            foreach (var item in configs)
            {
               new ConfiguracaoBusiness().Alterar(item);
            }

         });

         lock (_lock)
         {
            _configuracoes = Listar();
            _lastConfigUpdate = DateTime.Now.AddMinutes(_timeoutCacheConfigInMinutes);
         }
      }

      public T Config<T>(string chave)
      {
         return Config(chave, default(T));
      }

      public T Config<T>(string chave, T valorDefault)
      {
         if (_configuracoes.IsNullOrEmpty() || _lastConfigUpdate < DateTime.Now)
         {
            lock (_lock)
            {
               _configuracoes = Listar();
            }

            if (_configuracoes.HasAny())
            {
               var timeoutConfig = new Configuracao { Conteudo = "" };
               if (!string.IsNullOrEmpty(timeoutConfig?.Conteudo?.Trim()))
               {
                  if (!int.TryParse(timeoutConfig.Conteudo.Trim(), out _timeoutCacheConfigInMinutes))
                     _timeoutCacheConfigInMinutes = 0; 
               }
            }
            _lastConfigUpdate = DateTime.Now.AddMinutes(_timeoutCacheConfigInMinutes);
         }

         var config = _configuracoes.Find(c => c.Chave.Equals(chave, StringComparison.InvariantCultureIgnoreCase));
         if (config == null || string.IsNullOrEmpty(config.Conteudo?.Trim()))
            return valorDefault;

         var tc = TypeDescriptor.GetConverter(typeof(T));
         if (tc.CanConvertFrom(config.Conteudo.GetType()))
            return (T)tc.ConvertFrom(config.Conteudo);

         tc = TypeDescriptor.GetConverter(config.Conteudo.GetType());
         if (tc.CanConvertTo(typeof(T)))
            return (T)tc.ConvertTo(config.Conteudo, typeof(T));

         throw new NotSupportedException();
      }
   }
}
