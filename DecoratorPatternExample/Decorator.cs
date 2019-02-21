//Author: Philippe Lumpkin
//Date: 2/21/2019
//File: Decorator.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample
{
    abstract class Decorator : IWidget
    {
        private  IWidget wid;

        public Decorator(IWidget w)
        {
            wid = w;
        }

        public void draw()
        {
            wid.draw();
        } 
    }
}
