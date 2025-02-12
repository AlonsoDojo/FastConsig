using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml;

namespace FastConsig.Common.Helpers
{
   public static class XMLUtility<T> where T : class
   {
      public static string Serialize(T obj)
      {
         XmlSerializer xsSubmit = new XmlSerializer(typeof(T));
         using (var sww = new StringWriter())
         {
            using (XmlTextWriter writer = new XmlTextWriter(sww) { Formatting = Formatting.Indented })
            {
               xsSubmit.Serialize(writer, obj);
               return sww.ToString().Replace("utf-16", "utf-16BE");
            }
         }
      }

#pragma warning disable CS0693 // Type parameter has the same name as the type parameter from outer type
      public static T Deserialize<T>(string filepath) where T : class
#pragma warning restore CS0693 // Type parameter has the same name as the type parameter from outer type
      {
         System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

         using (StreamReader sr = new StreamReader(filepath))
         {
            return (T)ser.Deserialize(sr);
         }
      }

#pragma warning disable CS0693 // Type parameter has the same name as the type parameter from outer type
      public static T Deserialize<T>(StringReader filepath) where T : class
#pragma warning restore CS0693 // Type parameter has the same name as the type parameter from outer type
      {
         System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

         return (T)ser.Deserialize(filepath);
      }
#pragma warning disable CS0693 // Type parameter has the same name as the type parameter from outer type
      public static T Deserialize<T>(StreamReader sr) where T : class
#pragma warning restore CS0693 // Type parameter has the same name as the type parameter from outer type
      {
         System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

         return (T)ser.Deserialize(sr);
      }

      public static bool Validade(string xml, string xsd, out string mensagem)
      {
         var path = AppDomain.CurrentDomain.BaseDirectory;
         var rnd = new Random(1000).Next();
         var arquivo = "Temp_" + rnd;

         //XmlSchemaSet schema = new XmlSchemaSet();
         //schema.Add("", xsd);
         //XmlReader rd = XmlReader.Create(xml);
         //XDocument doc = XDocument.Load(rd);
         //try
         //{
         //   doc.Validate(schema, ValidationEventHandler);
         //   erro = null;
         //   return true;
         //}
         //catch (Exception ex)
         //{
         //   erro = ex.Message;
         //   return false;
         //}
         ValidationUtils @class = new ValidationUtils();
         if (xml != null && xsd != null)
         {
            @class.xmlPath = path + "\\Tmp\\" + arquivo + ".xml";
            @class.xsdPath = path + "\\XSD\\" + xsd + ".xsd";

            using (var s = File.Create(@class.xmlPath))
            {
               using (var sw = new StreamWriter(s, new UnicodeEncoding(true, false)))
               {
                  sw.Write(xml);
               }

            }

            //using (var s = File.Create(@class.xsdPath))
            //{
            //	using (var sw = new StreamWriter(s, Encoding.GetEncoding(1200)))
            //	{
            //		sw.Write(xsd);
            //	}

            //}

            if (!File.Exists(@class.xmlPath))
            {
               //Console.WriteLine("xml file not found!");
            }
            if (!File.Exists(@class.xsdPath))
            {
               //Console.WriteLine("xsd file not found!");
            }
         }
         new List<string>();
         if (@class.OpenXmlFileUtils(@class.xmlPath))
         {
            @class.ValidateXMLUtils(@class.xsdPath, 0);
            if (@class.validationResultStr != null)
            {
               if (!@class.validationResultStr.Contains("Success!"))
               {
                  string searchTerm = "PATH";
                  string[] array = @class.validationResultStr.Split(new char[]
                  {
                     '\n'
                  }, StringSplitOptions.RemoveEmptyEntries);
                  IEnumerable<string> source = from word in array
                                               where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
                                               select word;
                  source.Count<string>();
                  char c = '-';
                  array.Count<string>();
                  List<string> list = new List<string>();
                  try
                  {
                     string[] array2 = array;
                     for (int i = 0; i < array2.Length; i++)
                     {
                        string text = array2[i];
                        string[] array3 = text.Split(new char[]
                        {
                           c
                        });
                        if (!text.Contains("PATH"))
                        {
                           if (array3[0] != null)
                           {
                              string text2 = array3[0].Replace("' attribute is invalid", "");
                              text2 = text2.Replace("The '", "");
                              list.Add(text2);
                           }
                           if (array3 != null)
                           {
                           }
                           if (array3 != null)
                           {
                           }
                        }
                     }
                     //Console.ForegroundColor = ConsoleColor.Red;
                     //Console.WriteLine("Validation fails!!");
                     //Console.WriteLine("Total item failed count : " + @class.validationCalledCount.ToString(), "INFO");
                     //Console.WriteLine();
                     //Console.WriteLine("Failed items :");
                     //Console.BackgroundColor = ConsoleColor.White;
                     //foreach (string current in list)
                     //{
                     //	Console.WriteLine(current);
                     //}
                     //Console.ResetColor();
                     //Console.WriteLine();
                     //Console.WriteLine("Total item pass count : " + (@class.elemCount - @class.validationCalledCount).ToString(), "INFO");
                  }
                  catch (Exception ex)
                  {
                     ex.ToString();
                  }
               }
               //Console.Write(@class.validationResultStr);

               File.Delete(@class.xmlPath);

               if (@class.validationResultStr.Contains("Success!"))
               {
                  mensagem = @class.validationResultStr;
                  return true;
               }
               else
               {
                  mensagem = @class.validationResultStr;
                  return false;
               }
            }
            //Console.Write("\n");


         }

         mensagem = @class.validationResultStr;
         return true;
      }

