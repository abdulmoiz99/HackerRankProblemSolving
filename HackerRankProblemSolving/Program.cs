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
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            miniMaxSum(list);
        }
        public static void miniMaxSum(List<int> arr)
        {
            arr.Sort();
            Console.Write(arr.GetRange(0, 4).Sum() + " " + arr.GetRange(1, 4).Sum());
        }
    }
}
