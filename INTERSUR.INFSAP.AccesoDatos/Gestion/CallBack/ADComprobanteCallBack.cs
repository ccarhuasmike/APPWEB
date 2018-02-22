
using System;
using System.Configuration;
using System.Collections.Generic;

using Utilitarios.DbHelpers;
using INTERSUR.INFSAP.Entidades;
using INTERSUR.INFSAP.AccesoDatos.Conexiones;

using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;

using System.Configuration;


namespace INTERSUR.INFSAP.AccesoDatos
{ 

	public class ADComprobanteCallBack
	{
		 private static _CallBack _instanceCallBack;
        static Database defaultDB = null;
        static Database namedDB = null;
        static SqlDatabase sqlServerDB = null;
        //string MENSAJE_SUCCESS = ConfigurationManager.AppSettings["MENSAJE_SUCCESS"].ToString();

        protected _CallBack CallBack()
        {
            defaultDB = EnterpriseLibraryContainer.Current.GetInstance<Database>();

            // Resolve a Database object from the container using the connection string name.
            namedDB = EnterpriseLibraryContainer.Current.GetInstance<Database>("BDINTERSUR");

            // Resolve a SqlDatabase object from the container using the default database.
            sqlServerDB = EnterpriseLibraryContainer.Current.GetInstance<Database>() as SqlDatabase;

            return _instanceCallBack ?? (_instanceCallBack = new _CallBack());
        }

        protected class _CallBack 
        {
        
		private readonly string _cs = "";
		#region Metodos
		
		public  object ConsultarCallBack(object[] pComprobante)
		{
                List<BEComprobante> _List;

                using (DbCommand dbCommand = defaultDB.GetStoredProcCommand("USP_COMPROBANTE"))
                {
                    
                    using (IDataReader dr = namedDB.ExecuteReader(dbCommand))
                    {
                        _List = new List<BEComprobante>();
                        while (dr.Read())
                        {
                            _List.Add(new BEComprobante(dr));
                          
                        }
                    }
                }
                
                return _List;
 
        }

            public object ConsultarFacturaUNODOSCallBack()
            {
                List<BEComprobante> _List;

                using (DbCommand dbCommand = defaultDB.GetStoredProcCommand("USP_COMPROBANTE_FACTURAUNODOS"))
                {

                    using (IDataReader dr = namedDB.ExecuteReader(dbCommand))
                    {
                        _List = new List<BEComprobante>();
                        while (dr.Read())
                        {
                            _List.Add(new BEComprobante(dr));

                        }
                    }
                }

                return _List;

            }
            public object ConsultarFacturaTRESCallBack()
            {
                List<BEComprobante> _List;

                using (DbCommand dbCommand = defaultDB.GetStoredProcCommand("USP_COMPROBANTE_FACTURATRES"))
                {

                    using (IDataReader dr = namedDB.ExecuteReader(dbCommand))
                    {
                        _List = new List<BEComprobante>();
                        while (dr.Read())
                        {
                            _List.Add(new BEComprobante(dr));

                        }
                    }
                }

                return _List;

            }

            public object ConsultarBoletaUNODOSCallBack()
            {
                List<BEComprobante> _List;

                using (DbCommand dbCommand = defaultDB.GetStoredProcCommand("USP_COMPROBANTE_BOLETAUNODOS"))
                {

                    using (IDataReader dr = namedDB.ExecuteReader(dbCommand))
                    {
                        _List = new List<BEComprobante>();
                        while (dr.Read())
                        {
                            _List.Add(new BEComprobante(dr));

                        }
                    }
                }

                return _List;

            }

            public object ConsultarBoletaTRESCallBack()
            {
                List<BEComprobante> _List;

                using (DbCommand dbCommand = defaultDB.GetStoredProcCommand("USP_COMPROBANTE_BOLETATRES"))
                {

                    using (IDataReader dr = namedDB.ExecuteReader(dbCommand))
                    {
                        _List = new List<BEComprobante>();
                        while (dr.Read())
                        {
                            _List.Add(new BEComprobante(dr));

                        }
                    }
                }

                return _List;

            }

            public object ConsultarPendienteCallBack()
            {
                List<BEConsulta> _List;

