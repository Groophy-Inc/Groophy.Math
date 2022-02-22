using System;
using Groophy.Math;

namespace Groophy.Math.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Area Formula in circle
            double Radius = 7;
            GValue Area = Math.Multiplication(Math.Pi.ToString(), Math.Exponent(Radius.ToString(), "2"));
            Area.PrintAll();

            //Diameter Formula in circle
            GValue Diameter = Math.Square_Root(Math.Division(Area, Math.Pi.ToString()));
            Diameter.PrintAll();

            Console.ReadKey(); //this stop code
        }
    }
}
