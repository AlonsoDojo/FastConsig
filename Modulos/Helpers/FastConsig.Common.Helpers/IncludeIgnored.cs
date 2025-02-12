using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Common.Helpers
{
   public class IncludeIgnored : DefaultContractResolver
   {
      private readonly bool _includeIgnored;

      /// <summary>
      /// 
      /// </summary>
      /// <param name="includeIgnored"></param>
      public IncludeIgnored(bool includeIgnored) => _includeIgnored = includeIgnored;

      /// <summary>
      /// 
      /// </summary>
      /// <param name="type"></param>
      /// <param name="memberSerialization"></param>
      /// <returns></returns>
      protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
      {
         var properties = base.CreateProperties(type, memberSerialization);

         foreach (var item in properties)
            item.Ignored = !_includeIgnored;

         return properties;
      }
   }

}
