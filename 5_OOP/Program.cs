using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            if(calc.TryDivide(10, 0, out double result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Failed to divide");
            }
            Console.ReadLine();
            
            Console.WriteLine("Enter number, please. ");

            string line = Console.ReadLine();
            
            bool wasParsed = int.TryParse(line, out int number);            
            if (wasParsed)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Failed to parse");
            }
            //Calculator calc = new Calculator();

            //calc.CalcTriangleArea(ab: 10, ac: 20, alpha: 30);

            //double avg = calc.Average2(1, 2, 3, 4);
            //Console.WriteLine(avg);
            
            
            //double area1 = calc.CalcTriangleArea(10, 20);
            //double area2 = calc.CalcTriangleArea(10, 20, 30);
            //double area3 = calc.CalcTriangleArea(10, 20, 45);


            //Console.WriteLine($"Area1={area1}. Area2={area2}. " +
            //    $"Area3={area3}");
        }
    }
}