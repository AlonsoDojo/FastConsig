using DataTables.AspNet.Core;
using DataTables.AspNet.Mvc5;
using FastConsig.Common.Helpers;
using FastConsig.Core.Entity;
using FastConsig.Core.Model;
using FastConsig.Core.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace FastConsig.Core.Web.Controllers
{
    public class PropostaController : Controller
    {
      [System.Web.Http.AcceptVerbs("GET")]
      [System.Web.Http.Route("BuscaCEP/{cep}")]
      public dynamic BuscaCEP([FromUri] string cep)
      {
         if (String.IsNullOrWhiteSpace(cep))
         {
            return JsonConvert.SerializeObject(new Cep());
         }
         else
         {
            Cep retorno = PropostaService.GetInstance().ConsultarCEP(cep.Replace("-", ""));
            retorno.Bairro = retorno.Bairro.Trim();
            retorno.Localidade = retorno.Localidade.Trim();
            retorno.UF = retorno.UF.Trim();
            retorno.Logradouro = retorno.Logradouro.Trim();
            retorno.LogradouroAbreviado = retorno.LogradouroAbreviado.Trim();
            retorno.Complemento = retorno.Complemento.Trim();
            return JsonConvert.SerializeObject(retorno);
         }
      }

      public ActionResult ListarPropostas(IDataTablesRequest request)
      {
         MonitorFiltroModel filtro = ((MonitorFiltroModel)Session["__Filtro__"]);

         MonitorFiltroModel filtro2 = UtilityHelper.Clone(filtro);

         filtro2.Proposta = null;
         filtro2.Nome = null;
         filtro2.CPF = null;
         filtro2.Fase = null;
         filtro2.Status = null;
         filtro2.Contrato = null;
         filtro2.Produto = null;

         filtro2.Proposta = filtro.Proposta;
         filtro2.Contrato = filtro.Contrato;

         // Nothing important here. Just creates some mock data.
         List<ViewMonitor> data = PropostaService.GetInstance().ListarPropostasMonitor(filtro2).ToList();

         data = data.Where(_item => _item.FamiliaProduto != 7).ToList();

         // Global filtering.
         // Filter is being manually applied due to in-memmory (IEnumerable) data.
         // If you want something rather easier, check IEnumerableExtensions Sample.
         //var filteredData = data.Where(_item => _item.Name.Contains(request.Search.Value));

         List<ViewMonitor> filteredData = data;

         if (filtro.Proposta != null)
         {
            filteredData = filteredData.Where(_item => _item.Proposta == filtro.Proposta).ToList();
         }

         if (filtro.Nome != null)
         {
            filteredData = filteredData.Where(_item => _item.NomeProponente.ToUpper().Contains(filtro.Nome.ToUpper().Trim())).ToList();
         }


         if (filtro.CPF != null)
         {
            filteredData = filteredData.Where(_item => _item.CPFCNPJ?.Trim() == $"{filtro.CPF.Trim().Replace(".", "").Replace("-", "").Replace("/", ""):00000000000}").ToList();
         }


         if (filtro.Fase != null)
         {
            filteredData = filteredData.Where(_item => _item.Fase == filtro.Fase).ToList();
         }


         if (filtro.Status != null)
         {
            filteredData = filteredData.Where(_item => _item.Status == filtro.Status).ToList();
         }


         if (filtro.Contrato != null)
         {
            filteredData = filteredData.Where(_item => _item.ContratoLegado?.Trim() == filtro.Contrato.Trim()).ToList();
         }

         if (filtro.Produto != null)
         {
            filteredData = filteredData.Where(_item => _item.Produto == filtro.Produto).ToList();
         }

         // Paging filtered data.
         // Paging is rather manual due to in-memmory (IEnumerable) data.
         //var dataPage = filteredData.Skip(request.Start).Take(request.Length);

         var orderColums = request.Columns.Where(x => x.Sort != null);

         IColumn sortColumn = orderColums.FirstOrDefault();
         // Change first character to match column name
         //newField += sortColumn.Field.ToUpper().First() + string.Join("", sortColumn.Field.Skip(1));
         List<ViewMonitor> dataPage = new List<ViewMonitor>();
         if (sortColumn != null)
         {
            if (sortColumn.Sort.Direction == DataTables.AspNet.Core.SortDirection.Ascending)
            {
               dataPage = filteredData.OrderBy(o => o.GetType().GetProperty(sortColumn.Field).GetValue(o))
                   .Skip(request.Start)
                   .Take((request.Length == (int)-1 ? int.MaxValue : request.Length)).ToList();
            }
            else
            {
               dataPage = filteredData.OrderByDescending(o => o.GetType().GetProperty(sortColumn.Field).GetValue(o))
                   .Skip(request.Start)
                   .Take((request.Length == (int)-1 ? int.MaxValue : request.Length)).ToList();
            }
         }
         else
         {
            dataPage = filteredData.Skip(request.Start).Take(request.Length).ToList();
         }

         // Create some response additional parameters.
         var returnParameters = new Dictionary<string, object>()
            {
                { "rParam1", "First parameter" },
                { "rParam2", 2017 }
            };


         // Response creation. To create your response you need to reference your request, to avoid
         // request/response tampering and to ensure response will be correctly created.
         //var response = DataTablesResponse.Create(request, data.Count(), filteredData.Count(), dataPage);
         var response = DataTablesResponse.Create(request, data.Count(), filteredData.Count(), dataPage);

         // Easier way is to return a new 'DataTablesJsonResult', which will automatically convert your
         // response to a json-compatible content, so DataTables can read it when received.
         return new DataTablesJsonResult(response, JsonRequestBehavior.AllowGet);

      }
   }
}