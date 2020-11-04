using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class GenRandom
    {
        public int RandomInt(int min, int max)
        {
            // Generates a random number
            Random Random;
            Random = new Random(Guid.NewGuid().GetHashCode());
            int hash = 0;
            hash = Random.Next(min, max);
            return hash;
        }
        public int RandomInt()
        {
            // Generates a random number
            Random Random;
            Random = new Random(Guid.NewGuid().GetHashCode());
            int hash = 0;
            hash = Random.Next();
            return hash;
        }

        public Int64 RandomLong(long min, long max)
        {
            // Generates a random number
            Random Random;
            Random = new Random(Guid.NewGuid().GetHashCode());
            Int64 hash = 0;
            hash = Random.NextLong(min, max);
            return hash;
        }
               
    }

}

