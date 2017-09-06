using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Stack
{
    class Program
    {
        static Stack<int> GetStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(100);
            stack.Push(1000);
            stack.Push(10000);
            return stack;
        }
        static void Main(string[] args)
        {
            var stack = GetStack();
            Console.WriteLine("---Stack Contents---");
            foreach (int i in stack){ 
                Console.WriteLine(i); }
            int pop = stack.Pop();
            Console.WriteLine();
            Console.WriteLine("--- Element popped from top of Stack ---");
            Console.WriteLine(pop);
            int peek = stack.Peek();
            Console.WriteLine();
            Console.WriteLine("--- Element now at the top (peek) ---");
            Console.WriteLine(peek);
            int count = stack.Count;
            Console.WriteLine();
            Console.WriteLine("--- Element count ---");
            Console.WriteLine(count);
            stack.Clear();
            Console.WriteLine();
            Console.WriteLine("--- Stack was cleared ---");
            Console.WriteLine(stack.Count);
            Console.ReadLine();
        }
    }
}
