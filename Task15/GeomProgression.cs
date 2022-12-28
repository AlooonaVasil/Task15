using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    internal class GeomProgression
    {
        int start;
        int number;
        int denominator;

        public void setStart(int x)
        {
            start = x;
            number = start;
        }
        public int getNext()
        {
            number *= denominator;
            return number;
        }
        public void reset()
        {
            number = start;
        }
        public void setDenominator(int d)
        {
            denominator = d;
        }
    }
}
