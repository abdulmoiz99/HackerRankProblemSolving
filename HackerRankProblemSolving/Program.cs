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
            int max = 0;
            if (n == c.Length) return 0;
            int nearest = 0;
            for (int i = 0; i < n; i++)
            {
                if (c.Contains(i) && max <= 0)
                {
                    continue;
                }
                else
                {
                    nearest = c.OrderBy(x => Math.Abs((long)x - i)).First();
                    nearest = Math.Abs(nearest - i);
                    if (nearest > max)
                    {
                        max = nearest;
                    }
                }
            }
            return max;
        }
    }
}
