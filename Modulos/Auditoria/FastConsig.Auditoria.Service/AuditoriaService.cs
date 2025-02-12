using System;
using System.Collections.Generic;
using KellermanSoftware.CompareNetObjects;
using System.Linq;
using System.Xml.Serialization;
using FastConsig.Auditoria.Entity;
using Newtonsoft.Json;
using FastConsig.Auditoria.Business;
using Framework.Data;
using FastConsig.Common.Helpers;
using FastConsig.Auditoria.Model;
using FastConsig.Auditoria.Helpers;

namespace FastConsig.Auditoria.Service
{
   public class AuditoriaService
   {
      private static AuditoriaService _instance;

      public String Usuario { get; set; }

      private AuditoriaService()
      {
      }

      public static AuditoriaService GetInstance()
      {
         if (_instance == null)
            _instance = new AuditoriaService();

         return _instance;
      }

      public void CreateAuditTrail(AuditActionType Action, long? KeyFieldID, Object OldObject, Object NewObject, string usuario = null)
      {
         if (usuario != null)
         {
            this.Usuario = usuario;
         }

         // get the differance
         CompareLogic compObjects = new CompareLogic();
         compObjects.Config.MaxDifferences = 9999;
         compObjects.Config.IgnoreStringLeadingTrailingWhitespace = true;
         compObjects.Config.CompareChildren = true;
         ComparisonResult compResult = compObjects.Compare(OldObject, NewObject);
         List<AuditDelta> DeltaList = new List<AuditDelta>();
         foreach (var change in compResult.Differences)
         {
            AuditDelta delta = new AuditDelta();
            if (change.PropertyName.Substring(0, 1) == ".")
            {
               delta.FieldName = change.PropertyName.Substring(1, change.PropertyName.Length - 1);
            }
            else
               delta.FieldName = change.PropertyName;

            delta.ValueBefore = change.Object1Value;
            delta.ValueAfter = change.Object2Value;
            DeltaList.Add(delta);
         }
         AuditTable audit = new AuditTable();
         audit.AuditActionTypeENUM = (int)Action;
         audit.DataModel = NewObject.GetType().Name;
         audit.DateTimeStamp = DateTime.Now;
         audit.KeyFieldID = KeyFieldID;
         audit.ValueBefore = JsonConvert.SerializeObject(OldObject); // if use xml instead of json, can use xml annotation to describe field names etc better
         audit.ValueAfter = JsonConvert.SerializeObject(NewObject);
         audit.Changes = JsonConvert.SerializeObject(DeltaList);
         audit.Usuario = this.Usuario;

         new AuditTableBusiness().Incluir(audit);

      }

      public List<AuditChange> GetAudit(String DataModel, long? ID)
      {
         List<AuditChange> rslt = new List<AuditChange>();
         var AuditTrail = new AuditTableBusiness().Listar(WhereBuilder.Create().Add(AuditTable.METADADO.DataModel, Filter.Equal, DataModel, Link.And).Add(AuditTable.METADADO.KeyFieldID, Filter.Equal, ID)).OrderByDescending(x => x.DateTimeStamp);
         var serializer = new XmlSerializer(typeof(AuditDelta));
         foreach (var record in AuditTrail)
         {
            AuditChange Change = new AuditChange();
            Change.DateTimeStamp = record.DateTimeStamp.ToString();
            Change.AuditActionType = (AuditActionType)record.AuditActionTypeENUM;
            Change.AuditActionTypeName = Enum.GetName(typeof(AuditActionType), record.AuditActionTypeENUM);
            Change.Usuario = record.Usuario;
            Change.NomeUsuario = record.NomeUsuario;
            List<AuditDelta> delta = new List<AuditDelta>();
            delta = JsonConvert.DeserializeObject<List<AuditDelta>>(record.Changes);
            Change.Changes.AddRange(delta);
            rslt.Add(Change);
         }
         return rslt;
      }

      public string GetHtmlAudit(String DataModel, long? ID)
      {
         var AuditDisplay = "<table class=\"table table-striped table-bordered table-hover dataTables-historico-alteracoes\" id = \"tbHistoricoAlteracoes\" cellpadding ='3'>";
         var Audit = GetAudit(DataModel, ID).OrderByDescending(x => x.DateTimeStamp).ToList();

         foreach (AuditChange AuditTrail in Audit)
         {
            AuditDisplay = AuditDisplay + "<thead>";
            AuditDisplay = AuditDisplay + "<tr style=\"font-weight:bold; background-color: #2f4050 !important; color: #ffffff !important;\">";
            AuditDisplay = AuditDisplay + "<th><strong>Data do Evento: " + AuditTrail.DateTimeStamp + "</strong></th>";
            AuditDisplay = AuditDisplay + "<th><strong>Tipo da Ação: " + EnumHelper.GetEnumDescription(EnumHelper.ToEnum<AuditActionType>(AuditTrail.AuditActionTypeName)) + "</strong></th>";
            AuditDisplay = AuditDisplay + "<th><strong>Usuário: " + AuditTrail.NomeUsuario + "</strong></th></tr>";
            AuditDisplay = AuditDisplay + "<tr style=\"text-align: center; font-weight:bold;\">";
            AuditDisplay = AuditDisplay + "<th style=\"text-align: center !important;\"><strong>Campo</strong></th><th style=\"text-align: center !important;\"><strong>Antes da Alteração</strong></th><th style=\"text-align: center !important;\"><strong>Após a Alteração</strong></th></tr></thead><tbody>";

            if (AuditTrail.Changes.Count == 0)
            {
               AuditDisplay = AuditDisplay + "<tr class=\"gradeA odd\" role=\"row\">";
               AuditDisplay = AuditDisplay + "<td colspan=\"3\" style=\"text-align: center !important;\"><strong>Sem Alterações</strong></td>";
               AuditDisplay = AuditDisplay + "</tr>";
            }
            else
            {
               foreach (AuditDelta Changes in AuditTrail.Changes)
               {
                  AuditDisplay = AuditDisplay + "<tr  class=\"gradeA odd\" role=\"row\">";
                  AuditDisplay = AuditDisplay + "<td>" + Changes.FieldName + "</td>";
                  AuditDisplay = AuditDisplay + "<td>" + Changes.ValueBefore.Replace("(null)", "<strong>Não Preenchido ou em Branco</strong>") + "</td>";
                  AuditDisplay = AuditDisplay + "<td>" + Changes.ValueAfter + "</td>";
                  AuditDisplay = AuditDisplay + "</tr>";
               }
            }


         }
         AuditDisplay = AuditDisplay + "</tbody></table>";

         return AuditDisplay;
      }
   }
}
