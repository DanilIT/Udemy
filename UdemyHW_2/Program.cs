using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyHW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Heron's formula calculating programm!");
            Console.WriteLine("Please enter size of 3 sides of triangle");
            Console.WriteLine("Please enter first side:\t");
            double side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second side:\t");
            double side2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter third side:\t");
            double side3 = double.Parse(Console.ReadLine());

            double triPerim = (side1 + side2 + side3) / 2;
            double triArea = Math.Sqrt(triPerim * (triPerim - side1) * (triPerim - side2) * (triPerim - side3));

            Console.WriteLine($"The area of triangle is equal to: \t {triArea}");
        }
    }
}
