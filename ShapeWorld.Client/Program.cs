using ShapeWorld.Domain.Models;
using System;

//TRIANGLE, CIRCLE/ CUBE, SPHERE

namespace ShapeWorld.Client
{
    internal class Program
    {
      //access regular return name (parameters)
        private static void Main(string[] args)
        {
            Console.WriteLine("A Whole Hello World!");  //if no "using System;" at top then System.WriteLine("Hello World!");
            PlayWithShape();
        }

        private static void PlayWithShape()
        {
          Shape someShape = new Rectangle();
          //someShape.NumberOfEdges = 10;
          //someShape.NumberOfEdges = 100;
          Rectangle someShape1 = new Rectangle();//10);
          Square someSquare = new Square();//5);
          Rectangle someRectangle = new Rectangle() as Square; //Casting DO THIS ONE
          Rectangle someRectangle2 = (Square) new Rectangle(); //Cannot cast an abstract class


          Console.WriteLine(someShape1.NumberOfEdges);
          Console.WriteLine(someSquare.NumberOfEdges);
          Console.WriteLine(someShape.Volume());
          Console.WriteLine(someShape1.Volume());
        }
    }
}
