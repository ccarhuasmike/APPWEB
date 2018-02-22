using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using INTERSUR.INFSAP.LogicaNegocio;
using Utilitarios.Quality;
using INTERSUR.INFSAP.Entidades;
using System.Net;
using System.Security.Permissions;
using INTERSUR.INFSAP.WSConsulta.WS_Consulta;

 
using Utilitarios.Log;
namespace INTERSUR.INFSAP.WSConsulta
{
    static class Program
    {
       
        static void Main(string[] args)
        {

            while (true)
            {
            string StrCadena = "";
            string StrCadenaCab = "";
            LNComprobante _oLNComprobante = new LNComprobante();
            DT_ConsulComproPagoSap _EntidadComprobante = new DT_ConsulComproPagoSap();
            VMComprobante oComprobante = new VMComprobante();
       
            var vr = _oLNComprobante.ConsultarPendiente();
            if (vr.Status != Status.Error)
            {
                List<BEConsulta> _lista = ((List<BEConsulta>)vr.Resultado);
               
            }
            }
        }
         
    }
}
