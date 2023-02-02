﻿namespace SAP2000WebAPI.Domain
{
  public class LoadDetail
  {
    public bool CoordSys { get; set; }
    public int Dir { get; set; }
    public int Type { get; set; }
    public int Shape { get; set; }
    public double[] Distance { get; set; }
    public double[] Magnitude { get; set; }
  }
}
