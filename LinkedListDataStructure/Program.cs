using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Linked List Data Structure");
            LinkedList linkedList = new LinkedList();
            linkedList.AddLast(56);
            linkedList.AddLast(30);
            linkedList.AddLast(70);
            Console.WriteLine("-----------------------------------------");
            linkedList.Display();
            Console.ReadLine();
        }
    }
}
