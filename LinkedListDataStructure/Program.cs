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
            Console.WriteLine("\n1.Linked List\n2.Add Linked List\n3.Append Linked List\n4.Insert Node in Linked List\n5.Delete First Node of Linked List\n6.Delete Last Node of Linked List\n7.Search Node in the Linked List\n8.Insert the Node After Searchig the Linked List.\n9.Size Of Linked List");
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
                
                case 3:
                    linkedlist.Append(56);
                    linkedlist.Append(30);
                    linkedlist.Append(70);
                    Console.WriteLine("-----------------------------------------");
                    linkedlist.DisplayAppend();
                    break;

                case 4:
                    linkedlist.Append(56);
                    linkedlist.Append(70);
                    linkedlist.Insertnode(30, 56);
                    Console.WriteLine("-----------------------------------------");
                    linkedlist.DisplayAppend();
                    break;

                case 5:
                    linkedlist.AddLast(56);
                    linkedlist.AddLast(30);
                    linkedlist.AddLast(70);
                    linkedlist.RemoveFirst();
                    Console.WriteLine("-----------------------------------------");
                    linkedlist.Display();
                    break;

                case 6:
                    linkedlist.AddLast(56);
                    linkedlist.AddLast(30);
                    linkedlist.AddLast(70);
                    linkedlist.RemoveLast();
                    Console.WriteLine("-----------------------------------------");
                    linkedlist.Display();
                    break;

                case 7:
                    linkedlist.AddLast(56);
                    linkedlist.AddLast(30);
                    linkedlist.AddLast(70);
                    linkedlist.Display();
                    Console.WriteLine("\n-----------------------------------------");
                    linkedlist.Search(30);
                    break;

                case 8:
                    linkedlist.AddLast(56);
                    linkedlist.AddLast(30);
                    linkedlist.AddLast(70);
                    linkedlist.Search(30);
                    linkedlist.Insertnode(40, 30);
                    Console.WriteLine("\n-----------------------------------------");
                    linkedlist.Display();
                    break;

                case 9:
                    linkedlist.AddLast(56);
                    linkedlist.AddLast(30);
                    linkedlist.AddLast(40);
                    linkedlist.AddLast(70);
                    linkedlist.Display();
                    linkedlist.Remove();
                    Console.WriteLine("\n-----------------------------------------");
                    linkedlist.Display();
                    linkedlist.size();
                    break;
                default:
                    Console.WriteLine("Please choose from given options only");
                    break;
            }
            Console.ReadLine();
        }
    }
}
