using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleFraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Fraction());

            Fraction f = new Fraction();
            Console.WriteLine(f);

            Console.WriteLine(Fraction.someMethod());
        }
    }
}
