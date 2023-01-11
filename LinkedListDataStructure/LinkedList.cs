using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure
{
    internal class LinkedList
    {
        public Node head;
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("{0} is added into LinkedList", newNode.data);
        }
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            Console.WriteLine("{0} is added into LinkedList", newNode.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        public void Append(int data)         
        {
            AddLast(data);
        }
        public void DisplayAppend()          
        {
            Console.WriteLine("\nAfter Inserting the node");
            if (head == null)
                Console.WriteLine("LinkedList is Empty");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
        public void Insertnode(int data, int afterNum)          
        {
            Node node = new Node(data);
            Node temp = head;
            while (temp.data != afterNum)
            {
                temp = temp.next;
            }
            node.next = temp.next;
            temp.next = node;
            Console.WriteLine("Node {0} inserted after {1}.", data, afterNum);
        }

    }
}
