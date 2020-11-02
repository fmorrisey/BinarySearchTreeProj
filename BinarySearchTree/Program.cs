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
            
            BinarySearchTree bst = new BinarySearchTree();
            genRandom rand = new genRandom();

            bst.PlantRoot(50);

            Console.WriteLine($"The Root is: {bst.Root.Data}");

            for (int i = 0; i < 100; i++)
            {
                bst.Add(rand.RandomInt(10, 100));
            }

            int cw = bst.Search(12);
            Console.WriteLine($"Node: {cw}");
            Console.WriteLine($"Node: {bst.Search(13)}");
            Console.WriteLine($"Node: {bst.Search(87)}");
            Console.WriteLine($"Node: {bst.Search(35)}");
            Console.WriteLine("END");
            Console.ReadLine();
        }
    }
}
