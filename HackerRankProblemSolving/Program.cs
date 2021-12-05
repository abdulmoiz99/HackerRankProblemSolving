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
            List<int> ranked = new List<int> { 100, 100, 50, 40, 40, 20, 10 };
            List<int> player = new List<int> { 5, 25, 50, 120 };
            climbingLeaderboard(ranked, player);
        }
        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            ranked = ranked.Distinct().ToList();
            List<int> ranks = new List<int>();
            int count;
            foreach (var item in player)
            {
                count = 1;
                foreach (var r in ranked)
                {
                    if (item < r)
                    {
                        count++;
                    }
                }
                ranks.Add(count);
            }
            return ranks;
        }
    }
}
