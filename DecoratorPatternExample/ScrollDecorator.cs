//Author: Philippe Lumpkin
//Date: 2/21/2019
//File: ScrollDecorator.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample
{
    class ScrollDecorator : Decorator
    {
        public ScrollDecorator(IWidget w) : base(w)
        {

        }

        public void Draw()
        {
            Console.WriteLine("Within ");
            Console.WriteLine("A scroll decorator");
        }
    }
}
