
using System.Runtime.Serialization;

namespace INTERSUR.INFSAP.Entidades
{
  public class BEComprobantePago
  {
    [DataMember]
    public decimal Id { get; set; }

    [DataMember]
    public string NumDoc { get; set; }

    [DataMember]
    public string TipDoc { get; set; }

    [DataMember]
    public string CodUbg { get; set; }

    [DataMember]
    public string RucCli { get; set; }

    [DataMember]
    public string RaZoc { get; set; }

    [DataMember]
    public string TotTra { get; set; }

    [DataMember]
    public string DesGbl { get; set; }

    [DataMember]
    public string FecEms { get; set; }

    [DataMember]
    public string FlgSpt { get; set; }

    [DataMember]
    public string ImpTot { get; set; }

    [DataMember]
    public string ImpItr { get; set; }

    [DataMember]
    public string ItmTot { get; set; }

    [DataMember]
    public string ItmPru { get; set; }

    [DataMember]
    public string ItmImp { get; set; }

    [DataMember]
    public string ItmIms { get; set; }

    [DataMember]
    public string ItmItr { get; set; }

    [DataMember]
    public string ItmCma { get; set; }

    [DataMember]
    public string ItmVun { get; set; }

    [DataMember]
    public string ItmDes { get; set; }

    [DataMember]
    public string DafDoc { get; set; }

    [DataMember]
    public string DafTdn { get; set; }

    [DataMember]
    public string DafTda { get; set; }

    [DataMember]
    public string DafFec { get; set; }

    [DataMember]
    public string TipDocOrigen { get; set; }

    [DataMember]
    public string FlgEstado { get; set; }
  }
}
