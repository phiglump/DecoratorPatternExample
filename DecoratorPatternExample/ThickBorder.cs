//Author: Philippe Lumpkin
//Date: 2/21/2019
//File: ThickBorder.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample
{
    class ThickBorder : Decorator
    {
        public ThickBorder(IWidget w) : base(w)
        {
            Draw();
        }

        public void Draw()
        {
            Console.WriteLine("Within ");
            Console.WriteLine("A thicker border decorator");
        }
    }
}
