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
        
        public Node Add(Node root, int v)
        {
            if (root == null)
            {
                root = new Node();
                root.value = v;
                root.postion = "null";
            }
            else if (v < root.value)
            {
                root.left = Add(root.left, v);
                
            }
            else
            {
                root.right = Add(root.right, v);

            }

            return root;
        }

        public void Search(Node root, int v)
        {
            if (root == null)
            {
                return;
            }

            Search(root.left, v);
            Search(root.right, v);
        }
    }
}
