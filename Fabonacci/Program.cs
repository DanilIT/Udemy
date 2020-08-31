using System;


namespace UdemyHW_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "johnsilveer";
            string password = "qwerty";

            int tries = 1;           

            while (tries <=3)
            {
                Console.WriteLine("Please enter yor login: ");
                string userLogin = Console.ReadLine();
                Console.WriteLine("Please enter your password: ");
                string userPassword = Console.ReadLine();

                tries++;

                if (userLogin != login && userPassword != password)
                {
                    Console.WriteLine("Wrong password or/and login");
                    continue;
                }
                else
                {
                    Console.WriteLine("Enter the System");
                    break;
                }
            }

            if (tries > 3)
            Console.WriteLine("The number of available tries have been exceeded");
            



            // 3 раза запрос пароля         
            //string login;
            //string password;
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Please enter yor login: ");
            //    login = Console.ReadLine();
            //    Console.WriteLine("Please enter your password: ");
            //    password = Console.ReadLine();

            //    if (login != "johnsilver" && password != "qwerty")
            //        continue;
            //    else
            //    {
            //        Console.WriteLine("Enter the System");
            //        break;
            //    }                    
            //}

            //Console.WriteLine("The number of available tries have been exceeded!");
        }

        static void Factorial()
        {
            Console.WriteLine("Please enter the number of which " +
                "factorial you want to get ");
            int number = int.Parse(Console.ReadLine());
            long fac = 1;
            for (int i = 1; i <= number; i++)
            {
                fac *= i;
            }

            // решение через массив:

            //int[] arr = new int[number];

            //int n = 0;
            //int x = 1;
            //foreach (int f in arr)
            //{               
            //    arr[n] = x;
            //    n++;
            //    x++;
            //}
            //long fac = 1;

            //foreach (int i in arr)
            //{
            //     fac = i * fac;
            //}

            Console.WriteLine("factorial of " + number + " is " + fac);

        }

        /// <summary>
        /// Вычесление среднего числа
        /// </summary>
        static void AverageCounting()
        {
            Console.WriteLine("Please enter up to 10 inegers");
            int[] numbers = new int[10];

            int inputCount = 0;
            while (inputCount < 10)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[inputCount] = number;

                inputCount++;

                if (number == 0)
                    break;
            }

            int Sum = 0;
            int count = 0;
            foreach (int n in numbers)
            {
                //if (n > 0 /*&& n % 3 == 0*/)
                //{
                    Sum += n;
                    count++;
                //}
            }

            double avg = (double)Sum / count;

            Console.WriteLine("average number meaning = " + avg);
        }

        /// <summary>
        /// Числа Фабоначи - сумма следующего чисал
        /// равна сумме двух предидущих
        /// </summary>
        static void Fabonacci()
        {
            Console.WriteLine("Please enter number of Fibonacci numbers to generate");
            int n = int.Parse(Console.ReadLine());
            int[] fibonacci = new int[n];

            if (n <= 0)
            {
                Console.WriteLine("Must be positive integer!");
                n = int.Parse(Console.ReadLine());
            }

            else
            {

                Console.WriteLine($"good! you'v chosed " + n + " numders");
            }

            int a0 = 0;
            int a1 = 1;

            fibonacci[0] = a0;
            fibonacci[1] = a1;
            for (int i = 2; i < n; i++)
            {
                int a = a0 + a1;
                fibonacci[i] = a;
                a0 = a1;
                a1 = a;
            }

            foreach (int cur in fibonacci)
                Console.WriteLine(cur);

            Console.ReadLine();
        }
    }
}
