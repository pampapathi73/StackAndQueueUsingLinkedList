using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue_UsingLinkedList
{
          
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Dequeue();
            Console.WriteLine("After performing one dequeue operation the queue is having  : ");
            linkedListQueue.Display();
        }

    }
    }

