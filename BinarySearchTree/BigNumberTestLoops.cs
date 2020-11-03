using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BigNumberTestLoops
    {
        BinarySearchTree bst = new BinarySearchTree();
        genRandom rand = new genRandom();
        Node nodeQuery;
        int nodeInt;

        public void Tstleep()
        {
            bst.PlantRoot(50);

            Console.WriteLine($"The Root is: {bst.Root.Data}");

            for (int i = 0; i < 10000; i++)
            {
                bst.Add(rand.RandomInt(10, 10000));
            }




            for (int r = 0; r < 1000; r++)
            {
                for (int i = 0; i < 50; i++)
                {
                    nodeQuery = bst.Search(rand.RandomInt(9, 9999));
                    if (nodeQuery != null)
                    {
                        nodeInt = nodeQuery.Data;
                        Console.WriteLine($"Node: {nodeInt}");
                    }


                }
                Console.WriteLine($"{r}{r}{r}{r}{r}{r}");
            }
        }
            

        
    }
}
