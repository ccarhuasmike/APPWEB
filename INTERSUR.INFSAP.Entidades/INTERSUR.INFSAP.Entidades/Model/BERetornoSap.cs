 

using System.Runtime.Serialization;

namespace INTERSUR.INFSAP.Entidades
{
  public class BERetornoSap
  {
    [DataMember]
    public double Id { get; set; }

    [DataMember]
    public string CodSta { get; set; }

    [DataMember]
    public string DesSta { get; set; }

    //[DataMember]
    //public BEComprobantePago Comprobante { get; set; }
  }
}
