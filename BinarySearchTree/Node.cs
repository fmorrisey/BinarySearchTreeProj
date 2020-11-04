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
        private Int64 _data;
        public Int64 Data
        {
            get { return _data; }
            set { _data = value; }
        }

        private string _path;
        public string Path
        {
            get { return _path; }
            set { Path = value; }
        }

        // Left Node
        private Node _leftNode;
        public Node LeftNode
        {
            get { return _leftNode; }
            set { _leftNode = value; _path = "left"; }
        }

        // Right Node
        private Node _rightNode;
        public Node RigthNode
        {
            get { return _rightNode; }
            set { _rightNode = value; _path = "right"; }
        }


        public Node(Int64 value)
        {
            this._data = value;
            
        }

        public void Add(long value)
        {
            // if _value is greaterEquals than add right node
            if (value >= Data)
            {   // if root node is null
                if (_rightNode == null)
                {   //create one
                    _rightNode = new Node(value);
                    //_rightNode._path += "=>RightX";
                }
                else
                {   
                    _rightNode.Add(value);
                    //_rightNode._path += "=>Right";
                }
            }
            else
            {
                if (_leftNode == null)
                {   //create one
                    _leftNode = new Node(value);
                    //_leftNode._path += "=>LeftX";

                }
                else
                {   //if not, recursive call and create
                    _leftNode.Add(value);
                    //_leftNode._path += "=>Left";

                }
            }
        }

        public Node traverse(Int64 searchData)
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
    }
}
