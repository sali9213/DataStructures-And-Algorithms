using System;
namespace DataStructuresAndAlgorithms.DataStructures
{
    public class Queue
    {
        private int head;
        private int tail;
        private int[] queue;

        public Queue(int n)
        {
            queue = new int[n+1];
            head = 0;
            tail = 0;
        }

        public void Enqueue(int elem)
        {
            if (this.Full())
            {
                throw new Exception("Queue overflow");
            }
            else
            {
                queue[tail] = elem;
                tail = tail == queue.Length - 1 ? 0 : tail + 1;
            }
        }

        public int Dequeue()
        {
            if (this.Empty())
            {
                throw new Exception("Queue underflow");
            }
            else
            {
                int res = queue[head];
                head = head == queue.Length - 1 ? 0 : head + 1;
                return res;
            } 
        }

        public bool Full()
        {
            int incrementedTail = tail == queue.Length - 1 ? 0 : tail + 1;
            return head == incrementedTail;
        }

        public bool Empty()
        {
            return head == tail;
        }

        public void Display()
        {
            for(int i = 0; i < queue.Length; i++)
            {
                if(i == head)
                {
                    Console.Write("||" + queue[i] + "|| ");
                } else if(i == tail)
                {
                    Console.Write("|" + queue[i] + "| ");
                } else
                {
                    Console.Write(queue[i] + " ");
                }
            }
        }
    }
}
