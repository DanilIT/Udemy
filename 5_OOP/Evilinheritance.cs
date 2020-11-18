using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOP
{
    public interface IShape
    {
        int CalcSquare();
    }

    public class Rect : IShape
    {
        public int Width { get; set; }
        public int Heigh { get; set; }

        public int CalcSquare()
        {
            return Width * Heigh;
        }
    }

    public class Square : IShape
    {
        public int SideLength { get; set; }

        public int CalcSquare()
        {
            return SideLength * SideLength;
        }
    }

    //public static class AreaCalculator
    //{
    //    public static int CalcArea(Square square)
    //    {
    //        return square.Heigh * square.Heigh;
    //    }
    //    public static int CalcArea(Rect rect)
    //    {
    //        return rect.Heigh * rect.Width;
    //    }
    //}
}
