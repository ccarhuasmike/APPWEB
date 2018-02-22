
using System;
using System.Collections.Generic;
using System.Linq;
using Utilitarios.Commons;
using Utilitarios.Converters;
using Utilitarios.Quality;
 
using INTERSUR.INFSAP.Entidades;
using INTERSUR.INFSAP.AccesoDatos;

using Utilitarios.Quality;

namespace INTERSUR.INFSAP.LogicaNegocio
{

public class LNComprobanteCallBack
{
	private static _CallBack _instanceCallBack;
	protected _CallBack CallBack()
	{
		return _instanceCallBack ?? (_instanceCallBack = new _CallBack());
	}

	protected class _CallBack : Comparator
	{
 	private readonly ADComprobante ADCallBack = new ADComprobante();
	public ValidationResponse ConsultarCallBack(object[] pComprobante)
	{
	var oVMComprobante = (VMComprobante) pComprobante[0];		
	var oComprobante  = new BEComprobante 
	{
		PkId = oVMComprobante.PkId,

	};
	var vr = ADCallBack.Consultar(oComprobante);
	if (vr.Status == Status.Error) return vr;

	var _lista = (List<BEComprobante>)vr.Resultado;
	
	return vr.Exito(_lista);
	}
    public ValidationResponse ConsultarFacturaUNODOSCallBack()
    {
               
        var vr = ADCallBack.ConsultarFacturaUNODOS();
        if (vr.Status == Status.Error) return vr;

        var _lista = (List<BEComprobante>)vr.Resultado;

        return vr.Exito(_lista);
    }

        public ValidationResponse ConsultarFacturaTRESCallBack()
        {

            var vr = ADCallBack.ConsultarFacturaTRES();
            if (vr.Status == Status.Error) return vr;

            var _lista = (List<BEComprobante>)vr.Resultado;

            return vr.Exito(_lista);
        }
        public ValidationResponse ConsultarBoletaUNODOSCallBack()
        {

            var vr = ADCallBack.ConsultarBoletaUNODOS();
            if (vr.Status == Status.Error) return vr;

            var _lista = (List<BEComprobante>)vr.Resultado;

            return vr.Exito(_lista);
        }
            public ValidationResponse ConsultarBoletaTRESCallBack()
            {

                var vr = ADCallBack.ConsultarBoletaTRES();
                if (vr.Status == Status.Error) return vr;

                var _lista = (List<BEComprobante>)vr.Resultado;

                return vr.Exito(_lista);
            }

            public ValidationResponse ConsultarPendienteCallBack()
            {

                var vr = ADCallBack.ConsultarPendiente();
                if (vr.Status == Status.Error) return vr;

                var _lista = (List<BEConsulta>)vr.Resultado;

                return vr.Exito(_lista);
            }

            public ValidationResponse ActualizarCallBack(object[] pComprobante)
            {
                var oVMComprobante = (VMComprobante)pComprobante[0];

                var oComprobante = new BEComprobante()
                {

                    CNumDoc = oVMComprobante.CNumDoc,
                    PkId = oVMComprobante.PkId,
                    ECodSta = oVMComprobante.ECodSta,
                    EDesSta = oVMComprobante.EDesSta,
                    CFecEms = oVMComprobante.CFecEms,
                    CTipDoc = oVMComprobante.CTipDoc,
                    CFlgSpt = oVMComprobante.CFlgSpt,

                };

                var vr = ADCallBack.Actualizar(oComprobante);
            if (vr.Status == Status.Error) return vr;
            var resultado = (int)vr.Resultado;

            return vr.Exito(resultado);

            }

            public ValidationResponse ActualizarConsultaCallBack(object[] pComprobante)
            {
                var oVMComprobante = (VMComprobante)pComprobante[0];

                var oComprobante = new BEComprobante()
                {

                    CNumDoc = oVMComprobante.CNumDoc,
                    PkId = oVMComprobante.PkId,
                    ECodSta = oVMComprobante.ECodSta,
                    EDesSta = oVMComprobante.EDesSta,
                    CFecEms = oVMComprobante.CFecEms,
                    CTipDoc = oVMComprobante.CTipDoc,
                    CFlgSpt = oVMComprobante.CFlgSpt,

                };

                var vr = ADCallBack.ActualizarConsulta(oComprobante);
                if (vr.Status == Status.Error) return vr;
                var resultado = (int)vr.Resultado;

                return vr.Exito(resultado);

            }


            public ValidationResponse ActualizarAlertaCallBack(object[] pComprobante)
            {
                var oVMComprobante = (VMComprobante)pComprobante[0];

                var oComprobante = new BEComprobante()
                {
                    PkId = oVMComprobante.PkId,
                    CNumDoc = oVMComprobante.CNumDoc,
                    CNumDocN = oVMComprobante.CNumDocN,
                    FecDesde = oVMComprobante.FecDesde,
                    FecHasta = oVMComprobante.FecHasta,
                    CSerie = oVMComprobante.CSerie,

                };

                var vr = ADCallBack.ActualizarAlerta(oComprobante);
                if (vr.Status == Status.Error) return vr;
                var resultado = (int)vr.Resultado;

                return vr.Exito(resultado);

            }


            public ValidationResponse ConsultarAlertaExpiroCallBack(object[] pComprobante)
            {
                var oVMComprobante = (VMComprobante)pComprobante[0];
                var oComprobante = new BEComprobante
                {
                    PkId = oVMComprobante.PkId,
                    CNumDoc = oVMComprobante.CNumDoc,
                    CNumDocN = oVMComprobante.CNumDocN,
                    FecDesde = oVMComprobante.FecDesde,
                    FecHasta = oVMComprobante.FecHasta,
                    CSerie = oVMComprobante.CSerie,

                };
                var vr = ADCallBack.ConsultarAlertaExpiro(oComprobante);
                if (vr.Status == Status.Error) return vr;

                var _lista = (List<BEComprobante>)vr.Resultado;

                return vr.Exito(_lista);
            }

            public ValidationResponse ConsultarCabeceraCallBack(object[] pComprobante)
            {
                var oVMComprobante = (VMComprobante)pComprobante[0];
                var oComprobante = new BEComprobante
                {
                    PkId = oVMComprobante.PkId,
                    CNumDoc = oVMComprobante.CNumDoc,
                    CNumDocN = oVMComprobante.CNumDocN,
                    FecDesde = oVMComprobante.FecDesde,
                    FecHasta = oVMComprobante.FecHasta,
                    CSerie = oVMComprobante.CSerie,

                };
                var vr = ADCallBack.ConsultarCabecera(oComprobante);
                if (vr.Status == Status.Error) return vr;

                var _lista = (List<BEComprobante>)vr.Resultado;

                return vr.Exito(_lista);
            }

            public ValidationResponse ConsultarDetalleCallBack(object[] pComprobante)
            {
                var oVMComprobante = (VMComprobante)pComprobante[0];
                var oComprobante = new BEComprobante
                {
                    PkId = oVMComprobante.PkId,
                    CNumDoc = oVMComprobante.CNumDoc,
                    CNumDocN = oVMComprobante.CNumDocN,
                    FecDesde = oVMComprobante.FecDesde,
                    FecHasta = oVMComprobante.FecHasta,
                    CSerie = oVMComprobante.CSerie,

                };
                var vr = ADCallBack.ConsultarDetalle(oComprobante);
                if (vr.Status == Status.Error) return vr;

                var _lista = (List<BEComprobante>)vr.Resultado;

                return vr.Exito(_lista);
            }

        }
    }
}

