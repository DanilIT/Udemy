using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UddemyHW_3_Body_Mass_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Body Mass Index calculating programm");
            Console.WriteLine("Please enter your last name:\t");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter your first name:\t");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your age:\t");
            double age = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your weight:\t");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your height:\t");
            double height = double.Parse(Console.ReadLine());

            double bodyMassIndex = weight / (height/100 * height/100);

            Console.WriteLine($"Your profile: \nFull Name: \t{lastName} {firstName} \n" +
                $"Age: \t{age} \nWeight: \t{weight} \nHeight: \t{height} " +
                $"\nBody Mass Index: \t{bodyMassIndex}");
        }
    }
}
