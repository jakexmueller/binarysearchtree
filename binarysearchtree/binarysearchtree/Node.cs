using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarysearchtree
{
    public class Node
    {
        public Node leftChild;
        public int data;
        public Node rightChild;
       // public int value;

        public Node(int data)
        {
            this.data = data;
            leftChild = null;
            rightChild = null;
        }

        //public int AddTwoNumbers(int numberOne, int numberTwo = 0)
        //{
        //    return numberOne + numberTwo;
        //}
    }
}
