using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INTERSUR.INFSAP.LogicaNegocio;
using Utilitarios.Quality;

using INTERSUR.INFSAP.Entidades;
    namespace INTERSUR.APP
{
    class Program
    {
        static void Main(string[] args)
        {
            LNComprobante _oLNComprobante= new LNComprobante();
            var vr = _oLNComprobante.ConsultarPendiente();
            if (vr.Status != Status.Error)
            {
                var _lista = ((List<BEComprobante>)vr.Resultado).ToArray();
            }
        }
}
}
