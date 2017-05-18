using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleFraction
{
   public class Fraction
    {
        private int _den;
        public int Num { get; set; }

        public int Den { get { return _den; } set { _den = value; } }
        public Fraction()
        {
            this.Num = 0;
            _den = 1;
        }

        public override string ToString()
        {
            return $"{Num} / {_den}";
        }

        public Fraction(int n, int d)
        {
            this.Num = n;
            this._den = d;
        }

        public static bool someMethod() { return true; }
       
        public int someMethod3() { return 1234; }
       
        public void SomeMethod2() { }

        public double SomeMethod4() { return 1123.12; }

        public string someMethod5() { return "hello world 2";  }

        public string someMethod7() { return "hello world 3"; }
      
        public int someMethod6(){return 999999;}
    }
}
