using System.Collections.Generic;

namespace SAP2000WebAPI.Domain
{
  public class SapDeformationFrame
  {
    public string caseID { get; set; }
    public List<SapDeformationDetails> PointsDeformationDetails { get; set; }

    public SapDeformationFrame()
    {
      PointsDeformationDetails = new List<SapDeformationDetails>();
    }
  }
}
