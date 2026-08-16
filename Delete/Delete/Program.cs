using System;

namespace SIngle_LinkedList
{
    internal class Program
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

                while (current.next != null)
                    current = current.next;

                current.next = newNode;
            }

            public void DeleteNode(int val)
            {
                if (Head == null)
                    return;
                if (Head.Data == val)
                {
                    Head = Head.next;
                    return;
                }
                Node current = Head;

                while (current.next != null)
                {
                    if (current.next.Data == val)
                    {
                        current.next = current.next.next;
                        return;
                    }
                    current = current.next;
                }
                Console.WriteLine("Data not found");
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
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.InsertEnd(0);
            list.InsertEnd(1);
            list.InsertEnd(2);
            list.InsertEnd(3);
            list.InsertEnd(4);
            list.InsertEnd(5);

            Console.WriteLine("Before Delete");
            list.Display();

            list.DeleteNode(2);

            Console.WriteLine("After Delete");
            list.Display();
        }
    }
}
