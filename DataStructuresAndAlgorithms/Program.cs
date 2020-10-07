using System;
using DataStructuresAndAlgorithms.DataStructures;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleStack stack = new DoubleStack(7);
            stack.pushLeft(3);
            stack.pushRight(4);
            stack.pushLeft(2);
            stack.pushLeft(1);
            stack.pushLeft(5);
            stack.pushLeft(7);
            stack.pushLeft(10);
            stack.popLeft();
            stack.pushRight(14);
            stack.popLeft();
            stack.pushRight(16);
            stack.popLeft();
            stack.pushRight(11);
            stack.Display();
        }
    }
}
