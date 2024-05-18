using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.Renderer;

namespace task3.Shapes
{
    public class Square : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public string Color { get; set; }

        public Square(Raster renderer, double @base, double height, string color) : base(renderer)
        {
            Base = @base;
            Height = height;
            Color = color;
        }
        public override void Draw()
        {
            renderer.RRaster($"Triangle with base {Base}, height {Height} and color {Color}");
        }
    }

}
