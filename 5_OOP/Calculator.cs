using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _5_OOP
{
    class Calculator
    {
        public bool TryDivide (double divisible, 
            double devisor, out double result)
        {
            result = 0;
            if (devisor == 0)
            {
                return false;
            }
            result = divisible / devisor;
            return true;
        }
        public double Average(int[] numbers)
        {
            double sum = 0;

            foreach(int n in numbers)
            {
                sum += n;
            }
            return sum / numbers.Length;
        }
        /// <summary>
        /// расчет среднего числа массива
        /// params дает возможность не указывать тип данных при
        /// использоввании метода
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public double Average2(params int[] numbers)
        {
            double sum = 0;

            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum / numbers.Length;
        }

        public double CalcTriangleArea(double side1, double side2, double side3)
        {
            double triPerim = (side1 + side2 + side3) / 2;
            return Math.Sqrt(triPerim * (triPerim - side1) 
                * (triPerim - side2) * (triPerim - side3));
        }

        public double CalcTriangleArea(double b, double h)
        {
            return 0.5 * b * h;
        }
        
        public double CalcTriangleArea(double ab, double ac, int alpha)
        {
            double courner = alpha * Math.PI / 180;
            return 0.5 * ab * ac * Math.Sin(courner);
        }

    }
}
