using System.Collections.Generic;

namespace SAP2000WebAPI.Domain
{
  public class DeformationPoints
  {
    public string FrameID { get; set; }
    public List<Point> AssociatedPoints { get; set; }

    public DeformationPoints()
    {
      AssociatedPoints = new List<Point>();
    }
  }
}
