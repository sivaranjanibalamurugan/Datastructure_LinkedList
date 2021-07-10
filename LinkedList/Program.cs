using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to data structures!!");
            Linkedlist<int> linkedList = new Linkedlist<int>();
            linkedList.AddFirst(70);
            linkedList.AddFirst(30);
            linkedList.AddFirst(56);
            linkedList.DisplayList();
            Console.WriteLine("ADDING node at the last");
            Linkedlist<int> linkedList1 = new Linkedlist<int>();
            linkedList1.AddLast(56);
            linkedList1.AddLast(30);
            linkedList1.AddLast(70);
            linkedList.DisplayList();
            Console.Read();
        }
    }
}
