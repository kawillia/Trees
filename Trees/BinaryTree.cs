using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BinaryTree
    {
        private Node root;

        public BinaryTree(Node root)
        {
            this.root = root;
        }

        public Boolean Exists(Int32 value)
        {
            return Exists(root, value);
        }

        private Boolean Exists(Node node, Int32 value)
        {
            if (node == null)
                return false;

            if (node.Value == value)
                return true;

            return Exists(node.Left, value) || Exists(node.Right, value);
        }

        public Node Find(Int32 value)
        {
            return Find(root, value);
        }

        private Node Find(Node node, Int32 value)
        {
            var currentNode = node;

            while (currentNode != null)
            {
                if (currentNode == null || currentNode.Value == value)
                    return currentNode;
                else if (currentNode.Value > value)
                    return Find(node.Left, value);
                else
                    return Find(node.Right, value);
            }

            return null;
        }
    }
}
