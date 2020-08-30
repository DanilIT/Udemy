using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uddemy_CSharp_3_Control_Flow
{
    class Program
    {
        
        static void Main(string[] args)
        {

            
            
        }
        static void WhileDoWhile()
        {
            //int age = 0;

            //while(age < 18)
            //{
            //    Console.WriteLine("First while loop");
            //    Console.WriteLine("What is your age?");
            //    age = int.Parse(Console.ReadLine());
            //}

            //do
            //{
            //    Console.WriteLine("Do\\While");
            //    Console.WriteLine("What is your age?");
            //    age = int.Parse(Console.ReadLine());
            //}
            //while (age < 18);

            int[] numbers = { 1, 2, 3, 4, 5, };
            int i = 0;
            while (i < numbers.Length)
            {
                Console.Write(numbers[i] + " ");
                i++;
            }
            Console.WriteLine("Good!");
        }
      /// <summary>
      /// пример цикла for с вложенностью
      /// находим пары и тройки чисел в сумме равные нулю
      /// </summary>
        static void ForCycles()
        {
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -3, 1, 7 };
            
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if(atI + atJ == 0)
                    {
                        Console.WriteLine($"Couple ({atI};{atJ}). Indexes ({i};{j})");
                    }
                }
            }
            //находим тройку чисел, с суммой ноль
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    for (int k = j + 1; k < numbers.Length; k++)
                    {
                        int atI = numbers[i];
                        int atJ = numbers[j];
                        int atK = numbers[k];

                        if (atI + atJ + atK == 0)
                        {
                            Console.WriteLine($"Triples ({atI};{atJ};{atK}). Indexes ({i};{j};{k})");
                        }
                    }                  

                }
            }
        }
        static void BreakContinue()
        {
            int[] numbers = { 0, 3, 1, 5, 4, 6, 8, 7, 9 };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Number = {numbers[i]}");
            }

            Console.ReadLine();

            /// находим пары чисел в сумме равные 0
            /// находим 3 пары максимум, после этого выходим из цикла
            int[] numbers2 = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -3, 1, 7 };

            int counter = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (counter == 3)
                    break;
                for (int j = 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Couple ({atI};{atJ}). Indexes ({i};{j})");
                        counter++;
                    }
                    if (counter == 3)
                        break;
                }
            }
        }
    }
}
 