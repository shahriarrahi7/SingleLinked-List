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

    class SwapLinkedList
    {
        private Node head;

        public void InsertEnd(int val)
        {
            Node newNode = new Node(val);
            if(head == null)
            {
                head = newNode;
                return;
            }
            Node current = head;

            while(current.next != null) 
                current = current.next;

            current.next = newNode;
        }

        public void SwapData(int val1, int val2)
        {
            Node first = null;
            Node second = null;

            Node current = head;

            while(current != null)
            {
                if(current.Data == val1 ) 
                    first = current;
                if(current.Data == val2 )
                    second = current;
                current = current.next;
            }
            if(first == null || second == null)
            {
                Console.WriteLine("Data not Found");
                return;
            }
            int temp = first.Data;
            first.Data = second.Data;
            second.Data = temp;
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
            SwapLinkedList list = new SwapLinkedList();
            list.InsertEnd(0);
            list.InsertEnd(1);
            list.InsertEnd(2);
            list.InsertEnd(3);
            list.InsertEnd(4);
            list.InsertEnd(5);
            list.InsertEnd(6);

            list.Display();

            list.SwapData(5, 3);
            list.Display();
        }
    }
}
