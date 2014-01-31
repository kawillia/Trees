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

        [TestMethod]
        public void ExistsReturnsFalseWhenValueIsNotInTree()
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

            Assert.IsFalse(tree.Exists(42));
        }

        [TestMethod]
        public void ExistsReturnsFalseWhenTreeHasNoRoot()
        {
            var tree = new BinaryTree(null);

            Assert.IsFalse(tree.Exists(1));
        }

        [TestMethod]
        public void FindReturnNodeWhenValueIsRoot()
        {
            var root = new Node(7);
            var tree = new BinaryTree(root);
            var result = tree.Find(7);

            Assert.AreEqual(7, result.Value);
        }

        [TestMethod]
        public void FindReturnsTrueWhenValueIsOnSecondLevel()
        {
            var root = new Node(7);
            root.Left = new Node(1);
            root.Right = new Node(9);

            var tree = new BinaryTree(root);
            var result = tree.Find(9);

            Assert.AreEqual(9, result.Value);
        }

        [TestMethod]
        public void FindReturnsTrueWhenValueIsOnLeftOfThirdLevel()
        {
            var root = new Node(7);
            root.Left = new Node(1);
            root.Right = new Node(9);
            root.Left.Left = new Node(0);

            var tree = new BinaryTree(root);
            var result = tree.Find(0);

            Assert.AreEqual(0, result.Value);
        }

        [TestMethod]
        public void FindReturnsTrueWhenValueIsOnRightOfThirdLevelWhenLeftIsNull()
        {
            var root = new Node(7);
            root.Left = new Node(1);
            root.Right = new Node(9);
            root.Left.Right = new Node(3);

            var tree = new BinaryTree(root);
            var result = tree.Find(3);

            Assert.AreEqual(3, result.Value);
        }

        [TestMethod]
        public void FindReturnsTrueWhenValueIsOnFourthLevel()
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
            var result = tree.Find(4);

            Assert.AreEqual(4, result.Value);
        }

        [TestMethod]
        public void FindReturnsNullWhenValueIsNotInTree()
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

            Assert.IsNull(tree.Find(42));
        }

        [TestMethod]
        public void InsertWithNoRootSetsRoot()
        {
            var tree = new BinaryTree(null);
            tree.Insert(1);

            Assert.AreEqual("1", tree.ToString());
        }

        [TestMethod]
        public void InsertValueLessThanRootSetsLeft()
        {
            var tree = new BinaryTree(null);
            tree.Insert(7);
            tree.Insert(1);

            Assert.AreEqual("7,1", tree.ToString());
        }

        [TestMethod]
        public void InsertValueGreaterThanRootSetsRight()
        {
            var tree = new BinaryTree(null);
            tree.Insert(7);
            tree.Insert(9);

            Assert.AreEqual("7,9", tree.ToString());
        }

        [TestMethod]
        public void InsertValueLessThanLessThanLeftOfRoot()
        {
            var tree = new BinaryTree(null);
            tree.Insert(7);
            tree.Insert(1);
            tree.Insert(0);

            Assert.AreEqual("7,1,0", tree.ToString());
        }

        [TestMethod]
        public void FullTreeTest()
        {
            var tree = new BinaryTree(null);
            tree.Insert(7);
            tree.Insert(1);
            tree.Insert(0);
            tree.Insert(3);
            tree.Insert(2);
            tree.Insert(5);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(9);
            tree.Insert(8);
            tree.Insert(10);

            Assert.AreEqual("7,1,0,3,2,5,4,6,9,8,10", tree.ToString());
        }
    }
}
