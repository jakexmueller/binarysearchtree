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
        //Pre-Order traversal
        public void PreOrder()
        {
            PreOrder(root);
            Console.WriteLine();
        }
        public void PreOrder(Node node)
        {
            if(node == null)
            {
                return;
            }
            Console.Write(node.data + " ");
            PreOrder(node.leftChild);
            PreOrder(node.rightChild);
        }
        //In-order traversal
        public void InOrder()
        {
            InOrder(root);
            Console.WriteLine();
        }
        public void InOrder(Node node)
        {
            if(node == null)
            {
                return;
            }
            InOrder(node.leftChild);
            Console.Write(node.data + " ");
            InOrder(node.rightChild);
        }
        //Post-order traversal
        public void PostOrder()
        {
            PostOrder(root);
            Console.WriteLine();
        }
        public void PostOrder(Node node)
        {
            if(node == null)
            {
                return; 
            }
            PostOrder(node.leftChild);
            PostOrder(node.rightChild);
            Console.Write(node.data + " ");
        }
        //Level-order trversal
        public void LevelOrder()
        {
            if(root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            Node node;
            while(queue.Count != 0)
            {
                node = queue.Dequeue();
                Console.Write(node.data + " ");
                if(node.leftChild != null)
                {
                    queue.Enqueue(node.leftChild);
                }
                if(node.rightChild != null)
                {
                    queue.Enqueue(node.rightChild);
                }
            }
            Console.WriteLine();
        }
        //find height of binary tree
        public int Height()
        {
            return Height(root);
        }
        public int Height(Node node)
        {
            if(node == null)
            {
                return 0;
            }
            int heightLeft = Height(node.leftChild);
            int heightRight = Height(node.rightChild);

            if(heightLeft > heightRight)
            {
                return 1 + heightRight;
            }
            else
            {
                return 1 + heightRight;
            }
        }
        public void CreateTree()
        {
            root = new Node('P');
            root.leftChild = new Node('Q');
            root.rightChild = new Node('R');
            root.leftChild.leftChild = new Node('A');
            root.leftChild.rightChild = new Node('B');
            root.rightChild.leftChild = new Node('X');
        }

        public void AddToTree(int addedValue, Node currentNode = null)
        {
            // Node currentNode = new Node(addedValue);

            if (root == null)
            {
                root = new Node(addedValue);
                return;
                //root.data = addedValue;

            }
            if (currentNode == null)
            {
                currentNode = root;
            }
            if (currentNode.data == addedValue)
            {
                return;
            }
            
            //if smaller, add left
            else if (addedValue < currentNode.data)
            {
                if (currentNode.leftChild == null)
                {
                    currentNode.leftChild = new Node(addedValue);
                }
                else
                {
                    AddToTree(addedValue, currentNode.leftChild);
                }
            }
            //if larger, add right
            else if (addedValue > currentNode.data)
            {
                if (currentNode.rightChild == null)
                {
                    currentNode.rightChild = new Node(addedValue);
                }
                else
                {
                    AddToTree(addedValue, currentNode.rightChild);
                }

            }
        }
        public void Search()
        {

        }
        
    }
}
