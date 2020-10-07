using System;
namespace DataStructuresAndAlgorithms.DataStructures
{
    public class Stack
    {
        private int[] stack;

        // The top will always indicate the next empty space in the stack
        private int top;

        public Stack(int n)
        {
            stack = new int[n];
            top = 0;
        }

        public void push(int n)
        {
            if (top >= stack.Length)
            {
                throw new Exception("Stack overflow exception");
            }
            else
            { 
                stack[top] = n;
                top++;
            }
        }

        public int pop()
        {
            if (this.empty())
            {
                throw new Exception("Stack underflow exception");
            } else
            {
                top--;
                return stack[top];
            }
        }

        public int peek()
        {
            return stack[top - 1];
        }

        public bool empty()
        {
            if (top == 0)
                return true;
            return false;
        }

        public void print()
        {
            Console.WriteLine(top);
            foreach(int e in stack)
            {
                Console.Write(e + " ");
            }

        }
    }
}
