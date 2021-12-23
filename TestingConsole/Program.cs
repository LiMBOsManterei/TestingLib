using System;
using TestingLibirly;
using TestingLibirly.Interfaces;

namespace TestingConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle working = new Circle(1);
            BaseCalculate kV = new BaseCalculate(2);
            triangle triangle = new triangle(3, 4, 5);
            BaseCalculate[] bcal = { working, kV, triangle};

            Square[] sq = { kV, working, triangle};

            OutputDis(bcal); 
            OutputDis(sq);



            Console.ReadLine();
        }


       static void OutputDis(Square[] sq)
        {
            foreach (var item in sq)
            {
                Console.WriteLine(item.ToString());

            }
        }
    }
}
