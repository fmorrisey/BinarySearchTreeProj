using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class PathTests
    {
        BinarySearchTree bst = new BinarySearchTree();
        GenRandom rand = new GenRandom();
        Node nodeQuery;
        Int64 nodeInt;
        string nodePath;

        public void paths()
        {
            for (int i = 0; i < 15; i++)
            {
                bst.Add(rand.RandomInt(1, 9));
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("---------------");
                nodeQuery = bst.Search(rand.RandomInt(1, 19));
                if (nodeQuery != null)
                {
                    nodeInt = nodeQuery.Data;
                    nodePath = nodeQuery.Path;
                    Console.WriteLine($"Node: {nodeInt} @ {nodeQuery.Path}");
                }
                else { Console.WriteLine("Nothing Found"); }


            }
        }
    }
}
