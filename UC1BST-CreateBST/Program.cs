using System;

namespace UC1BST_CreateBST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>(56);
            tree.AddNode(30);
            tree.AddNode(70);
            tree.Display();
        }
    }
}