      static void ValidationEventHandler(object sender, ValidationEventArgs e)
      {
         XmlSeverityType type = XmlSeverityType.Warning;
         if (Enum.TryParse<XmlSeverityType>("Error", out type))
         {
            if (type == XmlSeverityType.Error) throw new Exception(e.Message);
         }
      }

   }

   public class ValidationUtils
   {
      private TreeView tvSchema;

      public bool bResult;

      public string xmlPath;

      public string xsdPath;

      public string tempBuf;

      public string validationResultStr;

      public XmlNode xmlnode_s;

      public static string stStrXmlPath;

      public string selectedElmPath;

      private int nErrors = 0;

      private string strErrorMsg = string.Empty;

      public string elmType = "";

      public string comments = "";

      public string restrict = "";

      private XmlReader xmlValidatingReader = null;

      private XmlReader reader = null;

      public System.Collections.Generic.List<string> errorPathOfElement = new System.Collections.Generic.List<string>();

      public static string sfailedElmPath;

      public static System.Collections.Generic.Dictionary<string, string> dict = null;

      public static Stack<string> elements = new Stack<string>();

      private XmlReaderSettings readerSettings = new XmlReaderSettings();

      public XmlDocument xmlDoc = new XmlDocument();

      public int validationCalledCount = 0;

      public int elemCount = 0;

      public ValidationUtils()
      {
         this.bResult = false;
         this.comments = "";
         this.xmlPath = ValidationUtils.stStrXmlPath;
         ValidationUtils.dict = new System.Collections.Generic.Dictionary<string, string>();
         this.tvSchema = new TreeView();
      }

      public bool OpenXmlFileUtils(string xml_path)
      {
         if (this.xmlPath != xml_path)
         {
            this.xmlPath = xml_path;
         }
         try
         {
            this.reader = XmlReader.Create(xml_path, this.readerSettings);
            this.xmlDoc.Load(xml_path);
            this.CloseXmlFile(this.reader);
            this.bResult = true;
         }
         catch (System.Exception)
         {
            this.bResult = false;
         }
         return this.bResult;
      }

