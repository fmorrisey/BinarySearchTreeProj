using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{   /// <summary>
    /// 
    /// </summary>
    class BinarySearchTree
    {
        /// log base 2 of the number of nodes = number of steps to find that node
        /// Ex: log n = steps // log base 2 of 16 nodes = 4 levels or steps
        ///
        ///
        ///
        ///

        private Node _root;
        public Node Root
        {
            get { return _root; }
        }

        public BinarySearchTree()
        {
            
        }

        public void PlantRoot(int seed)
        {
            _root = new Node(seed);
        }

        public void Add(int data)
        {
            if (_root != null)
            {
                _root.Add(data);
            }
            else
            {
                _root = new Node(data);
            }

        }
       
        public int Search(int data)
        {
            Node returnNode;

            if (Root != null)
            {
                returnNode = Root.traverse(data);
                return returnNode.Data;
            }
            else
            {
                return 0;
            }
        }

    }
}
