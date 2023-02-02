namespace SAP2000WebAPI.Domain
{
  public class Point
  {
    public int label { get; set; }
    public double[] position { get; set; }
    public bool[] Restraints { get; set; }
  }
}
