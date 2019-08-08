namespace ShapeWorld.Domain.Models

{
  public class Square : Rectangle
  {
    private double _sideLength;
    public override double Length
    {
      get{
        return _sideLength;
      }
      set{
        _sideLength = value;
      }
    }
    public override double Width
    {
      get{
        return _sideLength;
      }
      set{
        _sideLength = value;
      }
    }

    /*public Square()
    {
    //  NumberOfEdges=4; NumberOfEdges is private AND the parent class REQUIRES an immediate size num
    }*/

    
    public override double Perimeter()
    {
      return (4*Length);
    }
    public override double Area()
    {
      return (Length*Width);
    }
  }
}