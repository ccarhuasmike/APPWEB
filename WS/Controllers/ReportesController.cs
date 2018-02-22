using INTERSUR.INFSAP.LogicaNegocio;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Utilitarios.Quality;

namespace WS.Controllers
{
    [RoutePrefix("api/reportes")]
    public class ReportesController : ApiController
    {
        [Route("ActualizarAlerta"), HttpPost]
        public ValidationResponse ActualizarAlerta(JObject objData)
        {
            ValidationResponse response;
            try
            {
                VMComprobante oComprobante = new VMComprobante();
                response = new LNComprobante().ActualizarAlerta(oComprobante);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return response;
        }

        [Route("ConsultarAlertaExpiro"), HttpPost]
        public ValidationResponse ConsultarAlertaExpiro(JObject objData)
        {
            ValidationResponse response;
            try
            {
                VMComprobante oComprobante = new VMComprobante();
                response = new LNComprobante().ConsultarAlertaExpiro(oComprobante);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return response;
        }

        [Route("ConsultarCabecera"), HttpPost]
        public ValidationResponse ConsultarCabecera(JObject objData)
        {
            ValidationResponse response;
            try
            {
                VMComprobante oComprobante = new VMComprobante();
                response = new LNComprobante().ConsultarCabecera(oComprobante);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return response;
        }

        [Route("ConsultarDetalle"), HttpPost]
        public ValidationResponse ConsultarDetalle(JObject objData)
        {
            ValidationResponse response;
            try
            {
                VMComprobante oComprobante = new VMComprobante();
                response = new LNComprobante().ConsultarDetalle(oComprobante);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return response;
        }

    }
}
