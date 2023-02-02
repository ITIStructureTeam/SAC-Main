using System.Collections.Generic;

namespace SAP2000WebAPI.Domain
{
  public class Load
  {
    public string Pattern { get; set; }
    public List<LoadDetail> LoadDetails { get; set; }
  }
}
