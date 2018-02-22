using System;

namespace Utilitarios.Quality
{
    public class ValidationResponse
    {
        public Status Status { set; get; }
        public int StatusCode { set; get; }
        public string Mensaje { set; get; }
        public Exception Exception { set; get; }
        public object Resultado { set; get; }

        public ValidationResponse Exito(object resultado)
        {
            var vr = this;
            vr.Status = Status.Exito;
            vr.Resultado = resultado;
            vr.Mensaje = "OK";
            return vr;

        }

        public ValidationResponse Error(string mensaje)
        {
            var vr = this;
            vr.StatusCode = -9;
            vr.Status = Status.Error;
            vr.Mensaje = mensaje;
            return vr;
        }

        public ValidationResponse Error(string mensaje, int statusCode)
        {
            var vr = this;
            vr.StatusCode = statusCode;
            vr.Status = Status.Error;
            vr.Mensaje = mensaje;
            return vr;
        }
    }
}
