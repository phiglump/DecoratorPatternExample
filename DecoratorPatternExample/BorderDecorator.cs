//Author: Philippe Lumpkin
//Date: 2/21/2019
//File: BorderDecorator.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample
{
    class BorderDecorator : Decorator
    {
        public BorderDecorator(IWidget w) : base(w)
        {
            base.draw();
            Draw();
        }

        public void Draw()
        {
            Console.WriteLine("Within ");
            Console.WriteLine("A border decorator");
        }
    }
}
