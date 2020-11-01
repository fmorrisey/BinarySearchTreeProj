using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {   /// <summary>
        ///  Binary Search Tree
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Node root = null;
            BinarySearchTree bst = new BinarySearchTree();
            int size = 200;
            int[] a = new int[size];


            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                a[i] = random.Next(100);
            }

            for (int i = 0; i < size; i++)
            {
                root = bst.Add(root, a[i]);
            }


            bst.Search(root , 10);

            Console.WriteLine($"{root.value}");
            
            Console.ReadLine();
        }
    }
}
