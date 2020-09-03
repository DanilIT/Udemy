using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Concurrent;


namespace Udemy_CSharp_4_arrays_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary();

        }

        static void StackQueue()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine($"Should print out :1 {queue.Peek()}");

            queue.Dequeue();
            Console.WriteLine($"Should print out :2 {queue.Peek()}");

            Console.WriteLine("Iterate over the stack");
            foreach (var cur in queue)
            {
                Console.WriteLine(cur);
            }


            Console.ReadLine();

            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine($"Should print out :4 {stack.Peek()}");

            stack.Pop();
            Console.WriteLine($"Should print out :3 {stack.Peek()}");

            Console.WriteLine("Iterate over the stack");
            foreach (var cur in stack)
            {
                Console.WriteLine(cur);
            }
        }

        static void Dictionary()
        {
            var people = new Dictionary<int, string>();
            people.Add(1, "John");
            people.Add(2, "Bob");
            people.Add(3, "Alice");

            people = new Dictionary<int, string>()
            {
                {1, "John" },
                {2, "Bob" },
                {3, "Alice" },
            };

            string name = people[1];
            Console.WriteLine(name);

            Console.WriteLine("Iterating over keys");

            Dictionary<int, string>.KeyCollection keys = people.Keys;
            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Iterating over values");
            Dictionary<int, string>.ValueCollection values = people.Values;
            foreach (var v in values)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("Iterating over key-value pairs");
            foreach (var pair in people)
            {
                Console.WriteLine($"Key:{pair.Key}. Value:{pair.Value}");
            }
            Console.WriteLine();

            Console.WriteLine($"Count={people.Count}");

            bool containsKey = people.ContainsKey(2);
            bool containsValue = people.ContainsValue("John");

            Console.WriteLine($"Contains key:{containsKey}. Contains vailue{containsValue}");

            people.Remove(1);

            if(people.TryGetValue(2, out string val))
            {
                Console.WriteLine($"Key 2, Val ={val}");
            }
            else
            {
                Console.WriteLine("Failet to get");
            }

            people.Clear();
            
        }

        static void List()
        {
            var intList = new List<int> { 1, 3, 4, 5, 7, 1, 3, 2 };
            intList.Add(7);

            int[] intArray = { 1, 2, 3 };
            intList.AddRange(intArray);

            if (intList.Remove(1)) //удаляет перое попадание
            {
                //do
            }
            else { }
            intList.RemoveAt(0);
            intList.Reverse();
            bool containts = intList.Contains(3);

            int min = intList.Min();
            int max = intList.Max();

            Console.WriteLine($"Min ={min}. Max={max}");

            int indexof = intList.IndexOf(2); //индекс перого вхождения
            int lastIndexOf = intList.LastIndexOf(2); //последнее вхождение элемента

            Console.WriteLine($"indexOf2 = {indexof}. lastIndexOf2 = {lastIndexOf}");

            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine($"{intList[i]}");
            }
            Console.WriteLine();

            foreach (int item in intList)
            {
                Console.WriteLine($"{item}");
            }

            Console.ReadLine();
        }

        static void Arrays()
        {
            int[] a1; //декларирование 
            a1 = new int[10];  // инициализация

            int[] a2 = new int[5]; //декларирование и инициализация

            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };// --//--

            int[] a4 = { 1, 3, 2, 4, 5 }; // --//--

            Array myArray = new int[5];
        }
    }


}   
