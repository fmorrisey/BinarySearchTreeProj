using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class genRandom
    {
        Random Random;

        public int RandomInt(int min, int max)
        {
            // Generates a random number
            Random = new Random(Guid.NewGuid().GetHashCode());
            int hash = 0;
            hash = Random.Next(min, max);
            return hash;
        }
    }
}
