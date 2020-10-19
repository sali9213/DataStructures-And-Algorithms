using System;
using DataStructuresAndAlgorithms.DataStructures;

namespace DataStructuresAndAlgorithms.Algorithms
{
    public static class BSTOperator
    {
        public static void Insert(BST T, Node z)
        {
            Node y = null;
            Node x = T.root;

            // Find parent of z
            while(x != null)
            {
                y = x;
                if (z.key < x.key)
                    x = x.leftChild;
                else
                    x = x.rightChild;
            }

            // Set parent of z. If z is root y will be null
            z.parent = y;

            // Set z as appropriate child of y or set it as root if y is null
            if (y == null)
                T.root = z; // tree T was empty
            else if (z.key < y.key)
                y.leftChild = z;
            else
                y.rightChild = z;

        }

        public static void Delete(BST T, Node z)
        {
            if(z.leftChild == null)
            {
                Transplant(T, z, z.rightChild);
            } else if(z.rightChild == null)
            {
                Transplant(T, z, z.leftChild);
            } else
            {
                Node y = Minimum(z.rightChild);
                if(y.parent != z)
                {
                    Transplant(T, y, y.rightChild);
                    y.rightChild = z.rightChild;
                    y.rightChild.parent = y;
                }
                Transplant(T, z, y);
                y.leftChild = z.leftChild;
                y.leftChild.parent = y;

            }
        }

        private static void Transplant(BST T, Node u, Node v)
        {
            if(u.parent == null)
            {
                T.root = v;
            } else if(u == u.parent.leftChild)
            {
                u.parent.leftChild = v;
            } else
            {
                u.parent.rightChild = v;
            }
            if(v != null)
            {
                v.parent = u.parent;
            }
        }

        // Given a pointer to the root of a tree and a key k
        // returns a pointer to the node that contains the key k
        public static Node Search(Node x ,int k)
        {
            if(x == null || k == x.key)
            {
                return x;
            }

            if(k < x.key)
            {
                return Search(x.leftChild, k);
            } else
            {
                return Search(x.rightChild, k);
            }
        }

        public static Node Minimum(Node x)
        {
            while(x.leftChild != null)
            {
                x = x.leftChild;
            }

            return x;
        }

        public static Node Maximum(Node x)
        {
            while(x.rightChild != null)
            {
                x = x.rightChild;
            }

            return x;
        }

        public static Node Successor(Node x)
        {
            // If right subtree is non-empty, then the successor of x is
            // the smallest node in the right subtree of x.
            if(x.rightChild != null)
            {
                return Minimum(x.rightChild);
            }

            Node y = x.parent;

            // Find the lowest ancestor of x whose left child is also an ancestor of x
            while(y != null && x == y.rightChild)
            {
                x = y;
                y = y.parent;
            }

            return y;
        }

        public static void InorderTreeWalk(Node x)
        {
            if(x != null)
            {
                InorderTreeWalk(x.leftChild);
                Console.WriteLine(x.key);
                InorderTreeWalk(x.rightChild);
            }
        }
    }
}
