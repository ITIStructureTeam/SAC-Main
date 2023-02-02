using System.Collections.Generic;

namespace SAP2000WebAPI.Domain
{
  public class SapDeformation
  {
    public string FrameID { get; set; }
    public List<SapDeformationFrame> DeformationDetails { get; set; }

    public SapDeformation()
    {
      DeformationDetails = new List<SapDeformationFrame>();
    }
  }
}