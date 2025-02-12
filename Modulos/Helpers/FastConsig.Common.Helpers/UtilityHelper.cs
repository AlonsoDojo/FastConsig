using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.UI;
using ObjectsComparer;

namespace FastConsig.Common.Helpers
{
   public static class UtilityHelper
   {
      private static readonly object locker = new object();

      /// <summary>
      /// Remove acentos da string
      /// </summary>
      /// <param name="text"></param>
      /// <returns></returns>
      public static string RemoverDiacritics(string text)
      {
         if (string.IsNullOrEmpty(text))
            return text;

         return string.Concat(text.Normalize(NormalizationForm.FormD)
                 .Where(ch => CharUnicodeInfo.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark))
                 .Normalize(NormalizationForm.FormC);
      }

      /// <summary>
      /// Copia o objeto, criando uma nova instância do objeto.
      /// </summary>
      /// <typeparam name="T"></typeparam>
      /// <param name="obj"></param>
      /// <returns></returns>
      public static T Clone<T>(T obj)
      {
         using (var ms = new MemoryStream())
         {
            var formatter = new BinaryFormatter();
            lock (locker)
            {
               formatter.Serialize(ms, obj);
            }
            ms.Position = 0;
            return (T)formatter.Deserialize(ms);
         }
      }

      /// <summary>
      /// Serializa um objeto em string (Base64).
      /// </summary>
      /// <typeparam name="T"></typeparam>
      /// <param name="obj"></param>
      /// <returns></returns>
      public static string SerializeData<T>(T obj)
      {
         using (var ms = new MemoryStream())
         {
            var formatter = new BinaryFormatter();
            lock (locker)
            {
               formatter.Serialize(ms, obj);
            }
            ms.Position = 0;
            return Convert.ToBase64String(ms.GetBuffer());
         }
      }

      /// <summary>
      /// Deserializa um objeto em Base64.
      /// </summary>
      /// <typeparam name="T"></typeparam>
      /// <param name="objData"></param>
      /// <returns></returns>
      public static T DeserializeData<T>(string objData)
      {
         var bytes = Convert.FromBase64String(objData);
         using (var ms = new MemoryStream(bytes))
         {
            ms.Position = 0;
            return (T)new BinaryFormatter().Deserialize(ms);
         }
      }

      /// <summary>
      /// Obtém o valor da propriedade
      /// </summary>
      /// <param name="src">Objeto que contém a propriedade</param>
      /// <param name="propName">Nome da propriedade</param>
      /// <returns></returns>
      public static object GetPropertyValue(object src, string propName)
      {
         if (src == null) throw new Exception(string.Format("Value cannot be null {0} - {1}", src, propName));
         if (propName == null) throw new Exception(string.Format("Value cannot be null {0}", propName));

         if (propName.Contains("."))//complex type nested
         {
            var temp = propName.Split(new char[] { '.' }, 2);
            return GetPropertyValue(GetPropertyValue(src, temp[0]), temp[1]);
         }
         else
         {
            var prop = src.GetType().GetProperty(propName);
            return prop != null ? prop.GetValue(src, null) : null;
         }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="value"></param>
      /// <param name="type"></param>
      /// <returns></returns>
      public static object ConvertList(List<object> value, Type type)
      {
         var containedType = type.GenericTypeArguments.First();
         return value.Select(item => Convert.ChangeType(item, containedType)).ToList();
      }

      public static bool IsValidEmail(string email)
      {
         try
         {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
         }
         catch
         {
            return false;
         }
      }

      public static bool IsCnpj(string cnpj)
      {
         int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
         int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
         int soma;
         int resto;
         string digito;
         string tempCnpj;
         cnpj = cnpj.Trim();
         cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
         if (cnpj.Length != 14)
            return false;
         tempCnpj = cnpj.Substring(0, 12);
         soma = 0;
         for (int i = 0; i < 12; i++)
            soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
         resto = (soma % 11);
         if (resto < 2)
            resto = 0;
         else
            resto = 11 - resto;
         digito = resto.ToString();
         tempCnpj = tempCnpj + digito;
         soma = 0;
         for (int i = 0; i < 13; i++)
            soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
         resto = (soma % 11);
         if (resto < 2)
            resto = 0;
         else
            resto = 11 - resto;
         digito = digito + resto.ToString();
         return cnpj.EndsWith(digito);
      }

      public static bool IsCpf(string cpf)
      {
         int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
         int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
         string tempCpf;
         string digito;
         int soma;
         int resto;
         cpf = cpf.Trim();
         cpf = cpf.Replace(".", "").Replace("-", "");
         if (cpf.Length != 11)
            return false;
         tempCpf = cpf.Substring(0, 9);
         soma = 0;

         for (int i = 0; i < 9; i++)
            soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
         resto = soma % 11;
         if (resto < 2)
            resto = 0;
         else
            resto = 11 - resto;
         digito = resto.ToString();
         tempCpf = tempCpf + digito;
         soma = 0;
         for (int i = 0; i < 10; i++)
            soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
         resto = soma % 11;
         if (resto < 2)
            resto = 0;
         else
            resto = 11 - resto;
         digito = digito + resto.ToString();
         return cpf.EndsWith(digito);
      }

