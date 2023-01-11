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
            Console.WriteLine("\n1.Linked List\n2.Add Linked List");
            int option = Convert.ToInt32(Console.ReadLine());
            LinkedList linkedlist = new LinkedList();
            switch (option)
            {
                case 1:
                    linkedlist.AddLast(56);
                    linkedlist.AddLast(30);
                    linkedlist.AddLast(70);
                    Console.WriteLine("-----------------------------------------");
                    linkedlist.Display();
                    break;

                case 2:
                    linkedlist.AddFirst(70);
                    linkedlist.AddFirst(30);
                    linkedlist.AddFirst(56);
                    Console.WriteLine("-----------------------------------------");
                    linkedlist.Display();
                    break;

                default:
                    Console.WriteLine("Please choose the correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
