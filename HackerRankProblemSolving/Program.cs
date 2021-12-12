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
        public static string timeConversion(string s)
        {
            DateTime dt = Convert.ToDateTime(s);
            String time24 = dt.ToString("HH:mm:ss");
            return time24;
        }

    }
}
