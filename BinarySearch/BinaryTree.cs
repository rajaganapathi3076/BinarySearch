using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class BinaryTree
    {
       
        private Node root;

        private class Node
        {
            public int data;
            public Node left;
            public Node right;

            public Node(int item)
            {
                data = item;
                left = null;
                right = null;
            }
        }

        public BinaryTree()
        {
            root = null;
        }

        public void Add(int data)
        {
            root = AddNode(root, data);
        }

        private Node AddNode(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data);
            }
            else
            {
                if (data < root.data)
                {
                    root.left = AddNode(root.left, data);
                }
                else
                {
                    root.right = AddNode(root.right, data);
                }
            }

            return root;
        }

        public int Size()
        {
            return GetSize(root);
        }

        private int GetSize(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                return 1 + GetSize(node.left) + GetSize(node.right);
            }
        }
    }

}

