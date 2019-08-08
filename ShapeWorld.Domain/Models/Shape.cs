namespace ShapeWorld.Domain.Models

{
  public abstract class Shape
  {
    //fields

    //properies -- access the number of edges
    public int NumberOfEdges{get; }  //private set;} we don't want ANYONE (aside from Constructor) even "Shape" to change numOfEdges

    //methods
    public abstract double Area();
    public virtual double Perimeter()
    {
      return 0;
    }

    public virtual double Volume()
    {
      return 0;
    }

    //controllers
    public Shape(int edges)
      {
        NumberOfEdges = edges; //Use the backing fields unless you are
      }
    
    /*//old methods
    public int GetEdges()
    {
      return numberOfEdges;
    }

    public void SetEdges(int edges)
    {
      if (numberOfEdges == 0)
      {
        numberOfEdges=edges;
      }
    }*/
    
  }

}