      public string XsdParserUtils(string paths, int pos, string pathxsds)
      {
         char[] separator = new char[]
         {
            '\\'
         };
         string[] array = paths.Split(separator);
         int i;
         for (i = 0; i <= array.Length - 1; i++)
         {
         }
         string text = array[i - 1];
         string text2 = array[i - 2];
         string text3 = null;
         XNamespace ns = XNamespace.Get("http://www.w3.org/2001/XMLSchema");
         string result;
         if (pathxsds == null)
         {
            result = null;
         }
         else
         {
            XDocument xDocument = XDocument.Load(pathxsds);
            System.Collections.Generic.IEnumerable<XElement> enumerable = from row in xDocument.Descendants(ns + "element")
                                                                          select row;
            System.Collections.Generic.IEnumerable<XElement> enumerable2 = from row_s in xDocument.Descendants(ns + "simpleType")
                                                                           select row_s;
            if (this.comments == "")
            {
               foreach (XElement current in enumerable2)
               {
                  if (current.Attribute("name") != null && current.Attribute("name").Value == text3)
                  {
                     this.comments = current.Value;
                     System.Collections.Generic.IEnumerable<XElement> source = from a in current.Descendants(ns + "restriction")
                                                                               select a;
                     this.restrict = source.Min<XElement>().ToString();
                     if (this.restrict != "")
                     {
                        string[] array2 = this.restrict.Split(new char[]
                        {
                           ' '
                        });
                        array2[1] = array2[1].Replace("base=\"xs:", "");
                        array2[1] = array2[1].Replace("\"", "");
                        result = array2[1];
                        return result;
                     }
                  }
               }
            }
            result = text3;
         }
         return result;
      }

      public void ValidateXMLUtils(string testString, int iCount)
      {
         this.nErrors = 0;
         try
         {
            XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
            xmlReaderSettings.ValidationType = ValidationType.Schema;
            xmlReaderSettings.ValidationFlags |= (XmlSchemaValidationFlags.ProcessSchemaLocation | XmlSchemaValidationFlags.ReportValidationWarnings);
            xmlReaderSettings.ValidationEventHandler += new ValidationEventHandler(this.ValidationEventHandlerUtils);
            xmlReaderSettings.Schemas.Add(null, XmlReader.Create(testString));
            this.xmlValidatingReader = XmlReader.Create(this.xmlPath, xmlReaderSettings);
            if (this.validationResultStr != "")
            {
               this.validationResultStr = "";
            }
            try
            {
               while (this.xmlValidatingReader.Read())
               {
                  if (this.xmlValidatingReader.NodeType == XmlNodeType.Element)
                  {
                     ValidationUtils.elements.Push(this.xmlValidatingReader.LocalName);
                     this.elemCount++;
                  }
                  if (this.xmlValidatingReader.NodeType == XmlNodeType.EndElement)
                  {
                     try
                     {
                        ValidationUtils.elements.Pop();
                     }
                     catch
                     {
                     }
                  }
               }
            }
            catch (System.Exception ex)
            {
               string text = ex.ToString();
            }
            if (this.nErrors > 0)
            {
               if (this.validationResultStr.Contains("invalid child element"))
               {
                  this.validationResultStr = "ERROR:XSD";
               }
               throw new System.Exception(this.strErrorMsg);
            }
            this.validationResultStr = "Success!";
         }
         catch (System.Exception ex2)
         {
            ex2.ToString();
         }
         if (this.xmlValidatingReader != null)
         {
            this.xmlValidatingReader.Close();
         }
      }

      private void ValidationEventHandlerUtils(object sender, ValidationEventArgs e)
      {
         this.validationCalledCount++;
         if (e.Severity == XmlSeverityType.Warning)
         {
            this.validationResultStr = e.Message;
         }
         else if (e.Severity == XmlSeverityType.Error)
         {
            ValidationUtils.sfailedElmPath = "";
            foreach (string current in ValidationUtils.elements)
            {
               ValidationUtils.sfailedElmPath = "/" + current + ValidationUtils.sfailedElmPath;
            }
            this.errorPathOfElement.Add(ValidationUtils.sfailedElmPath);
            this.validationResultStr = string.Concat(new string[]
            {
               this.validationResultStr,
               e.Message,
               "\nPATH : ",
               ValidationUtils.sfailedElmPath,
               "\n"
            });
            System.Collections.Generic.List<string> list = this.errorPathOfElement.Distinct<string>().ToList<string>();
            this.errorPathOfElement = list;
            this.nErrors++;
         }
      }

      public bool CloseXmlFile(XmlReader rdr)
      {
         try
         {
            rdr.Close();
            this.bResult = true;
         }
         catch (System.Exception ex)
         {
            System.Console.WriteLine("File close exception!" + ex.Message);
            this.bResult = false;
         }
         return this.bResult;
      }
   }
}
