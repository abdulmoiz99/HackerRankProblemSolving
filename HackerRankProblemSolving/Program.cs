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
            List<int> list = new List<int> { 4,4,1,3};
            Console.WriteLine(birthdayCakeCandles(list));
        }
        public static int birthdayCakeCandles(List<int> candles)
        {
           
           return candles.Where(x => x.Equals(candles.Max())).Count();
           
        }
    }
}
