//Author: Philippe Lumpkin
//Date: 2/21/2019
//File: TextField.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample
{
    class TextField : IWidget
    {
        private int width;
        private int height;

        public TextField(int w, int h)
        {
            this.width = w;
            this.height = h;
        }

        public void draw()
        {
            Console.WriteLine("I am a textField");
        }
    }
}
