using System;
namespace DataStructuresAndAlgorithms.DataStructures
{
    public class Node
    {
        public int key;
        public Node leftChild, rightChild, parent;

        public Node(int key)
        {
            this.key = key;
            leftChild = rightChild = parent = null;
        }
    }
}
