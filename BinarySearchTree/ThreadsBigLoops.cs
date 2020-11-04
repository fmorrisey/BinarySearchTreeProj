using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class ThreadsBigLoops
    {
        BinarySearchTree bst = new BinarySearchTree();
        GenRandom rand = new GenRandom();
        Node nodeQuery;
        Int64 nodeInt;
        Stopwatch stopwatch;
        DateTime now;
        List<Task> tasks;
        Int64 NodesFound;

        public ThreadsBigLoops()
        {
            bst.PlantRoot(rand.RandomLong(1, 5000000));
            Stopwatch stopwatch = new Stopwatch();
            DateTime now = new DateTime();
            tasks = new List<Task>();
        }

        public void ThreadManager()
        {
            ThreadsBuild();
            Task.WaitAll(tasks.ToArray());
            Console.WriteLine("Tree Built");
            
            ThreadsSearch();
            Console.WriteLine(NodesFound);
        }

        public void NodeSearcher()
        {

            for (long i = 0; i < 10000000; i++)
            {
                
                nodeQuery = bst.Search(rand.RandomLong(1, 10000000));
                if (nodeQuery != null)
                {
                    nodeInt = nodeQuery.Data;
                    Console.WriteLine($"Node: {nodeInt}");
                    NodesFound++;

                }
                //else { Console.WriteLine("Not Found"); }
            }
            Console.WriteLine("DONE");

        }

        public void ThreadsBuild()
        {
            Task thr1 = new Task(buildTree1);
            Task thr2 = new Task(buildTree2);
            Task thr3 = new Task(buildTree3);
            Task thr4 = new Task(buildTree4);
            
            thr1.Start();
            thr2.Start();
            thr3.Start();
            thr4.Start();

            tasks.Add(thr1);
            tasks.Add(thr2);
            tasks.Add(thr3);
            tasks.Add(thr4);
            
        }

        public void ThreadsSearch()
        {
            Thread srchThr1 = new Thread(NodeSearcher);
            
            srchThr1.Start();

            
        }

        public void buildTree1()
        {
            
            for (long i = 0; i < 2500000; i++)
            {
                bst.Add(rand.RandomLong(1, 2500000));
            }
            Console.WriteLine($"Tree 1 DONE GROWING! @ {now}");

        }

        public void buildTree2()
        {
            for (long i = 2500000; i < 5000000; i++)
            {
                bst.Add(rand.RandomLong(2500001, 5000000));
            }
            Console.WriteLine($"Tree 2 DONE GROWING! @ {now}");
        }

        public void buildTree3()
        {
            for (long i = 5000000; i < 7500000; i++)
            {
                bst.Add(rand.RandomLong(5000001, 7500000));
            }
            Console.WriteLine($"Tree 3 DONE GROWING! @ {now}");
            

        }

        public void buildTree4()
        {
            for (long i = 7500000; i < 10000000; i++)
            {
                bst.Add(rand.RandomLong(7500000, 10000000));
            }
            Console.WriteLine($"Tree 4 DONE GROWING! @ {now}");
        }

        public void empty()
        {
            Console.WriteLine("DONE GROWING! {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
            Console.WriteLine($"DONE GROWING! @ {now}");
        }

    }
}
