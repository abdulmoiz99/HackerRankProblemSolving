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
            Console.WriteLine(timeConversion("07:05:45PM"));
        }
        public static int sockMerchant(int n, List<int> ar)
        {
            ar.Sort();
            int count = 0;
            for (int i = 0; i < ar.Count(); i++)
            {
                if (i + 1 < n && ar[i] == ar[i + 1])
                {
                    i++;
                    count++;
                }
            }
            return count;
        }


    }
}
