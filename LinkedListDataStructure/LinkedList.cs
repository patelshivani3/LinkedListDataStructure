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
        public void RemoveFirst()       
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            else
            {
                head = head.next;
                Console.WriteLine("Removed first node");
            }
        }
        public void RemoveLast()         
        {
            if (head == null)
            {
                Console.WriteLine("The LinkedList is Empty");
            }
            else
            {
                if (head.next == null)
                    head = null;
                else
                {
                    Node temp = head;
                    while (temp.next.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = null;
                }
            }
        }
        public void Search(int input)          
        {
            bool isFound = false;
            if (head == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == input)
                    {
                        isFound = true;
                        Console.WriteLine("Given node {0} is present.", input);
                        break;
                    }
                    temp = temp.next;
                }
                if (!isFound)
                    Console.WriteLine("Given node {0} is not present", input);
            }
        }
        public void Remove()     
        {
            Node temp1 = head;
            Node temp2 = head;
            if (head == null)
            {
                Console.WriteLine("The LinkedList is Empty");
            }
            else
            {
                temp2.next.next = temp1.next.next.next;
            }
        }
        public void size()          
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("\nThe size of linked list is:" + count);
        }
    }
}