      public static string ExtractNumber(string original)
      {
         if (string.IsNullOrEmpty(original))
            return string.Empty;

         return new string(original.Where(c => Char.IsDigit(c)).ToArray());
      }

      /// <summary>
      /// Pega a descrição do atributo de um enum
      /// </summary>
      /// <param name="value"></param>
      /// <returns></returns>
      public static string GetEnumDescription(Enum value)
      {
         FieldInfo fi = value.GetType().GetField(value.ToString());
         DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

         if (attributes.Length > 0)
            return attributes[0].Description;
         else
            return value.ToString();
      }

      /// <summary>
      /// Responsável por buscar todos os controles com o tipo informado.
      /// </summary>
      /// <typeparam name="T"></typeparam>
      public static void GetControlList<T>(ControlCollection controlCollection, List<T> resultCollection) where T : Control
      {
         foreach (Control control in controlCollection)
         {
            if (control is T) // This is cleaner    
               resultCollection.Add((T)control);

            if (control.HasControls())
               GetControlList(control.Controls, resultCollection);
         }
      }

      /// <summary>
      /// Update only the changes that are different.
      /// </summary>
      /// <param name="target"></param>
      /// <param name="source"></param>
      public static void CopyIfDifferent(Object target, Object source)
      {
         foreach (var prop in target.GetType().GetProperties())
         {
            var targetValue = GetPropValue(target, prop.Name);
            var sourceValue = GetPropValue(source, prop.Name);

            if (targetValue == null || sourceValue == null)
               continue;

            if (!targetValue.Equals(sourceValue))
               SetPropertyValue(target, prop.Name, sourceValue);
         }
      }

      public static void CopyIfDifferentAndNull(Object target, Object source)
      {
         foreach (var prop in target.GetType().GetProperties())
         {
            var targetValue = GetPropValue(target, prop.Name);
            var sourceValue = GetPropValue(source, prop.Name);

            if (targetValue == null || sourceValue == null)
               continue;

            if (!targetValue.Equals(sourceValue) && targetValue == null)
               SetPropertyValue(target, prop.Name, sourceValue);
         }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="src"></param>
      /// <param name="propName"></param>
      /// <returns></returns>
      internal static object GetPropValue(object src, string propName) => src.GetType().GetProperty(propName).GetValue(src, null);

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <param name="propName"></param>
      /// <param name="value"></param>
      internal static void SetPropertyValue(object obj, string propName, object value) => obj.GetType().GetProperty(propName).SetValue(obj, value, null);

      public static String toCron(string mins, string hrs, string dayOfMonth, string month, string dayOfWeek, string year)
      {
         return String.Format("%s %s %s %s %s %s", mins, hrs, dayOfMonth, month, dayOfWeek, year);
      }

      public static T GetEnumValueFromDescription<T>(string description)
      {
         var type = typeof(T);
         if (!type.IsEnum)
            throw new ArgumentException();
         FieldInfo[] fields = type.GetFields();
         var field = fields
                         .SelectMany(f => f.GetCustomAttributes(
                             typeof(DescriptionAttribute), false), (
                                 f, a) => new { Field = f, Att = a })
                         .Where(a => ((DescriptionAttribute)a.Att)
                             .Description == description).SingleOrDefault();
         return field == null ? default(T) : (T)field.Field.GetRawConstantValue();
      }

      public static string GetDescription<T>(this T enumValue) where T : struct, IConvertible
      {
         if (!typeof(T).IsEnum)
            return null;

         var description = enumValue.ToString();
         var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

         if (fieldInfo != null)
         {
            var attrs = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), true);
            if (attrs != null && attrs.Length > 0)
            {
               description = ((DescriptionAttribute)attrs[0]).Description;
            }
         }

         return description;
      }

      public static string hideEmail(string email)
      {
         string input = email;
         string pattern = @"(?<=[\w]{1})[\w-\._\+%]*(?=[\w]{1}@)";
         string result = Regex.Replace(input, pattern, m => new string('*', m.Length));
         return result;
      }

      public static string ComputeSha256Hash(string rawData)
      {
         // Create a SHA256   
         using (SHA256 sha256Hash = SHA256.Create())
         {
            // ComputeHash - returns byte array  
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

            // Convert byte array to a string   
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < bytes.Length; i++)
               builder.Append(bytes[i].ToString("x2"));

            return builder.ToString();
         }
      }

