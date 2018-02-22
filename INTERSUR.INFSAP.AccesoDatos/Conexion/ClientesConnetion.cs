using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace INTERSUR.INFSAP.AccesoDatos.Conexiones
{
   public static class ClientesConnetion
    {
        private static readonly string LOGDIRERROR = ConfigurationManager.AppSettings["LOGDIRERROR"];
       
        public static string RUTALOGDIRERROR = ConfigurationManager.ConnectionStrings[LOGDIRERROR].ConnectionString;
       
    }
}