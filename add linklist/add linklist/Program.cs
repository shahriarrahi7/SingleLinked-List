using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_Link_list
{
    class Node
    {
        public int Data;
        public Node next;

        public Node(int data)
        {
            Data = data;
            next = null;
        }
    }

    class AddLinkedList
    {
        private Node head;

        public void InsertEnd(int val)
        {
            Node newNode = new Node(val);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node current = head;

            while (current.next != null)
                current = current.next;

            current.next = newNode;
        }

        public void AddData(int target, int val)
        {
            Node current = head;

            while(current != null)
            {
                if(current.Data == target)
                {
                    Node newNode = new Node(val);
                    newNode.next = current.next;
                    current.next = newNode;

                    return;
                }
                current = current.next;
            }
            Console.WriteLine("Data not founb");
        }

        public void Display()
        {
            Node current = head;

            while (current != null)
            {
                Console.WriteLine(current.Data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AddLinkedList list = new AddLinkedList();
            list.InsertEnd(0);
            list.InsertEnd(1);
            list.InsertEnd(2);
            list.InsertEnd(3);
            list.InsertEnd(4);
            list.InsertEnd(5);
            list.InsertEnd(6);

            list.Display();

            list.AddData(5, 55);
            list.Display();
        }
    }
}