      public static Byte[] Html2PDF(string html)
      {
         string caminho = AppDomain.CurrentDomain.BaseDirectory;
         var psi = new System.Diagnostics.ProcessStartInfo();
         var p = new System.Diagnostics.Process();

         psi.UseShellExecute = true;
         psi.FileName = caminho + "GeradorPDF\\wkhtmltopdf.exe";
         psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
         psi.ErrorDialog = true;

         var g = Guid.NewGuid().ToString();

         File.WriteAllText(caminho + "GeradorPDF\\Temp\\" + g + ".html", html, Encoding.Default);

         psi.Arguments = caminho + "GeradorPDF\\Temp\\" + g + ".html " + caminho + "GeradorPDF\\Temp\\" + g + ".pdf";

         p = System.Diagnostics.Process.Start(psi);
         p.WaitForExit();

         var retorno = File.ReadAllBytes(caminho + "GeradorPDF\\Temp\\" + g + ".pdf");

         File.Delete(caminho + "GeradorPDF\\Temp\\" + g + ".pdf");
         File.Delete(caminho + "GeradorPDF\\Temp\\" + g + ".html");

         return retorno;
      }

      public static List<string> GetChangedProperties<T>(object A, object B)
      {
         if (A != null && B != null)
         {
            var type = typeof(T);
            var allProperties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var allSimpleProperties = allProperties.Where(pi => pi.PropertyType.IsSimpleType());
            var unequalProperties =
                   from pi in allSimpleProperties
                   let AValue = type.GetProperty(pi.Name).GetValue(A, null)
                   let BValue = type.GetProperty(pi.Name).GetValue(B, null)
                   where AValue != BValue && (AValue == null || !AValue.Equals(BValue))
                   select pi.Name;
            return unequalProperties.ToList();
         }
         else
         {
            throw new ArgumentNullException("You need to provide 2 non-null objects");
         }
      }

      public static bool IsSimpleType(this Type type)
      {
         if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
         {
            return type.GetGenericArguments()[0].IsSimpleType();
         }
         return type.IsPrimitive
           || type.IsEnum
           || type.Equals(typeof(string))
           || type.Equals(typeof(decimal));
      }

      public static StringBuilder BuscarPropriedades(object o, int lvl, int maxLvl)
      {
         var b = new StringBuilder();
         ReadALotOfValues(b, o, 0, 10);
         return b;
      }

      private static void ReadALotOfValues(StringBuilder b, object o, int lvl, int maxLvl)
      {
         if (o == null)
            return;

         Type t = o.GetType();



         List<PropertyInfo> l = new List<PropertyInfo>();
         while (t != typeof(object))
         {
            l.AddRange(t.GetProperties());
            t = t.BaseType;
         }
         foreach (var item in l)
         {
            if (item.CanRead && item.GetIndexParameters().Length == 0)
            {
               object child = item.GetValue(o, null);
               b.AppendFormat("{0}{1} = {2}\n", new string(' ', 4 * lvl), item.Name, child);
               if (lvl < maxLvl)
                  ReadALotOfValues(b, child, lvl + 1, maxLvl);
            }
         }
      }

      public static IEnumerable<Difference> CompareObjects<T>(object a1, object a2)
      {
         var comparer = new ObjectsComparer.Comparer<T>();
         IEnumerable<Difference> differences;
         var isEqual = comparer.Compare((T)a1, (T)a2, out differences);

         return differences;
      }

      public static string RemoveSpecialCharacters(this string str)
      {
         StringBuilder sb = new StringBuilder();
         foreach (char c in str)
         {
            if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
            {
               sb.Append(c);
            }
         }
         return sb.ToString();
      }

      public static string OnlyNumbers(this string str)
      {
         StringBuilder sb = new StringBuilder();
         foreach (char c in str)
         {
            if ((c >= '0' && c <= '9'))
            {
               sb.Append(c);
            }
         }
         return sb.ToString();
      }

      public static string[] SplitString(string input, int lineLen)
      {
         StringBuilder sb = new StringBuilder();
         string[] words = input.Split(' ');
         string line = string.Empty;
         string sp = string.Empty;
         foreach (string w in words)
         {
            string word = w;
            while (word != string.Empty)
            {
               if (line == string.Empty)
               {
                  while (word.Length >= lineLen)
                  {
                     sb.Append(word.Substring(0, lineLen) + "~");
                     word = word.Substring(lineLen);
                  }
                  if (word != string.Empty)
                     line = word;
                  word = string.Empty;
                  sp = " ";
               }
               else if (line.Length + word.Length <= lineLen)
               {
                  line += sp + word;
                  sp = " ";
                  word = string.Empty;
               }
               else
               {
                  sb.Append(line + "~");
                  line = string.Empty;
                  sp = string.Empty;
               }
            }
         }
         if (line != string.Empty)
            sb.Append(line);
         return sb.ToString().Split('~');
      }

      public static string RemoveAccents(this string text)
      {
         StringBuilder sbReturn = new StringBuilder();
         var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
         foreach (char letter in arrayText)
         {
            if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
               sbReturn.Append(letter);
         }
         return sbReturn.ToString();
      }

      public static byte[] ToByteArray(this Image imageIn)
      {
         var ms = new MemoryStream();
         imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
         return ms.ToArray();
      }

      public static Image ToImage(this byte[] data)
      {
         var ic = new ImageConverter();
         var img = (Image)ic.ConvertFrom(data);
         return img;
      }

      public static string GetAlphabet(int index)
      {
         List<string> letras = new List<string>() { "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "U", "V", "W", "X", "Y", "Z" };

         return letras[index].ToString();
      }
   }
}
