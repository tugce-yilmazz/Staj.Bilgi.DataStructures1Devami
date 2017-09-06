using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(10);
            queue.Enqueue(15);
            queue.Enqueue(20);
            int[] array = new int[queue.Count];
            queue.CopyTo(array, 0);
            Console.WriteLine("Array:");
            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Array reverse order:");
            for (int i = array.Length - 1; i >= 0; i--)  {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
            queue.Contains(10); // true
            Console.WriteLine("Array contains:");
            if (queue.Contains(10) == true) { Console.WriteLine("Find 10 number"); }
            else { Console.WriteLine("Not find 10 number"); }
            Console.WriteLine("\nPeek:");
            Console.WriteLine(queue.Peek());
            Console.WriteLine("\nFirst dequeue");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine("\nSecond dequeue");
            Console.WriteLine(queue.Dequeue());
            Console.ReadLine();
        }
    }
}
