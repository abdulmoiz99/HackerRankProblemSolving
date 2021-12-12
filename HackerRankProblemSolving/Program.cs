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
            string s = "Pz-/aI/J`EvfthGH";
            //string s = "abc";
            int k = 66;
        }
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (x2 > x1 && v2 > v1)
            {
                return "NO";
            }
            int pos1 = x1 + v1;
            int pos2 = x2 + v2;

            while (pos1 < 10000 && pos2 < 10000)
            {
                if (pos1 == pos2)
                {
                    return "YES";
                }
                else
                {
                    pos1 += v1;
                    pos2 += v2;

                }
            }
            return "NO";
        }

    }
}
