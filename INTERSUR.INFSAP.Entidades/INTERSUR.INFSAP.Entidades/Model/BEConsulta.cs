
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Text; 


namespace  INTERSUR.INFSAP.Entidades
{
	 public partial class BEConsulta
    {
	
		
		#region " Propiedades "		
		
		public Decimal PkId{get;set;}
        public Decimal PkIdN { get; set; }
        public String PkFichero{get;set;}
		
		public String CNumDoc{get;set;}
        public String CNumDocA { get; set; }
        public String EstReg { get; set; }
        public String FecReg { get; set; }


        public String CTipDoc{get;set;}
		
		public String CCodUbg{get;set;}
		
		public String CRucCli{get;set;}
		
		public String CRaSoc{get;set;}
		
		public String CTotTra{get;set;}
		
		public String CDesGbl{get;set;}
		
		public String CFecEms{get;set;}
		
		public String CFlgSpt{get;set;}
		
		public String TiImpTot {get;set;}
		
		public String TiImpItr{get;set;}
		
		public String DNumDoc{get;set;}
		
		public String DItmTot {get;set;}
		
		public String DItmPru {get;set;}
		
		public String DItmImp {get;set;}
		
		public String DItmIms {get;set;}
		
		public String DItmItr{get;set;}
		
		public String DItmCma{get;set;}
		
		public String DItmVun {get;set;}
		
		public String DItmDes {get;set;}
		
		public String IaNumDoc{get;set;}
		
		public String IaIagCod{get;set;}
		
		public String IaIagDes{get;set;}
		
		public String DaDafDoc{get;set;}
		
		public String DaDafTdn{get;set;}
		
		public String DaDafTda{get;set;}
		
		public String DaDafFec{get;set;}
		
		public String EFecCarga {get;set;}
		
		public String EHrCarga{get;set;}
		
		public String EFlgEstado {get;set;}
		
		public String ECodSta{get;set;}
		
		public String EDesSta{get;set;}
		
		#endregion
		
		public BEConsulta()
		{
		// TODO: Complete member initialization
		}
	}
	
	public class BEConsultaWS
	{
		public List<BEComprobante> oComprobante ;
		public string TotalRow { get; set; }
	}	
		
			
}

