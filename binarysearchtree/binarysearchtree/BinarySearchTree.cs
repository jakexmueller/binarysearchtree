using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarysearchtree
{
    public class BinarySearchTree
    {
        //member variables
        private Node root;

        //constructor
        public BinarySearchTree()
        {
            root = null;
        }
        
        public void Display()
        {
            Display(root, 0);
            Console.WriteLine();
        }

        public void Display(Node node, int level)
        {
            if (node == null)
            {
                return;
            }

            Display(node.rightChild, level + 1);
            Console.WriteLine();

            for(int i = 0; i < level; i++)
            {
                Console.Write(" ");
            }
            Console.Write(node.data);

            Display(node.leftChild, level + 1);
        }

        
        
    }
}
