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
        /// </summary>
        /// <param name="args"></param>
        /// Example: https://github.com/kc70x/BinaryTreeExample
        static void Main(string[] args)
        {

            ThreadsBigLoops threadTester = new ThreadsBigLoops();

            threadTester.ThreadManager();

            Console.ReadLine();
        }
    }
}
