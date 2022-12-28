using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class ArithProgression : ISeries
    {
        int start;
        int number;
        int step;

        public void setStart(int x)
        {
            start = x;
            number = start;
        }
        public int getNext()
        {
            number += step;
            return number;
        }
        public void reset()
        {
            number = start;
        }
        public void setStep(int s)
        {
            step = s;
        }
    }
}
