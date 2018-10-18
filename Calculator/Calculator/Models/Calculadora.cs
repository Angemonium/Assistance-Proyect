using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator.Models
{
    public class Calculadora
    {
        public int suma(int val1, int val2)
        {
            int res = val1 + val2;
            return res;

        }
        public int resta(int val1,int val2)
        {
            int res = val1 - val2;
            return res;

        }
        public int mult(int val1, int val2)
        {
            int res = val1 * val2;
            return res;

        }
        public int d(int val1, int val2)
        {
            int res = val1 / val2;
            return res;

        }

    }
}