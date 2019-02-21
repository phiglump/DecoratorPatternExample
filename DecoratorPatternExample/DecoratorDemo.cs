using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample
{
    class DecoratorDemo
    {
        static void Main(string[] args)
        {
            TextField tf = new TextField(3, 2);
            BorderDecorator bd = new BorderDecorator(tf);
            ThickBorder tb = new ThickBorder(bd);
            ScrollDecorator sd = new ScrollDecorator(tb);

            sd.Draw();

            Console.WriteLine("Press any key to stop the program");
            Console.ReadKey();

        }
    }
}
