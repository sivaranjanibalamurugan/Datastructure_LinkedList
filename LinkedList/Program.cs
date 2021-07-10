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
            Linkedlist<int> LinkedList = new Linkedlist<int>();
            linkedList.AddLast(56);
            linkedList.AddLast(30);
            linkedList.AddLast(70);
            linkedList.InsertNextTo(45, 30);
            linkedList.DisplayList();
            Console.Read();
        }
    }
}
