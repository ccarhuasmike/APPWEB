
using System;
using System.Data;
using System.Data.Common;
using System.Configuration;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
 
using INTERSUR.INFSAP.Entidades;
using INTERSUR.INFSAP.AccesoDatos;

using Utilitarios.Quality;

namespace INTERSUR.INFSAP.LogicaNegocio
{
 

	 public class LNComprobante: LNComprobanteCallBack
	{
 
		
		 public ValidationResponse Consultar(VMComprobante  oComprobante)
		{
			return MethodValidator.ValidateBusinessMethod(CallBack().ConsultarCallBack,
       					 new object[] { oComprobante });
		}
        public ValidationResponse ConsultarFacturaUNODOS()
        {
            return MethodValidator.ValidateBusinessMethod(CallBack().ConsultarFacturaUNODOSCallBack);
        }
        public ValidationResponse ConsultarFacturaTRES()
        {
            return MethodValidator.ValidateBusinessMethod(CallBack().ConsultarFacturaTRESCallBack);
        }
        public ValidationResponse ConsultarBoletaUNODOS()
        {
            return MethodValidator.ValidateBusinessMethod(CallBack().ConsultarBoletaUNODOSCallBack);
        }
        public ValidationResponse ConsultarBoletaTRES()
        {
            return MethodValidator.ValidateBusinessMethod(CallBack().ConsultarBoletaTRESCallBack);
        }

        public ValidationResponse ConsultarPendiente()
        {
            return MethodValidator.ValidateBusinessMethod(CallBack().ConsultarPendienteCallBack);
        }

        public ValidationResponse Actualizar(VMComprobante oComprobante)
        {
            return MethodValidator.ValidateBusinessMethod(CallBack().ActualizarCallBack,
                                 new object[] { oComprobante });

        }
        public ValidationResponse ActualizarConsulta(VMComprobante oComprobante)
        {
            return MethodValidator.ValidateBusinessMethod(CallBack().ActualizarConsultaCallBack,
                                 new object[] { oComprobante });

        }

        public ValidationResponse ActualizarAlerta(VMComprobante oComprobante)
        {
            return MethodValidator.ValidateBusinessMethod(CallBack().ActualizarAlertaCallBack,
                                 new object[] { oComprobante });

        }

        public ValidationResponse ConsultarAlertaExpiro(VMComprobante oComprobante)
        {
            return MethodValidator.ValidateBusinessMethod(CallBack().ConsultarAlertaExpiroCallBack,
                             new object[] { oComprobante });

        }

        public ValidationResponse ConsultarCabecera(VMComprobante oComprobante)
        {
            return MethodValidator.ValidateBusinessMethod(CallBack().ConsultarCabeceraCallBack,
                             new object[] { oComprobante });

        }

        public ValidationResponse ConsultarDetalle(VMComprobante oComprobante)
        {
            return MethodValidator.ValidateBusinessMethod(CallBack().ConsultarDetalleCallBack,
                             new object[] { oComprobante });

        }

      

    }
}
