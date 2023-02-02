using System.Collections.Generic;

namespace SAP2000WebAPI.Domain
{
  public class SapDeformationDetails
  {
    public List<DummyPoint> Stations { get; set; }
    public double[] U1 { get; set; }
    public double[] U2 { get; set; }
    public double[] U3 { get; set; }
    public double[] R1 { get; set; }
    public double[] R2 { get; set; }
    public double[] R3 { get; set; }

    public SapDeformationDetails()
    {
      Stations = new List<DummyPoint>();
    }
  }
}