                using (DbCommand dbCommand = defaultDB.GetStoredProcCommand("USP_COMPROBANTE_CONSULTAR"))
                {

                    using (IDataReader dr = namedDB.ExecuteReader(dbCommand))
                    {
                        _List = new List<BEConsulta>();
                        while (dr.Read())
                        {
                            _List.Add(new BEConsulta(dr));

                        }
                    }
                }

                return _List;

            }


            public object ActualizarCallBack(object[] pComprobante)
            {
                var P_PARAM_OUT = 0;
                var oComprobante = (BEComprobante)pComprobante[0];

               
                using (DbCommand objCMD = defaultDB.GetStoredProcCommand("USP_COMPROBANTE_ACTUALIZAR"))
                {
                    defaultDB.AddInParameter(objCMD, "@PK_ID", DbType.Decimal, oComprobante.PkId);
                    defaultDB.AddInParameter(objCMD, "@PC_NUM_DOC", DbType.String, oComprobante.CNumDoc );
                    defaultDB.AddInParameter(objCMD, "@PE_COD_STA", DbType.String, oComprobante.ECodSta);
                    defaultDB.AddInParameter(objCMD, "@E_DES_STA", DbType.String, oComprobante.EDesSta);
                    defaultDB.AddInParameter(objCMD, "@C_FEC_EMS", DbType.String, oComprobante.CFecEms);
                    defaultDB.AddInParameter(objCMD, "@C_TIP_DOC", DbType.String, oComprobante.CTipDoc);
                    defaultDB.AddInParameter(objCMD, "@C_TIP_REG", DbType.String, oComprobante.CFlgSpt);


                    defaultDB.ExecuteNonQuery(objCMD);
                        P_PARAM_OUT =1 ;
                    
                }
                return P_PARAM_OUT;
                
            }
            public object ActualizarConsultaCallBack(object[] pComprobante)
            {
                var P_PARAM_OUT = 0;
                var oComprobante = (BEComprobante)pComprobante[0];


                using (DbCommand objCMD = defaultDB.GetStoredProcCommand("USP_COMPROBANTE_ACTUALIZAR_PEN"))
                {
                    defaultDB.AddInParameter(objCMD, "@PK_ID", DbType.Decimal, oComprobante.PkId);
                    defaultDB.AddInParameter(objCMD, "@PC_NUM_DOC", DbType.String, oComprobante.CNumDoc);
                    defaultDB.AddInParameter(objCMD, "@PE_COD_STA", DbType.String, oComprobante.ECodSta);
                    defaultDB.AddInParameter(objCMD, "@E_DES_STA", DbType.String, oComprobante.EDesSta);
                    defaultDB.AddInParameter(objCMD, "@C_FEC_EMS", DbType.String, oComprobante.CFecEms);
                    defaultDB.AddInParameter(objCMD, "@C_TIP_DOC", DbType.String, oComprobante.CTipDoc);
                    defaultDB.AddInParameter(objCMD, "@C_TIP_REG", DbType.String, oComprobante.CFlgSpt);


                    defaultDB.ExecuteNonQuery(objCMD);
                    P_PARAM_OUT = 1;

                }
                return P_PARAM_OUT;

            }

            public object ActualizarAlertaCallBack(object[] pComprobante)
            {
                var P_PARAM_OUT = 0;
                var oComprobante = (BEComprobante)pComprobante[0];


                using (DbCommand objCMD = defaultDB.GetStoredProcCommand("USP_COMPROBANTE_ACTUALIZAR_ALERTA"))
                {
                    defaultDB.AddInParameter(objCMD, "@PK_ID", DbType.Decimal, oComprobante.PkId);
                    defaultDB.AddInParameter(objCMD, "@PC_NUM_DOC", DbType.String, oComprobante.CNumDoc);
                    defaultDB.AddInParameter(objCMD, "@PC_NUM_DOCN", DbType.String, oComprobante.CNumDocN);
                    defaultDB.AddInParameter(objCMD, "@C_SERIE", DbType.String, oComprobante.CSerie);
                    defaultDB.AddInParameter(objCMD, "@C_FEC_DESDE", DbType.String, oComprobante.FecDesde);
                    defaultDB.AddInParameter(objCMD, "@C_FEC_HASTA", DbType.String, oComprobante.FecHasta);


                    defaultDB.ExecuteNonQuery(objCMD);
                    P_PARAM_OUT = 1;

                }
                return P_PARAM_OUT;

            }

