using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4
{
    public class RomanNumbers
    {
        public static Dictionary<char, int> map = new Dictionary<char, int>()
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 }

        };        

        public static int Parse(string roman)
        {
            int result = 0;  
                        
            for(int i = 0; i< roman.Length; i++ )
            {
                //if (map.ContainsKey(roman[i]))
                //{                    
                    if (i + 1 < roman.Length && IsSubtracktive(roman[i], roman[i + 1]))
                    {
                        result -= map[roman[i]];
                    }
                    else
                    {
                        result += map[roman[i]];
                    }
                //}
                
            }
            
            return result;
        }

        public static bool IsSubtracktive(char c1, char c2)
        {
            return map[c1] < map[c2];            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Roman number to check it's arabic value");

            var rNumber = Console.ReadLine();
                        
            int check = 0;
            for (int i = 0; i < rNumber.Length; i++)
            {
                if (map.ContainsKey(rNumber[i]))
                    check++;
            }

            //string s = check.ToString();
            if(check != rNumber.Length)
            {
                Console.WriteLine("This roman number incorrect");
            }
            else
                Console.WriteLine(RomanNumbers.Parse(rNumber));

        }
    }
}
