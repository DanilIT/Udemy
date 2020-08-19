using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_CSharp_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two inregers:");
            Console.WriteLine("First integer:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Second integer:");
            int num2 = int.Parse(Console.ReadLine());

            string descripton = num1 > num2 ? $"First integer is maximal here" :
                "Second integer is maximal here";

            Console.WriteLine(descripton);

        }
    }
}
