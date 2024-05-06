using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.Renderer;
using task3.Shapes;


namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic vectorRenderer = new Vector();
            dynamic rasterRenderer = new Raster();
            var circle = new Circle(vectorRenderer, 5.0, 5.5, "Red");
            var square = new Square(rasterRenderer, 10.5, 3.3, "Blue");
            var triangle = new Triangle(vectorRenderer, 8.8, 6.6, "Green");
            circle.Draw();
            square.Draw();
            triangle.Draw();
            Console.ReadKey();
        }
    }
}
