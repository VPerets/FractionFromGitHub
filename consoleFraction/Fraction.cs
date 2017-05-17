using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleFraction
{
    class Fraction
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

        public void someMethod()
        { }
        public void someMethod3()
        { }
        public void SomeMethod2() { }

        public void SomeMethod4() { }
    }
}
