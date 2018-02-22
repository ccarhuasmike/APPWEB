
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


namespace INTERSUR.INFSAP.AccesoDatos
{
 	public class ADComprobante : ADComprobanteCallBack
	{
 		public ValidationResponse Consultar(BEComprobante  oComprobante)
		{
			return MethodValidator.ValidateDataAccess(CallBack().ConsultarCallBack,
                        new object[] { oComprobante });
		}

        public ValidationResponse ConsultarFacturaUNODOS()
        {
            return MethodValidator.ValidateDataAccess(CallBack().ConsultarFacturaUNODOSCallBack);
        }
        public ValidationResponse ConsultarFacturaTRES()
        {
            return MethodValidator.ValidateDataAccess(CallBack().ConsultarFacturaTRESCallBack);
        }
        public ValidationResponse ConsultarBoletaUNODOS()
        {
            return MethodValidator.ValidateDataAccess(CallBack().ConsultarBoletaUNODOSCallBack);
        }
        public ValidationResponse ConsultarBoletaTRES()
        {
            return MethodValidator.ValidateDataAccess(CallBack().ConsultarBoletaTRESCallBack);
        }

        public ValidationResponse ConsultarPendiente()
        {
            return MethodValidator.ValidateDataAccess(CallBack().ConsultarPendienteCallBack);
        }
        public ValidationResponse Actualizar(BEComprobante oComprobante)
        {
            return MethodValidator.ValidateDataAccess(CallBack().ActualizarCallBack,
                              new object[] { oComprobante });

        }

      

        public ValidationResponse ActualizarConsulta(BEComprobante oComprobante)
        {
            return MethodValidator.ValidateDataAccess(CallBack().ActualizarConsultaCallBack,
                              new object[] { oComprobante });

        }


        public ValidationResponse ActualizarAlerta(BEComprobante oComprobante)
        {
            return MethodValidator.ValidateDataAccess(CallBack().ActualizarAlertaCallBack,
                              new object[] { oComprobante });

        }

        public ValidationResponse ConsultarAlertaExpiro(BEComprobante oComprobante)
        {
            return MethodValidator.ValidateDataAccess(CallBack().ConsultarAlertaExpiroCallBack,
                        new object[] { oComprobante });
        }
        public ValidationResponse ConsultarCabecera(BEComprobante oComprobante)
        {
            return MethodValidator.ValidateDataAccess(CallBack().ConsultarCabeceraCallBack,
                        new object[] { oComprobante });
        }

        public ValidationResponse ConsultarDetalle(BEComprobante oComprobante)
        {
            return MethodValidator.ValidateDataAccess(CallBack().ConsultarDetalleCallBack,
                        new object[] { oComprobante });
        }
        //   public ValidationResponse ConsultarPaginado(BEFiltro oFiltro)
        //{
        //	return MethodValidator.ValidateDataAccess(CallBack().ConsultarPaginadoCallBack,
        //                      new object[] { oFiltro });

        //      }
        // public ValidationResponse Insertar(BEComprobante  oComprobante)
        //{
        //	return MethodValidator.ValidateDataAccess(CallBack().InsertarCallBack,
        //                      new object[] { oComprobante });

        //      }


        //public ValidationResponse Eliminar(BEComprobante  oComprobante)
        //{
        //	return MethodValidator.ValidateDataAccess(CallBack().EliminarCallBack,
        //                      new object[] { oComprobante });

        //      } 

    }
}
