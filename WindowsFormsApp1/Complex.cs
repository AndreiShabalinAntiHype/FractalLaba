using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    class Complex
    {
        public double a, b;
        public Complex (double a,double b)
        {
            this.a = a;
            this.b = b;
        }
        public void square()
        {
            double temp = (a * a) - (b * b);
            b = 2.0 * a * b;
            a = temp;
        }
        public double mod ()
            {
                return Math.Sqrt((a * a) + (b * b));
            }
        public void add (Complex c)
        {
            a += c.a;
            b += c.b;
        }
        public Complex(string str)
        {
            this.a = Convert.ToDouble(str.Substring(0, str.IndexOf('+')));
            this.b = Convert.ToDouble(str.Substring(str.IndexOf('+') + 1, str.IndexOf('i') - str.IndexOf('+') - 1));
            this.a += this.b;
        }
    }
    
}
