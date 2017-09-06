using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListEklemeSilme
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linked = new LinkedList<string>();
            linked.AddLast("cat");
            linked.AddLast("dog");
            linked.AddLast("man");
            linked.AddFirst("first");
            Console.WriteLine("Linked list items:");
            Console.WriteLine();
            foreach (var item in linked)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            linked.RemoveFirst();
            linked.RemoveLast();
            Console.WriteLine("Linked list items(remove first and last):");
            Console.WriteLine();
            foreach (var item in linked)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
