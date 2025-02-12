using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Common.Helpers
{
   public class CryptoHelper
   {
      // String para geração de hash das senhas...
      private const string CSalt = "R2lyb3N5c3RlbUx1aWdpODIyNCFHaXVsaWE4MjI0IUVsdmlyYUJhcmJpZXJpR2lyb01vYWNpckdpcm9FbGlhbmVHaXJv";


      #region *------- Geração de senha para acesso de clientes e usuários no sistema -------*

      // Provider para gerar números aleatórios...
      private readonly RNGCryptoServiceProvider _rand = new RNGCryptoServiceProvider();

      /// <summary>
      /// Geração da senha do cliente codificada.
      /// </summary>
      /// <param name="clearPassword">Senha a ser codificada</param>
      /// <returns>Senha codificada.</returns>
      public static string GenerateHashPassword(string clearPassword)
      {
         MD5 md5 = MD5CryptoServiceProvider.Create();

         string salt = null;
         if (clearPassword.Length > CSalt.Length)
         {
            salt = CSalt;
         }
         else
         {
            salt = CSalt.Substring(1, clearPassword.Length);
         }

         var clearBuffer = Encoding.Default.GetBytes(salt + clearPassword);
         var hashBuffer = md5.ComputeHash(clearBuffer);
         string hashPassword = Convert.ToBase64String(hashBuffer);

         return hashPassword;
      }

      /// <summary>
      /// Gera uma senha utilizando os caracteres mínimos de segurança exigidos na aplicação.
      /// </summary>
      /// <param name="minimo">Tamanho mínimo da senha</param>
      /// <param name="maximo">Tamanho máximo da senha</param>
      /// <returns>Nova senha gerada</returns>
      public string RandomPassword(int minimo, int maximo)
      {
         const string LOWER = "abcdefghijklmnopqrstuvwxyz";
         const string UPPER = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
         const string NUMBER = "0123456789";
         const string SPECIAL = "!@#$%&*[]?-"; //Limita os caracteres especiais para facilitar a vida do cliente na identificação

         string permitidos = "";

         permitidos = LOWER + UPPER + NUMBER + SPECIAL;

         // Gera a lista de caracteres permitidos...
         //string permitidos = LOWER + UPPER + NUMBER + SPECIAL;

         //Gera o múmero máximo de caracteres desta senha...
         int num_chars = RandomInteger(minimo, maximo);

         //*------- Para garantir os requisitos mínimos de senha...
         string novaSenha = RandomChar(LOWER);
         novaSenha += RandomChar(UPPER);
         novaSenha += RandomChar(NUMBER);
         novaSenha += RandomChar(SPECIAL);

         //*------- Acrescenta os demais caracteres até completar o tamanho máximo...
         while (novaSenha.Length < num_chars)
            novaSenha += permitidos.Substring(RandomInteger(0, permitidos.Length - 1), 1);

         // Randomize (to mix up the required characters at the front).
         novaSenha = RandomizeString(novaSenha);

         return novaSenha;
      }

      public string RandomPasswordNoEspcial(int minimo, int maximo)
      {
         const string LOWER = "abcdefghijklmnopqrstuvwxyz";
         const string UPPER = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
         const string NUMBER = "0123456789";

         string permitidos = "";

         permitidos = LOWER + UPPER + NUMBER;

         // Gera a lista de caracteres permitidos...
         //string permitidos = LOWER + UPPER + NUMBER + SPECIAL;

         //Gera o múmero máximo de caracteres desta senha...
         int num_chars = RandomInteger(minimo, maximo);

         //*------- Para garantir os requisitos mínimos de senha...
         string novaSenha = RandomChar(LOWER);
         novaSenha += RandomChar(UPPER);
         novaSenha += RandomChar(NUMBER);

         //*------- Acrescenta os demais caracteres até completar o tamanho máximo...
         while (novaSenha.Length < num_chars)
            novaSenha += permitidos.Substring(RandomInteger(0, permitidos.Length - 1), 1);

         // Randomize (to mix up the required characters at the front).
         novaSenha = RandomizeString(novaSenha);

         return novaSenha;
      }


      /// <summary>
      /// Gera um número aleatório entre os limites informado.
      /// </summary>
      /// <param name="min">Limite mínimo</param>
      /// <param name="max">Limite máximo</param>
      /// <returns>Número aleatório.</returns>
      public int RandomInteger(int min, int max)
      {
         uint scale = uint.MaxValue;
         while (scale == uint.MaxValue)
         {
            // Pega quatro bytes aleatórios...
            byte[] four_bytes = new byte[4];
            _rand.GetBytes(four_bytes);

            // Converte para "uint".
            scale = BitConverter.ToUInt32(four_bytes, 0);
         }

         // Gera o número entre o mínimo e o máximo...
         return (int)(min + (max - min) *
             (scale / (double)uint.MaxValue));
      }

      /// <summary>
      /// Obtém um caracter aleatório de uma string.
      /// </summary>
      /// <param name="buffer">string com os caracteres</param>
      /// <returns>o caracter escolhido</returns>
      public string RandomChar(string buffer)
      {
         return buffer.Substring(RandomInteger(0, buffer.Length - 1), 1);
      }

      /// <summary>
      /// Gera uma nova sequencia de caracteres para a string de entrada.
      /// </summary>
      /// <param name="buffer">String de entrada</param>
      /// <returns>Nova string baseada na entrada</returns>
      public string RandomizeString(string buffer)
      {
         string novoBuffer = "";
         while (buffer.Length > 0)
         {
            //Vai pegando os caracteres aleatoriamente...uma a um...
            int i = RandomInteger(0, buffer.Length - 1);
            novoBuffer += buffer.Substring(i, 1);
            buffer = buffer.Remove(i, 1);
         }
         return novoBuffer;
      }

      #endregion

      #region *------- Codificação/Decodificação de senha de usuário para acesso a rede do banco -------*

      /// <summary>
      /// Codifica um texto qualquer.
      /// </summary>
      /// <param name="textToEncrypt">Texto a ser codificado.</param>
      /// <returns>Texto codificado</returns>
      public static string Encrypt(string textToEncrypt)
      {
         var plainText = Encoding.UTF8.GetBytes(textToEncrypt);
         var transform = GetRijndaelManaged(CSalt).CreateEncryptor();
         return Convert.ToBase64String(transform.TransformFinalBlock(plainText, 0, plainText.Length));
      }

      /// <summary>
      /// Decodifica um texto codificado gerado pelo método Encrypt.
      /// </summary>
      /// <param name="textToDecrypt">Texto a ser decodificado.</param>
      /// <returns>Texto decodificado.</returns>
      public static string Decrypt(string textToDecrypt)
      {
         var encryptedData = Convert.FromBase64String(textToDecrypt);
         var plainText = GetRijndaelManaged(CSalt)
             .CreateDecryptor()
             .TransformFinalBlock(encryptedData, 0, encryptedData.Length);
         return Encoding.UTF8.GetString(plainText);
      }

      private static RijndaelManaged GetRijndaelManaged(string secretKey)
      {
         var keyBytes = new byte[16];
         var secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);
         Array.Copy(secretKeyBytes, keyBytes, Math.Min(keyBytes.Length, secretKeyBytes.Length));
         return new RijndaelManaged
         {
            Mode = CipherMode.CBC,
            Padding = PaddingMode.PKCS7,
            KeySize = 128,
            BlockSize = 128,
            Key = keyBytes,
            IV = keyBytes
         };
      }

      #endregion

   }
}
