using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "abcde";
            string str2 = "abcde";

            bool areEqual = str1 == str2;
            Console.WriteLine(areEqual);

            areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
            Console.WriteLine(areEqual);

        }

        /// <summary>
        /// String format
        /// </summary>
        static void StringFormat()
        {
            string name = "John";
            int age = 30;
            string strl = string.Format("My name is {0} and I'm {1}", name, age);
            string str2 = $"My name is {name} and I'm {age}";
            //string str2 = "My name is " + name + " and I'm " + age;

            Console.WriteLine(str2);

            string str3 = "My name is \nJohn";
            string str4 = "I'm \t30";


            Console.WriteLine(str3);
            Console.WriteLine(str4);

            string str5 = $"My name is {Environment.NewLine}John";

            Console.WriteLine(str5);

            //string str6 = "I'm John and I'm a "good" programmer";
            string str6 = "I'm John and I'm a \"good\" programmer";

            //string str7 = "C:\\tmp\\test_file.txt";
            string str7 = @"C:\tmp\test_file.txt";

            Console.WriteLine(str6);
            Console.WriteLine(str7);

            double answer = 42.08;
            //string result = string.format("{0:d}", answer);
            //string result2 = string.Format("{0:d4}", answer);

            string result = string.Format("{0:f}", answer);
            string result2 = string.Format("{0:f1}", answer);

            Console.OutputEncoding = Encoding.UTF8;

            double money = 12.8;
            result = string.Format("{0:C}", money);
            result2 = string.Format("{0:C2}", money);

            result = $"{money:C2}";

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            // Console.WriteLine(money.ToString("C2"));
            Console.WriteLine(result);
        }
        /// <summary>
        /// для объединения значений в строку
        /// и корректного переноса на новую строку
        /// работает быстрее всего при складывании строк
        /// </summary>
        static void StringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("John");
            sb.AppendLine("!");
            sb.AppendLine("Hello!");

            string str = sb.ToString();
            Console.WriteLine(str);
        }
        static void StringModification()
        {
            string nameConcat = string.Concat("My ", "name ", "is ", "John");
            Console.WriteLine(nameConcat);

            nameConcat = string.Join(" ", "My", "name", "is", "John");
            Console.WriteLine(nameConcat);

            // string newName =
            nameConcat = nameConcat.Insert(0, "By the way");
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Remove(0, 1);
            Console.WriteLine(nameConcat);

            string replaced = nameConcat.Replace('n', 'z');
            Console.WriteLine(replaced);

            string data = "12;28;34;25;64";
            string[] spliData = data.Split(';');
            //string first = spliData[0];
            Console.WriteLine(spliData);

            char[] chars = nameConcat.ToCharArray();
            Console.WriteLine(chars[0]);
            Console.WriteLine(nameConcat[0]);

            string lower = nameConcat.ToLower();
            Console.WriteLine(lower);

            string upper = nameConcat.ToUpper();
            Console.WriteLine(upper);

            string john = " My name is John ";
            Console.WriteLine(john.Trim());

        }
        static void stringEmptiness()
        {
            string str = string.Empty; //same as ""

            string empty = "";
            string whiteSpaced = " ";
            string notEmpty = " b";
            string nullString = null;

            Console.WriteLine("IsNullOrEmpty");
            bool isNullOrEmpty = string.IsNullOrEmpty(nullString);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(whiteSpaced);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(isNullOrEmpty);

            Console.WriteLine();
            Console.WriteLine("IsNullOrWrhiteSpace");

            bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(nullString);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(whiteSpaced);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(notEmpty);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(empty);
            Console.WriteLine(isNullOrWhiteSpace);

        }
        static void StaticAndInstsnceMembers()
        {
            string name = "abracadabra";
            bool containsA = name.Contains('a');
            bool containsE = name.Contains('E');


            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            string abc = string.Concat("a", "b", "c");
            Console.WriteLine(abc);

            Console.WriteLine(int.MinValue);

            int x = 1;
            string xStr = x.ToString();
            Console.WriteLine(xStr);
            Console.WriteLine(x);


            Console.ReadLine();
        }
    }

}

