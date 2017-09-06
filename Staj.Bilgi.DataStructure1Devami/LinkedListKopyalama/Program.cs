using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListKopyalama
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> AuthorList = new List<string>();
            AuthorList.Add("Mahesh Chand");
            AuthorList.Add("Praveen Kumar");
            AuthorList.Add("Raj Kumar");
            AuthorList.Add("Nipun Tomar");
            AuthorList.Add("Dinesh Beniwal");
            AuthorList.Add("Mahesh Chand");
            AuthorList.Add("Praveen Kumar");
            AuthorList.Add("Raj Kumar");
            AuthorList.Add("Nipun Tomar");
            AuthorList.Add("Dinesh Beniwal");
            string[] authorArray = new string[15];
            Console.WriteLine("Copy------");
            AuthorList.CopyTo(authorArray);
            // Copy items starting at index = 4 
            AuthorList.CopyTo(authorArray, 4);
            // Copy 4 items starting at index 2 in List and copying-to array starting at index 10
            AuthorList.CopyTo(2, authorArray, 3, 4);
            foreach (string author in authorArray)
            {
                Console.WriteLine(author);
            }
            Console.ReadLine();
        }
    }
}
