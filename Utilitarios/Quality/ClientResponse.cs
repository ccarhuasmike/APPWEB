namespace Utilitarios.Quality
{
    public class ClientResponse
    {
        public int StatusCode { get; set; }
        public object Data { get; set; }
        public string Mensaje { get; set; }
        public string UrlRedirect { get; set; }
        public string ViewResult { get; set; }
        public string Status { get; set; }
        public object Errores { get; set; }        
    }
}