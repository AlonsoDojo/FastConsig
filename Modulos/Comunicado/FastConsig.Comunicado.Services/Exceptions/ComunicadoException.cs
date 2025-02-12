namespace FastConsig.Comunicado.Services.Exceptions
{
   public class ComunicadoException : System.Exception
   {
      public ComunicadoException() { }
      public ComunicadoException(string message) : base(message) { }
      public ComunicadoException(string message, System.Exception inner) : base(message, inner) { }
      protected ComunicadoException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
   }
}