            public object ConsultarAlertaExpiroCallBack(object[] pComprobante)
            {
                var P_PARAM_OUT = 0;
                var oComprobante = (BEComprobante)pComprobante[0];
                List<BEConsulta> _List;

                using (DbCommand objCMD = defaultDB.GetStoredProcCommand("USP_COMPROBANTE_CONSULTAR_ALERTAEXP"))
                {
                    defaultDB.AddInParameter(objCMD, "@PK_ID", DbType.Decimal, oComprobante.PkId);
                    defaultDB.AddInParameter(objCMD, "@PC_NUM_DOC", DbType.String, oComprobante.CNumDoc);
                    defaultDB.AddInParameter(objCMD, "@PC_NUM_DOCN", DbType.String, oComprobante.CNumDocN);
                    defaultDB.AddInParameter(objCMD, "@C_SERIE", DbType.String, oComprobante.CSerie);
                    defaultDB.AddInParameter(objCMD, "@C_FEC_DESDE", DbType.String, oComprobante.FecDesde);
                    defaultDB.AddInParameter(objCMD, "@C_FEC_HASTA", DbType.String, oComprobante.FecHasta);

                        using (IDataReader dr = namedDB.ExecuteReader(objCMD))
                        {
                            _List = new List<BEConsulta>();
                            while (dr.Read())
                            {
                                _List.Add(new BEConsulta(dr));

                            }
                        }
                
                    return _List;

            }
            }






            public object ConsultarCabeceraCallBack(object[] pComprobante)
            {
                var P_PARAM_OUT = 0;
                var oComprobante = (BEComprobante)pComprobante[0];

                List<BEComprobante> _List;
                using (DbCommand objCMD = defaultDB.GetStoredProcCommand("USP_COMPROBANTE_CONSULTAR_CABECERA"))
                {
                    defaultDB.AddInParameter(objCMD, "@PK_ID", DbType.Decimal, oComprobante.PkId);
                    defaultDB.AddInParameter(objCMD, "@PC_NUM_DOC", DbType.String, oComprobante.CNumDoc);
                    defaultDB.AddInParameter(objCMD, "@PC_NUM_DOCA", DbType.String, oComprobante.CNumDocN);
                    defaultDB.AddInParameter(objCMD, "@C_SERIE", DbType.String, oComprobante.CSerie);
                    defaultDB.AddInParameter(objCMD, "@C_FEC_DESDE", DbType.String, oComprobante.FecDesde);
                    defaultDB.AddInParameter(objCMD, "@C_FEC_HASTA", DbType.String, oComprobante.FecHasta);


                    using (IDataReader dr = namedDB.ExecuteReader(objCMD))
                    {
                        _List = new List<BEComprobante>();
                        while (dr.Read())
                        {
                            _List.Add(new BEComprobante(dr));

                        }
                    }
                }

                return _List;

            }
            public object ConsultarDetalleCallBack(object[] pComprobante)
            {
                var P_PARAM_OUT = 0;
                var oComprobante = (BEComprobante)pComprobante[0];

                List<BEComprobante> _List;

                using (DbCommand objCMD = defaultDB.GetStoredProcCommand("USP_COMPROBANTE_CONSULTAR_DETALLE"))
                {
                    defaultDB.AddInParameter(objCMD, "@PK_ID", DbType.Decimal, oComprobante.PkId);
                    defaultDB.AddInParameter(objCMD, "@PC_NUM_DOC", DbType.String, oComprobante.CNumDoc);
                    defaultDB.AddInParameter(objCMD, "@PC_NUM_DOCN", DbType.String, oComprobante.CNumDocN);
                    defaultDB.AddInParameter(objCMD, "@C_SERIE", DbType.String, oComprobante.CSerie);
                    defaultDB.AddInParameter(objCMD, "@C_FEC_DESDE", DbType.String, oComprobante.FecDesde);
                    defaultDB.AddInParameter(objCMD, "@C_FEC_HASTA", DbType.String, oComprobante.FecHasta);



                    using (IDataReader dr = namedDB.ExecuteReader(objCMD))
                    {
                        _List = new List<BEComprobante>();
                        while (dr.Read())
                        {
                            _List.Add(new BEComprobante(dr));

                        }
                    }
                }

                return _List;
            }
            #endregion

        }
    }
}
