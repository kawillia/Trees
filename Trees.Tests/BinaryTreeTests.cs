using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Trees.Tests
{
    [TestClass]
    public class BinaryTreeTests
    {
        [TestMethod]
        public void ExistsReturnsTrueWhenValueIsRoot()
        {
            var root = new Node(7);
            var tree = new BinaryTree(root);

            Assert.IsTrue(tree.Exists(7));
        }

        [TestMethod]
        public void ExistsReturnsTrueWhenValueIsOnSecondLevel()
        {
            var root = new Node(7);
            root.Left = new Node(1);
            root.Right = new Node(9);

            var tree = new BinaryTree(root);

            Assert.IsTrue(tree.Exists(9));
        }

        [TestMethod]
        public void ExistsReturnsTrueWhenValueIsOnLeftOfThirdLevel()
        {
            var root = new Node(7);
            root.Left = new Node(1);
            root.Right = new Node(9);
            root.Left.Left = new Node(10);

            var tree = new BinaryTree(root);

            Assert.IsTrue(tree.Exists(10));
        }

        [TestMethod]
        public void ExistsReturnsTrueWhenValueIsOnRightOfThirdLevelWhenLeftIsNull()
        {
            var root = new Node(7);
            root.Left = new Node(1);
            root.Right = new Node(9);
            root.Left.Right = new Node(10);

            var tree = new BinaryTree(root);

            Assert.IsTrue(tree.Exists(10));
        }
        
        [TestMethod]
        public void ExistsReturnsTrueWhenValueIsOnFourthLevel()
        {
            var root = new Node(7);
            root.Left = new Node(1);
            root.Right = new Node(9);
            root.Left.Left = new Node(0);
            root.Left.Right = new Node(3);
            root.Left.Right.Left = new Node(2);
            root.Left.Right.Right = new Node(5);
            root.Left.Right.Right.Left = new Node(4);
            root.Left.Right.Right.Right = new Node(6);

            var tree = new BinaryTree(root);

            Assert.IsTrue(tree.Exists(4));
        }
    }
}
