
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using FluentValidation;
//using FluentValidation.Results;

using INTERSUR.INFSAP.Entidades; 

namespace INTERSUR.INFSAP.LogicaNegocio
{
	public partial class VMComprobante
	{
		 
		#region " Propiedades "		
		public Decimal PkId{get;set;}
		public String PkFichero{get;set;}
		public String CNumDoc{get;set;}
		public String CTipDoc{get;set;}
		public String CCodUbg{get;set;}
		public String CRucCli{get;set;}
		public String CRaSoc{get;set;}
		public String CTotTra{get;set;}
		public String CDesGbl{get;set;}
		public String CFecEms{get;set;}
		public String CFlgSpt{get;set;}
		public Decimal TiImpTot{get;set;}
		public String TiImpItr{get;set;}
		public String DNumDoc{get;set;}
		public Decimal DItmTot{get;set;}
		public Decimal DItmPru{get;set;}
		public Decimal DItmImp{get;set;}
		public Decimal DItmIms{get;set;}
		public String DItmItr{get;set;}
		public String DItmCma{get;set;}
		public Decimal DItmVun{get;set;}
		public Decimal DItmDes{get;set;}
		public String IaNumDoc{get;set;}
		public String IaIagCod{get;set;}
		public String IaIagDes{get;set;}
		public String DaDafDoc{get;set;}
		public String DaDafTdn{get;set;}
		public String DaDafTda{get;set;}
		public String DaDafFec{get;set;}
		public String EFecCarga {get;set;}
		public String EHrCarga{get;set;}
		public Int32 EFlgEstado{get;set;}
		public String ECodSta{get;set;}
		public String EDesSta{get;set;}
        //reporte
        public String FecDesde { get; set; }
        public String FecHasta { get; set; }
        public String CNumDocN { get; set; }
        public String CSerie    { get; set; }

        #endregion


    }
	public class ComprobanteWS
	{
		public List<BEComprobante> oComprobante ;
		public string TotalRow { get; set; }
	 }
	

  
		
		
			
}

