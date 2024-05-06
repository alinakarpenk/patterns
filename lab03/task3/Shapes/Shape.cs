using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.Shapes
{
    public abstract class Shape
    {
        protected dynamic renderer;
        protected Shape(dynamic renderer)
        {
            this.renderer = renderer;
        }
        public abstract void Draw();
    }
}

