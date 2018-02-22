
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Text; 


namespace INTERSUR.INFSAP.Entidades
{
	public partial class BEComprobante
	{
		
		
	public	BEComprobante(IDataReader  oData)
	{		
		PkId = Convert.ToDecimal(oData["PK_ID"] is DBNull ? 0 : oData["PK_ID"]); 
		PkFichero = Convert.ToString(oData["PK_FICHERO"] is DBNull ? "" :oData["PK_FICHERO"]); 
		CNumDoc = Convert.ToString(oData["C_NUM_DOC"] is DBNull ? "" :oData["C_NUM_DOC"]); 
		CTipDoc = Convert.ToString(oData["C_TIP_DOC"] is DBNull ? "" :oData["C_TIP_DOC"]); 
		CCodUbg = Convert.ToString(oData["C_COD_UBG"] is DBNull ? "" :oData["C_COD_UBG"]); 
		CRucCli = Convert.ToString(oData["C_RUC_CLI"] is DBNull ? "" :oData["C_RUC_CLI"]); 
		CRaSoc = Convert.ToString(oData["C_RA_SOC"] is DBNull ? "" :oData["C_RA_SOC"]); 
		CTotTra = Convert.ToString(oData["C_TOT_TRA"] is DBNull ? "" :oData["C_TOT_TRA"]); 
		CDesGbl = Convert.ToString(oData["C_DES_GBL"] is DBNull ? "" :oData["C_DES_GBL"]); 
		CFecEms = Convert.ToString(oData["C_FEC_EMS"] is DBNull ? "" :oData["C_FEC_EMS"]); 
		CFlgSpt = Convert.ToString(oData["C_FLG_SPT"] is DBNull ? "" :oData["C_FLG_SPT"]); 
		TiImpTot = Convert.ToString(oData["TI_IMP_TOT"] is DBNull ? "" : oData["TI_IMP_TOT"]); 
		TiImpItr = Convert.ToString(oData["TI_IMP_ITR"] is DBNull ? "" :oData["TI_IMP_ITR"]); 
		DNumDoc = Convert.ToString(oData["D_NUM_DOC"] is DBNull ? "" :oData["D_NUM_DOC"]); 
		DItmTot = Convert.ToString(oData["D_ITM_TOT"] is DBNull ? "" : oData["D_ITM_TOT"]); 
		DItmPru = Convert.ToString(oData["D_ITM_PRU"] is DBNull ? "" : oData["D_ITM_PRU"]); 
		DItmImp = Convert.ToString(oData["D_ITM_IMP"] is DBNull ? "" : oData["D_ITM_IMP"]); 
		DItmIms = Convert.ToString(oData["D_ITM_IMS"] is DBNull ? "" : oData["D_ITM_IMS"]); 
		DItmItr = Convert.ToString(oData["D_ITM_ITR"] is DBNull ? "" :oData["D_ITM_ITR"]); 
		DItmCma = Convert.ToString(oData["D_ITM_CMA"] is DBNull ? "" :oData["D_ITM_CMA"]); 
		DItmVun = Convert.ToString(oData["D_ITM_VUN"] is DBNull ? "" : oData["D_ITM_VUN"]); 
		DItmDes = Convert.ToString(oData["D_ITM_DES"] is DBNull ? "" : oData["D_ITM_DES"]); 
		IaNumDoc = Convert.ToString(oData["IA_NUM_DOC"] is DBNull ? "" :oData["IA_NUM_DOC"]); 
		IaIagCod = Convert.ToString(oData["IA_IAG_COD"] is DBNull ? "" :oData["IA_IAG_COD"]); 
		IaIagDes = Convert.ToString(oData["IA_IAG_DES"] is DBNull ? "" :oData["IA_IAG_DES"]); 
		DaDafDoc = Convert.ToString(oData["DA_DAF_DOC"] is DBNull ? "" :oData["DA_DAF_DOC"]); 
		DaDafTdn = Convert.ToString(oData["DA_DAF_TDN"] is DBNull ? "" :oData["DA_DAF_TDN"]); 
		DaDafTda = Convert.ToString(oData["DA_DAF_TDA"] is DBNull ? "" :oData["DA_DAF_TDA"]); 
		DaDafFec = Convert.ToString(oData["DA_DAF_FEC"] is DBNull ? "" :oData["DA_DAF_FEC"]); 
		EFecCarga = Convert.ToString(oData["E_FEC_CARGA"] is DBNull ? "" : oData["E_FEC_CARGA"]); 
		EHrCarga = Convert.ToString(oData["E_HR_CARGA"] is DBNull ? "" :oData["E_HR_CARGA"]); 
		EFlgEstado = Convert.ToString(oData["E_FLG_ESTADO"] is DBNull ? "" : oData["E_FLG_ESTADO"]); 
		ECodSta = Convert.ToString(oData["E_COD_STA"] is DBNull ? "" :oData["E_COD_STA"]); 
		EDesSta = Convert.ToString(oData["E_DES_STA"] is DBNull ? "" :oData["E_DES_STA"]); 


	 }
 }	 
}

