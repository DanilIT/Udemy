using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //ModelXTerminal modelXTerminal = new ModelXTerminal("17");
            //modelXTerminal.Connect();

            //Shape shape = new Shape();

            Shape[] shapes = new Shape[2];
            shapes[0] = new Triangle(10, 20, 30);
            shapes[1] = new Rectangle(5, 10);

            foreach(Shape shape in shapes)
            {
                shape.Draw();
                Console.WriteLine(shape.Perimeter());
            }
 
        }

        static void BoxingUndoxing()
        {
            //int x = 1;
            //object obj = x;

            //int y = (int)obj;

            double pi = 3.14;
            object obj1 = pi;

            int number = (int)(double)obj1;
            Console.WriteLine(number);
        }
        /// <summary>
        /// Boxing Unboxing Example
        /// </summary>
        /// <param name="obj"></param>
        static void Do(object obj)
        {
            bool isPointRef = obj is PointRef;
            if (isPointRef)
            {
                PointRef pr = (PointRef)obj;
                Console.WriteLine(pr.X);
            }
            else
            {
                //do smth.
            }

            PointRef pr1 = obj as PointRef;
            if (pr1 != null)
            {
                Console.WriteLine(pr1.X);
            }
            else
            {
                //smth, exception for example
            }
        }

        static void NRE_NullableValTypesDemo()
        {
            PointVal? pv = null;
            if (pv.HasValue)
            {
                PointVal pv2 = pv.Value;
                Console.WriteLine(pv.Value.X);
                Console.WriteLine(pv2.X);
            }
            else
            {
                //
            }

            PointVal pv3 = pv.GetValueOrDefault();

            PointRef c = null;
            // Console.WriteLine(c.X);
        }

        static void PassByRefDemo()
        {

            int a = 1;
            int b = 2;

            Swap(ref a, ref b);

            Console.WriteLine($"a={a}, b={b}");

            Console.ReadLine();

            var list = new List<int>();
            AddNumbers(list);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void Swap(ref int a, ref int b)
        {
            Console.WriteLine($"Original a={a}, b={b}");

            int tmp;
            tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine($"Swapped a={a}, b={b}");
        }

        static void AddNumbers(List<int> numbers)
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }

        static void ValRefTypesDemo ()
        {
            EvilStruct es1 = new EvilStruct();
            es1.PointRef = new PointRef() { X = 1, Y = 2 };
            //es1.PointRef.X = 1;
            //es1.PointRef.Y = 2;
            EvilStruct es2 = es1;

            Console.WriteLine($"es1.PointRef.X={es1.PointRef.X}" +
                $", es1.PointRef.Y= {es1.PointRef.Y}");
            Console.WriteLine($"es2.PointRef.X={es2.PointRef.X}" +
                $", es2.PointRef.Y={es2.PointRef.Y}");

            es2.PointRef.X = 42;
            es2.PointRef.Y = 45;

            Console.WriteLine($"es1.PointRef.X={es1.PointRef.X}" +
                $", es1.PointRef.Y= {es1.PointRef.Y}");
            Console.WriteLine($"es2.PointRef.X={es2.PointRef.X}" +
                $", es2.PointRef.Y={es2.PointRef.Y}");

            Console.ReadLine();

            PointVal a;//Тоже что и Pointval a = new Pointval();

            a.X = 3;
            a.Y = 5;

            PointVal b = a;
            b.X = 7;
            b.Y = 10;

            a.LogValues();
            b.LogValues();

            Console.WriteLine("After structs");

            PointRef c = new PointRef();

            c.X = 3;
            c.Y = 5;

            PointRef d = c;
            d.X = 7;
            d.Y = 10;

            c.LogValues();
            d.LogValues();
        }

        static void DemoCalculator ()
        {
            //double area = Calculator.CalcTriangleArea(10, 20, 30, true);

            //Character c1 = new Character();
            //Character c2 = new Character();

            //Console.WriteLine($"c1.Speed={c1.PrintSpeed()}. " +
            //    $"c2.Speed={c2.PrintSpeed()}");

            //c1.IncreaseSpeed();

            //Console.WriteLine($"c1.Speed={c1.PrintSpeed()}. " +
            //    $"c2.Speed={c2.PrintSpeed()}");

            //double result = Calculator.Average2(1, 2, 3);
            //Console.WriteLine(result);

            //Calsculator calc = new Calculator();
            //if(calc.TryDivide(10, 3, out double result))
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Failed to divide");
            //}
            //Console.ReadLine();

            //Console.WriteLine("Enter number, please. ");

            //string line = Console.ReadLine();

            //bool wasParsed = int.TryParse(line, out int number);            
            //if (wasParsed)
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Failed to parse");
            //}
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