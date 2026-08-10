using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Node
    {
        public int Data;
        public Node next;

        public Node (int data)
        {
            Data = data;
            next = null;
        }
    }

    class LinkedList
    {
        private Node Head;

        public void InsertEnd(int val)
        {
            Node newNode = new Node(val);
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            Node current = Head;

            while(current.next != null)
                current = current.next;

            current.next = newNode;
        }
        public void ReplaceData(int newVal, int OldVal)
        {
            Node current = Head;
            while(current != null)
            {
                if(current.Data == OldVal)
                {
                    current.Data = newVal;
                    return;
                }
                current = current.next;
            }
            Console.WriteLine("Data Not Found");
        }
        public void Display()
        {
            Node current = Head;

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
            LinkedList list = new LinkedList();

            list.InsertEnd(1);
            list.InsertEnd(2);
            list.InsertEnd(3);
            list.InsertEnd(4);
            list.InsertEnd(5);
            list.InsertEnd(6);

            list.Display();

            list.ReplaceData(2, 5);
            list.Display();
            

        }
    }
}
