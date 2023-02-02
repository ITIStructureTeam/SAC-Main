namespace SAP2000WebAPI.Domain
{
  public class SapStrainingActions
  {
    public string FrameID { get; set; }
    public string PatternID { get; set; }
    public double[] StartPoint { get; set; }
    public double[] EndPoint { get; set; }
    public double[] Stations { get; set; }
    public double[] MomentX { get; set; }
    public double[] MomentY { get; set; }
    public double[] Torsion { get; set; }
    public double[] Normal { get; set; }
    public double[] ShearX { get; set; }
    public double[] ShearY { get; set; }
    public double Rotation { get; set; }
  }
}
