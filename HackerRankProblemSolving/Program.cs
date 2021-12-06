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
            List<int> list = new List<int> { 4, 4, 1, 3 };
            Console.WriteLine(birthdayCakeCandles(list));
        }
        public static int birthdayCakeCandles(List<int> candles)
        {
            int max = candles.Max();
            int maxCount = 0;
            candles.Sort();
            for (int i = candles.Count-1; i >= 0; i--)
            {
                if (candles[i] == max)
                {
                    maxCount++;
                }
                else
                {
                    break;
                }
            }
            return maxCount;

        }
    }
}
