using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarysearchtree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Node root = null;
            Node test = new Node(5);

            //test.AddTwoNumbers(4);

            Console.WriteLine("Binary Tree");
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.CreateTree();
            binarySearchTree.AddToTree(83);
            binarySearchTree.Display();
            
            Console.WriteLine();
            
            
            //Pre-order starts at root and works its way down left side of tree
            Console.WriteLine("Pre-order: ");
            binarySearchTree.PreOrder();
            Console.WriteLine("");

            //In-order starts at the farthest-left node and works its way to the farthest-right
            Console.WriteLine("In-order: ");
            binarySearchTree.InOrder();
            Console.WriteLine();

            //Post-order starts with the farthest-left tree and works its way to the root tree-by-tree
            Console.WriteLine("Post-order: ");
            binarySearchTree.PostOrder();
            Console.WriteLine();

            //Level-order works its way node-to-node by level
            Console.WriteLine("Level order: ");
            binarySearchTree.LevelOrder();
            Console.WriteLine();

            Console.WriteLine($"Height of tree is {binarySearchTree.Height()}");
            Console.ReadLine();

        }
    }
}
