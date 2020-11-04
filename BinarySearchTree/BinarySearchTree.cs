using System;

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

        public void PlantRoot(Int64 seed)
        {
            _root = new Node(seed);
            Console.WriteLine($"The Root is: {seed}");
        }

        public void Add(long data)
        {
            if (_root != null)
            {
                _root.Add(data);
            }
            else
            {
                _root = new Node(data);
                _root.Path = "<ROOT>";
            }

        }

        //O(Log n)
        public Node Search(Int64 data)
        {
            if (Root != null)
            {
                return Root.traverse(data);
            }
            else
            {
                Console.WriteLine($"Root = {Root.Data}");
                Root.Data = 50;
                return Root;
            }
        }



    }


}

