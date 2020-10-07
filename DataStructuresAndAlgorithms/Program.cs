using System;
using DataStructuresAndAlgorithms.DataStructures;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(2);
            stack.push(100);
            Console.WriteLine(stack.pop());
        }
    }
}
