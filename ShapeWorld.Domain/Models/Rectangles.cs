namespace ShapeWorld.Domain.Models

{
  public class Rectangle :Shape
  {
    public virtual double Length {get; set;}
    public virtual double Width {get; set;}

    public override double Perimeter()
    {
      return 2*(Length+Width);
    }

    public override double Area()
    {
      return (Length*Width);
    }

    public new double Volume()
    {
      return 1234;//(Length*Width*10);
    }

    public Rectangle() : base(4)
    {

    }
  }
}