using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Арифметическая");
            ArithProgression arith = new ArithProgression();
            arith.setStart(15);
            arith.setStep(5);
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            arith.reset();
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());

            Console.WriteLine("Геометрическая");
            GeomProgression geom = new GeomProgression();
            geom.setStart(3);
            geom.setDenominator(4);
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            geom.reset();
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.ReadKey();
        }
    }
}
