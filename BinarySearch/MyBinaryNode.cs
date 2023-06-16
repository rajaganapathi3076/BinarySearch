using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public interface INode<T> where T : IComparable<T>
    {
        T Key { get; }
        INode<T> Left { get; set; }
        INode<T> Right { get; set; }
    }
    public class MyBinaryNode<T> : INode<T> where T : IComparable<T>
    {
        public T Key { get; }
        public INode<T>? Left { get; set; }
        public INode<T>? Right { get; set; }

        public MyBinaryNode(T key)
        {
            Key = key;
            Left = null;
            Right = null;
        }
    }

    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private INode<T>? root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Add(T key)
        {
            root = AddNode(root, key);
        }

        private INode<T> AddNode(INode<T> node, T key)
        {
            if (node == null)
            {
                node = new MyBinaryNode<T>(key);
            }
            else if (key.CompareTo(node.Key) < 0)
            {
                node.Left = AddNode(node.Left, key);
            }
            else if (key.CompareTo(node.Key) > 0)
            {
                node.Right = AddNode(node.Right, key);
            }

            return node;
        }
    
    }
}
