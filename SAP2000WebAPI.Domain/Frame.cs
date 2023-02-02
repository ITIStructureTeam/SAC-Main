using System.Collections.Generic;

namespace SAP2000WebAPI.Domain
{
  public class Frame
  {
    public int Label { get; set; }
    public string Section { get; set; }
    public int StartPoint { get; set; }
    public int EndPoint { get; set; }
    public double Rotation { get; set; }
    public List<Load> Loads { get; set; }
  }
}
