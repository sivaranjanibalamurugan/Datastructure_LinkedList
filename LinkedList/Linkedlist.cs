using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LinkedList
{
    public class Node<T>
    {
        public T value;
        public Node<T> Next;
        public Node(T value)
        {
            this.value = value;
            this.Next = null;
        }
    }
    class Linkedlist<T>
    {
        private Node<T> head;

        //method to insert the element in front;
        public void AddFirst(T value)
        {
            //creating the new node with given value
            Node<T> newNode = new Node<T>(value);
            //check whether the head is null or not . 
            if (head == null)
            {
                head = newNode;
            }
            //make the newnode  element as head
            else
            {
                newNode.Next = head;
                head = newNode;
            }
        }
        public void AddLast(T value)
        {
            //creating the new node with given value
            Node<T> newNode = new Node<T>(value);
            //check whether the head is null or not . 
            if (head == null)
            {
                head = newNode;
            }
            //iterate till the last element and make next field of last element as newNode
            else
            {
                Node<T> temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }

        //method to display the element 
        public void DisplayList()
        {
            Node<T> temp = head;
            //if head is null then no element is present
            if (head == null)
            {
                Console.WriteLine("No element in the list");
            }
            //else until temp become null it prints the value of the element   
            else
            {
                while (temp != null)
                {
                    Console.WriteLine("" + temp.value);
                    temp = temp.Next;
                }
            }
        }
    }
}