using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace FastConsig.Common.Helpers
{
   public static class Extensions
   {
      /// <summary>
      /// Verifica se existe algum elemento na coleção.
      /// </summary>
      /// <typeparam name="T">Tipo de dado</typeparam>
      /// <param name="enumerable">Objeto a ser verificado.</param>
      /// <returns>True se não estiver nulo e com algum conteúdo.</returns>
      public static bool HasAny<T>(this IEnumerable<T> enumerable)
      {
         return enumerable?.Any() == true;
      }

      /// <summary>
      /// Verifica se a coleção está nula ou vazia.
      /// </summary>
      /// <typeparam name="T">Tipo de dado</typeparam>
      /// <param name="enumerable">Objeto a ser verificado.</param>
      /// <returns>True se estiver nula ou vazia.</returns>
      public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
      {
         return enumerable?.Any() != true;
      }

      public static bool IsNullOrDBNull(this object obj)
      {
         if (obj == null || obj.GetType() == typeof(DBNull))
            return true;
         else
            return false;
      }

      /// <summary>
      /// Verifica se value está presente na lista de values.
      /// </summary>
      /// <typeparam name="T">Objeto</typeparam>
      /// <param name="value">conteúdo</param>
      /// <param name="list">valores.</param>
      /// <returns></returns>
      public static bool In<T>(this T value, params T[] list)
      {
         return list?.Contains(value) == true;
      }

      /// <summary>
      /// Obtém os N últimos elementos da lista.
      /// </summary>
      /// <typeparam name="T">Tipo de elemento.</typeparam>
      /// <param name="source">Lista com os elementos.</param>
      /// <param name="N">Número de elementos a serem retornados</param>
      /// <returns></returns>
      /// <remarks> collection.TakeLast(5); </remarks>
      public static IEnumerable<T> TakeLast<T>(this IEnumerable<T> source, int N)
      {
         return source.Skip(Math.Max(0, source.Count() - N));
      }

      /// <summary>
      /// Retorna string com "..." caso tenha ultrapassado o limite de tamanho.
      /// </summary>
      /// <param name="value">String</param>
      /// <param name="maxChars">Máximo de caracteres.</param>
      /// <returns></returns>
      public static string Ellipses(this string value, int maxChars)
      {
         return value.Length <= maxChars ? value : value.Substring(0, maxChars) + "...";
      }

      public static decimal ToDecimal(this string value)
      {
         decimal number;
         if (value?.IndexOf("E+") > 0 || value?.IndexOf("e+") > 0)
         {
            try
            {
               number = Decimal.Parse(value, System.Globalization.NumberStyles.Any);
               return number;
            }
            catch { }
         }

         Decimal.TryParse(value, out number);
         return number;
      }

      public static DateTime? ToDateTimeOrNull(this string s)
      {
         var tryDtr = DateTime.TryParse(s, out DateTime dtr);
         return (tryDtr) ? dtr : (DateTime?)null;
      }

      public static int? ToIntOrNull(this String str)
      {
         var sucess = int.TryParse(str, out int number);
         return (sucess) ? number : (int?)null;
      }

      public static decimal? ToDecimalOrNull(this String str)
      {
         var sucess = decimal.TryParse(str, out decimal number);
         return (sucess) ? number : (decimal?)null;
      }

      public static decimal? ToDecimalorNull(this string value)
      {
         decimal number;
         if (value?.IndexOf("E+") > 0 || value?.IndexOf("e+") > 0)
         {
            try
            {
               number = Decimal.Parse(value, System.Globalization.NumberStyles.Any);
               return number;
            }
            catch { }
         }

         var sucess = Decimal.TryParse(value, out number);
         return (sucess) ? number : (decimal?)null;
      }


      public static long? ToLongOrNull(this String str)
      {
         var sucess = long.TryParse(str, out long number);
         return (sucess) ? number : (long?)null;
      }

      public static bool IsWeekday(this DayOfWeek dow)
      {
         switch (dow)
         {
            case DayOfWeek.Sunday:
            case DayOfWeek.Saturday:
               return false;

            default:
               return true;
         }
      }

      public static bool IsWeekend(this DayOfWeek dow)
      {
         return !dow.IsWeekday();
      }

      public static DateTime LastWorkdays(this DateTime startDate)
      {
         startDate = startDate.AddDays(-1);
         while (startDate.DayOfWeek.IsWeekend())
            startDate = startDate.AddDays(-1);

         return startDate;
      }

      public static DateTime FirstDayOfMonth(this DateTime dt)
      {
         return new DateTime(dt.Year, dt.Month, 1);
      }

      public static DateTime LastDayOfMonth(this DateTime dt)
      {
         return dt.FirstDayOfMonth().AddMonths(1).AddDays(-1);
      }

      /// <summary>
      /// Verifica se o texto é um e-mail válido.
      /// </summary>
      /// <param name="s"></param>
      /// <returns></returns>
      public static bool IsValidEmail(this string s) => IsValidEmail(s, false);

      /// <summary>
      /// Verifica se o texto é um e-mail válido.
      /// </summary>
      /// <param name="s"></param>
      /// <param name="multiplesMails"></param>
      /// <returns></returns>
      public static bool IsValidEmail(this string s, bool multiplesMails = false)
      {
         if (string.IsNullOrEmpty(s))
            return false;

         var regex = new Regex(multiplesMails ? @"^(|([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5}){1,25})+([;.](([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5}){1,25})+)*$" : @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");

         return regex.IsMatch(s);
      }

      /// <summary>
      /// Minify HTML string
      /// </summary>
      /// <param name="html"></param>
      /// <returns></returns>
      public static string MinifyHTML(this string html)
      {
         if (html == null)
            return html;

         html = Regex.Replace(html, @"(?<=\s)\s+(?![^<>]*</pre>)", String.Empty);
         html = Regex.Replace(html, "\n(?![^<]*</pre>)", String.Empty);
         return html.Trim();
      }

      /// <summary>
      /// Faz um DistinctBy "Coluna" nos elementos de um IEnumerable<typeparamref name="TEntity"/>
      /// </summary>
      /// <typeparam name="TEntity"></typeparam>
      /// <typeparam name="TProperty"></typeparam>
      /// <param name="source"></param>
      /// <param name="selectorColunm"></param>
      /// <returns></returns>
      public static IEnumerable<TEntity> DistinctBy<TEntity, TProperty>(this IEnumerable<TEntity> source, Func<TEntity, TProperty> selectorColunm)
      {
         return source.GroupBy(selectorColunm)
                      .Select(g => g.First());
      }

      /*
         Os métodos ToPivotTable e ToPivot convertem as linhas de lista ou DataTable em colunas, sendo que as 
         linhas devem ter um agrupador, tipo Produto.

         Lista de ENTRADA:
         Product     Year     Total
         P1          2009     100
         P2          2009     200
         P1          2010     150
         P2          2011     300
         P2          2012     400
         P3          2013     500

         Lista de SAIDA:
         Item        2009     2010     2011    2012    2013
         P1          100      150      0       0       0
         P2          200      0        400     0       0
         P3          0        0        0       0       500

          var pivotTable = data.ToPivotTable(item => item.Year,    <-- COLUNA
                                             item => item.Product, <-- LINHA 
                                             items => items.Any() ? items.Sum(x=>x.Sales) : 0); <-- Conteúdo da coluna
       */
      public static DataTable ToPivotTable<T, TColumn, TRow, TData>(this IEnumerable<T> source, Func<T, TColumn> columnSelector,
                                      Expression<Func<T, TRow>> rowSelector, Func<IEnumerable<T>, TData> dataSelector)
      {
         DataTable table = new DataTable();
         var rowName = ((MemberExpression)rowSelector.Body).Member.Name;
         table.Columns.Add(new DataColumn(rowName));
         var columns = source.Select(columnSelector).Distinct();

         foreach (var column in columns)
            table.Columns.Add(new DataColumn(column.ToString()));

         var rows = source.GroupBy(rowSelector.Compile())
                          .Select(rowGroup => new
                          {
                             Key = rowGroup.Key,
                             Values = columns.GroupJoin(
                                  rowGroup,
                                  c => c,
                                  r => columnSelector(r),
                                  (c, columnGroup) => dataSelector(columnGroup))
                          });

         foreach (var row in rows)
         {
            var dataRow = table.NewRow();
            var items = row.Values.Cast<object>().ToList();
            items.Insert(0, row.Key);
            dataRow.ItemArray = items.ToArray();
            table.Rows.Add(dataRow);
         }

         return table;
      }

      public static dynamic[] ToPivot<T, TColumn, TRow, TData>(this IEnumerable<T> source, Func<T, TColumn> columnSelector,
                              Expression<Func<T, TRow>> rowSelector, Func<IEnumerable<T>, TData> dataSelector)
      {
         var arr = new List<object>();
         var cols = new List<string>();
         String rowName = ((MemberExpression)rowSelector.Body).Member.Name;
         var columns = source.Select(columnSelector).Distinct();

         cols = (new[] { rowName }).Concat(columns.Select(x => x.ToString())).ToList();
         var rows = source.GroupBy(rowSelector.Compile())
                          .Select(rowGroup => new
                          {
                             Key = rowGroup.Key,
                             Values = columns.GroupJoin(
                                  rowGroup,
                                  c => c,
                                  r => columnSelector(r),
                                  (c, columnGroup) => dataSelector(columnGroup))
                          }).ToArray();


         foreach (var row in rows)
         {
            var items = row.Values.Cast<object>().ToList();
            items.Insert(0, row.Key);
            var obj = GetAnonymousObject(cols, items);
            arr.Add(obj);
         }
         return arr.ToArray();
      }

      private static dynamic GetAnonymousObject(IEnumerable<string> columns, IEnumerable<object> values)
      {
         IDictionary<string, object> eo = new ExpandoObject() as IDictionary<string, object>;
         int i;
         for (i = 0; i < columns.Count(); i++)
         {
            eo.Add(columns.ElementAt<string>(i), values.ElementAt<object>(i));
         }
         return eo;
      }

      public static string FormatCPF(string CPF)
      {
         return Convert.ToUInt64(CPF).ToString(@"000\.000\.000\-00");
      }

      public static string FormatCNPJ(string CNPJ)
      {
         return Convert.ToUInt64(CNPJ).ToString(@"00\.000\.000\/0000\-00");
      }

      public static string FormatCPFCNPJ(long cpjcnpj)
      {
         if (cpjcnpj.ToString().Length <= 11)
         {
            var cpfFormated = string.Format("00000000000{0}", cpjcnpj.ToString());
            cpfFormated = cpfFormated.ToString().Substring(cpfFormated.Length - 11, 11);
            return FormatCPF(cpfFormated);
         }
         else if (cpjcnpj.ToString().Length > 11)
         {
            var cpfFormated = string.Format("0000000000000{0}", cpjcnpj.ToString());
            cpfFormated = cpfFormated.ToString().Substring(cpfFormated.Length - 14, 14);
            return FormatCNPJ(cpfFormated);
         }
         return string.Empty;
      }

      /// <summary>   
      /// Valida se a string é Guid
      /// </summary>
      /// <param name="guidString"></param>
      /// <param name="guid"></param>
      /// <returns></returns>
      public static bool IsGuid(string value)
      {
         Guid x;
         return Guid.TryParse(value, out x);
      }

      /// <summary>
      /// Recupera até o terceiro nível de exception
      /// </summary>
      /// <param name="exception"></param>
      /// <returns></returns>
      public static string ExceptionToJson(Exception exception)
      {
         if (exception == null)
            return string.Empty;

         var error = new Dictionary<string, string>
                {
                    {"Type", exception.GetType().ToString()},
                    {"Message", exception.Message},
                    {"InnerException 1", exception.InnerException?.Message ?? string.Empty },
                    {"InnerException 2", exception.InnerException?.InnerException?.Message ?? string.Empty},
                    {"InnerException 3", exception.InnerException?.InnerException?.InnerException?.Message ?? string.Empty},
                    {"InnerException 4", exception.InnerException?.InnerException?.InnerException?.InnerException?.Message ?? string.Empty},
                    {"InnerException 5", exception.InnerException?.InnerException?.InnerException?.InnerException?.InnerException?.Message ?? string.Empty},
                    {"InnerException 6", exception.InnerException?.InnerException?.InnerException?.InnerException?.InnerException?.InnerException?.Message ?? string.Empty},
                    {"InnerException 7", exception.InnerException?.InnerException?.InnerException?.InnerException?.InnerException?.InnerException?.InnerException?.Message ?? string.Empty},
                    {"InnerException 8", exception.InnerException?.InnerException?.InnerException?.InnerException?.InnerException?.InnerException?.InnerException?.InnerException?.Message ?? string.Empty},
                    {"StackTrace", exception.StackTrace}
                };

         foreach (DictionaryEntry data in exception.Data) error.Add(data.Key.ToString(), data.Value.ToString());

         return JsonConvert.SerializeObject(error, Newtonsoft.Json.Formatting.Indented);
      }

      public static string CPFCNPJ2String(long? cpfcnpj)
      {
         if (UtilityHelper.IsCpf(UtilityHelper.ExtractNumber($"{cpfcnpj:00000000000}")))
         {
            var cpfFormated = string.Format("00000000000{0}", cpfcnpj.ToString());
            cpfFormated = cpfFormated.ToString().Substring(cpfFormated.Length - 11, 11);
            return cpfFormated;
         }
         else if (cpfcnpj == null)
         {
            return null;
         }
         else
         {
            var cpfFormated = string.Format("0000000000000{0}", cpfcnpj.ToString());
            cpfFormated = cpfFormated.ToString().Substring(cpfFormated.Length - 14, 14);
            return cpfFormated;
         }
      }

      public static string MaskAllButLast(this string input, int charsToDisplay, char maskingChar = '*')
      {
         if (input == null)
            return null;

         int charsToMask = input.Length - charsToDisplay;
         return charsToMask > 0 ? $"{new string(maskingChar, charsToMask)}{input.Substring(charsToMask)}" : input;
      }

      public static string FormatCC(string conta)
      {
         return Convert.ToUInt64(conta).ToString(@"###.###.###\-#");
      }

      public static string Right(this string value, int length)
      {
         return value.Substring(value.Length - length);
      }

      public static IEnumerable<T> OrEmptyIfNull<T>(this IEnumerable<T> source)
      {
         return source ?? Enumerable.Empty<T>();
      }

      public static string Base64Encode(string plainText)
      {
         var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
         return System.Convert.ToBase64String(plainTextBytes);
      }

      public static string Base64Decode(string base64EncodedData)
      {
         var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
         return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
      }

      public static DateTime AddWorkdays(this DateTime originalDate, int workDays, Func<DateTime, Boolean> isHoliday)
      {
         DateTime tmpDate = originalDate;

         if (workDays >= 0)
         {
            while (workDays > 0)
            {
               tmpDate = tmpDate.AddDays(1);
               if (tmpDate.DayOfWeek < DayOfWeek.Saturday && tmpDate.DayOfWeek > DayOfWeek.Sunday && /*!tmpDate.IsHoliday()*/ !isHoliday(tmpDate))
                  workDays--;
            }
         }
         else
         {
            while (workDays < 0)
            {
               tmpDate = tmpDate.AddDays(-1);
               if (tmpDate.DayOfWeek < DayOfWeek.Saturday && tmpDate.DayOfWeek > DayOfWeek.Sunday && /*!tmpDate.IsHoliday()*/ !isHoliday(tmpDate))
                  workDays++;
            }
         }

         return tmpDate;
      }

      public static DateTime AddWorkdays(this DateTime originalDate, int workDays)
      {
         DateTime tmpDate = originalDate;

         if (workDays >= 0)
         {
            while (workDays > 0)
            {
               tmpDate = tmpDate.AddDays(1);
               if (tmpDate.DayOfWeek < DayOfWeek.Saturday && tmpDate.DayOfWeek > DayOfWeek.Sunday && !tmpDate.IsHoliday())
                  workDays--;
            }
         }
         else
         {
            while (workDays < 0)
            {
               tmpDate = tmpDate.AddDays(-1);
               if (tmpDate.DayOfWeek < DayOfWeek.Saturday && tmpDate.DayOfWeek > DayOfWeek.Sunday && !tmpDate.IsHoliday())
                  workDays++;
            }
         }

         return tmpDate;
      }

      public static bool IsHoliday(this DateTime originalDate)
      {
         // INSERT YOUR HOlIDAY-CODE HERE!
         return false;
      }

      public static List<List<T>> ChunkBy<T>(this List<T> source, int chunkSize)
      {
         return source
             .Select((x, i) => new { Index = i, Value = x })
             .GroupBy(x => x.Index / chunkSize)
             .Select(x => x.Select(v => v.Value).ToList())
             .ToList();
      }

      public static string IsNullOrEmptyThenValue(this string str, string value)
      {
         if (string.IsNullOrEmpty(str))
            return value;
         else
            return str;
      }

      public enum NullOptions
      {
         ConvertDbNullsToNulls,
         ConvertAllNullsToEmpty
      }

      public static string ToString(this object obj, NullOptions nullOption)
      {
         bool isDbNull = false;
         bool isNull = false;

         if (obj.GetType() == typeof(DBNull))
            isDbNull = true;

         if (obj == null)
            isNull = true;

         if ((isNull || isDbNull) == false)
            return obj.ToString();

         if (nullOption == NullOptions.ConvertDbNullsToNulls)
         {
            return null;
         }
         else
         {
            return string.Empty;
         }
      }

      /// <summary>
      /// Proximo caracter do alfabeto
      /// </summary>
      /// <param name="initial"></param>
      /// <returns></returns>
      public static char NextCharacterAlphabet(char initial) => (char)((int)initial + 1);

      public static string Left(this string value, int maxLength)
      {
         if (string.IsNullOrEmpty(value)) return value;
         maxLength = Math.Abs(maxLength);

         return (value.Length <= maxLength
                ? value
                : value.Substring(0, maxLength)
                );
      }

      public static bool IsDate(this string dt)
      {
         return DateTime.TryParse(dt, out DateTime result);
      }

      public static List<int> ObterInteiros(string conteudo)
      {
         try
         {
            if (!string.IsNullOrWhiteSpace(conteudo))
            {
               string[] list = conteudo.Split(';');
               int[] result = Array.ConvertAll<string, int>(list, int.Parse);
               return result != null ? result.ToList() : new List<int>();
            }
         }
         catch (ArgumentNullException)
         { }

         return new List<int>();
      }
   }
}
