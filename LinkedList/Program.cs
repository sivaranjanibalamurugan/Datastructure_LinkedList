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
            Console.WriteLine("Before Deleting");
            linkedList.DisplayList();
            Console.WriteLine("After deleting");
            linkedList.DeleteLast();
            linkedList.DisplayList();
            Console.Read();
        }
    }
}
