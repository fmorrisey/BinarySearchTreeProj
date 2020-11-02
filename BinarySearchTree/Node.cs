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
        // Node Data
        private int _data;
        public int Data
        {
            get { return _data; }
        }

        private string _position;
        public string Position
        {
            get { return _position; }
        }

        // Left Node
        private Node _leftNode;
        public Node LeftNode
        {
            get { return _leftNode; }
            set { _leftNode = value; _position = "left"; }
        }

        // Right Node
        private Node _rightNode;
        public Node RigthNode
        {
            get { return _rightNode; }
            set { _rightNode = value; _position = "right"; }
        }


        public Node(int value)
        {
            this._data = value;
        }

        public void Add(int value)
        {
            // if _value is greaterEquals than add right node
            if (_data >= Data)
            {   // if root node is null
                if (_rightNode == null)
                {   //create one
                    _rightNode = new Node(value);
                }
                else
                {   //if not, recursive call and create
                    _rightNode.Add(value);
                }
            }
            else
            {
                if (_leftNode == null)
                {   //create one
                    _leftNode = new Node(value);
                }
                else
                {   //if not, recursive call and create
                    _leftNode.Add(value);
                    
                }
            }
        }

        public Node traverse(int data)
        {
            Node currentNode = this;
            currentNode._data = data;

            while (currentNode != null)
            {
                if (_data > currentNode._data)
                {
                    currentNode = currentNode._rightNode;
                    return currentNode;
                }
                else if (_data < currentNode._data)
                {
                    currentNode = currentNode._leftNode;
                    return currentNode;
                }
                
               
            }
            
            return null;
        }




    }
}
