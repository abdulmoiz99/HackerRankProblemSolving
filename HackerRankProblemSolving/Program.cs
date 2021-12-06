using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] c = {0,4 };
            int n = 5;
            Console.WriteLine(flatlandSpaceStations(n, c));
        }
        static int flatlandSpaceStations(int n, int[] c)
        {
            Array.Sort(c);
            int max = 0;
            if (n == c.Length) return 0;

            List<int> arr = Enumerable.Range(0, n).ToList().Except(c.ToList()).ToList(); // create a list of city and exclude the space station 
            int nearest = 0;
            foreach(var item in arr)
            {
                nearest = c.OrderBy(x => Math.Abs((long)x - item)).First();
                nearest = Math.Abs(nearest - item);
                if (nearest > max) max = nearest;
            }
            return max;
        }
    }
}
