using System;
using System.Collections.Generic;
using System.Linq;

namespace QueryExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] {97,92,81,60};
            IEnumerable<int> scoreQuery = from score in scores where score > 80 select score;

            foreach(int i in scoreQuery)
            {
                Console.WriteLine(i+ " ");
            }
        }
    }
}
