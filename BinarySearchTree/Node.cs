using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{   /// <summary>
    /// 
    /// </summary>
    class Node
    {
        private int value;
        public int value
        {
            get { }
        }
        public Node left;
        public Node right;
        public string postion;
        public void showValue()
        {
            Console.WriteLine($"| Node: {value} |");
        }

        
    }  
}
