using System;
namespace DataStructuresAndAlgorithms.DataStructures
{
    public class DoubleStack
    {
        private int[] stack;
        private int topLeft;
        private int topRight;
        private int divider;

        public DoubleStack(int n)
        {
            stack = new int[n];
            // The first element in the left stack
            divider = (int)Math.Floor((double)n / 2);
            topLeft = divider;
            topRight = divider + 1;

        }

        public void pushLeft(int elem)
        {
            if (this.Full())
            {
                throw new Exception("Overflow exception");
            }

            if(topLeft == -1)
            {
                ShiftRight();   
            }

            stack[topLeft] = elem;
            topLeft--;
        }

        public void pushRight(int elem)
        {
            if (this.Full())
            {
                throw new Exception("Overflow exception");
            }
           
            if (topRight == stack.Length)
            {
                ShiftLeft();
                stack[topRight] = elem;
            }

            stack[topRight] = elem;
            topRight++;
          
        }

        public int popLeft()
        {
            if (EmptyLeft())
            {
                throw new Exception("Underflow exception");
            }
            else
            {
                topLeft++;
                return stack[topLeft];
            }
        }

        public int popRight()
        {
            if (EmptyRight())
            {
                throw new Exception("Underflow exception");
            }
            else
            {
                topRight--;
                return stack[topRight];
            }
        }

        public void peakLeft()
        {

        }

        public void peekRight()
        {

        }

        public bool Full()
        {
            if (topLeft == -1 && topRight == stack.Length)
            {
                return true;
            }

            return false;
        }

        public bool EmptyLeft()
        {
            if (topLeft == divider)
                return true;
            return false;
        }

        public bool EmptyRight()
        {
            if (topRight == divider + 1)
                return true;
            return false;
        }

        private void ShiftRight()
        {
            for(int i = topRight; i  > 0; i--)
            {
                stack[i] = stack[i - 1];
            }

            topLeft++;
            topRight++;
            divider++;
            
        }

        private void ShiftLeft()
        {
            for(int i = topLeft; i < stack.Length - 1; i++)
            {
                stack[i] = stack[i + 1];
            }

            topLeft--;
            topRight--;
            divider--;
        }

        public void Display()
        {
            for(int i = 0; i < stack.Length; i++)
            {
                if(i == topLeft || i == topRight)
                {
                    Console.Write("||" + stack[i] + "|| ");
                }
                else if (i == divider)
                {
                    Console.Write("|" + stack[i] + "| ");
                }
                else
                {
                    Console.Write(stack[i] + " ");
                }
            }
        }




    }
}
