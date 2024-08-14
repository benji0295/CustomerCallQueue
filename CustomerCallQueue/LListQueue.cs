using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCallQueue
{
    class Node
    {
        public int id;
        public string name;
        public Node next;
        public Node(int id, string name, Node next)
        {
            this.id = id;
            this.name = name;
            this.next = next;
        }
    }
    internal class LListQueue
    {
        Node front;
        Node rear;
        int size;

        public LListQueue()
        {
            front = null;
            rear = null;
            size = 0;
        }
        public bool IsEmpty()
        {
            return size == 0;
        }
        public void Enqueue(int id, string name)
        {
            Node newest = new Node(id, name, null);
            if (IsEmpty())
            {
                front = newest;
            }
            else
            {
                rear.next = newest;
            }
            rear = newest;
            size++;
        }
        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty.");
                return -1;
            }
            int val = front.id;
            front = front.next;
            size--;
            if (IsEmpty())
            {
                rear = null;
            }
            return val;
        }
        public void Display()
        {
            Node temp = front;
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty.");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine($"Caller ID: {temp.id}, Name: {temp.name}");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
