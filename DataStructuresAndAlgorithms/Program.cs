using System;
using DataStructuresAndAlgorithms.Algorithms;
using DataStructuresAndAlgorithms.DataStructures;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            BST bst = new BST();

            int[] arr = { 1, 2, 3, 6, 78, 12, 4, 5, 88, 14, 11, 90, -30 };

            foreach(int k in arr)
            {
                Node n = new Node(k);
                BSTOperator.Insert(bst, n);
            }

            Node p = BSTOperator.Minimum(bst);

            if (p == null)
            {
                Console.WriteLine("Node not found");
            }
            else
            {
                Console.WriteLine("THe node has been found: " + p.key);
            }
        }
    }
}
