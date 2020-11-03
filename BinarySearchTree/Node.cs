using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{   /// <summary>
    /// Node objects used in the creation of the 
    /// </summary>
    class Node
    {
        // Node Data
        private int _data;
        public int Data
        {
            get { return _data; }
            set { _data = value; }
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

        public Node traverse(int searchData)
        {
            //value passed in matches nodes data return the node
            if (searchData == _data)
            {
                return this;
            }
            else if (searchData < _data && _leftNode != null)
            {
                return _leftNode.traverse(searchData);
            }
            else if (_rightNode != null)
            {
                return _rightNode.traverse(searchData);
            }
            else
            {
                return null;
            }
        }

        public Node traverseV1(int searchData)
        {
            Node searchNode = new Node(searchData);
            searchNode._data = searchData;

            while (searchNode != null)
            {
                if (_data > searchNode._data)
                {
                    searchNode = searchNode._rightNode;
                    return searchNode;
                }
                else if (_data < searchNode._data)
                {
                    searchNode = searchNode._leftNode;
                    return searchNode;
                }


            }

            return null;
        }




    }
}
