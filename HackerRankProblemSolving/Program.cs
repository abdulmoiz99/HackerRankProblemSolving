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
            List<int> list = new List<int> {1,2,3,4,5 };
            miniMaxSum(list);
        }
        public static void miniMaxSum(List<int> arr)
        {

            arr.Sort();
            Int64 min = 0;
            Int64 max = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (i<arr.Count-1)
                {
                    min += arr[i];
                }
                if (i > 0)
                {
                    max += arr[i];
                }
            }
            Console.WriteLine(min + " " +max);
        }
    }
}
