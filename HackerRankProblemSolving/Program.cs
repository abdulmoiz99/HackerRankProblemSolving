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
            string s = "12:01:00AM";
           
            Console.WriteLine(timeConversion(s));
        }
        public static string timeConversion(string s)
        {
            if (s.Substring(s.Length - 2) ==  "AM" && s.Substring(0, 2) == "12") 
            {
                return "00" + s.Substring(2, s.Length - 4);
            }
            else if (s.Substring(s.Length - 2) == "PM")
            {
                int t = Convert.ToInt32(s.Substring(0, 2)) + 12;
                return t + s.Substring(2, s.Length - 4); ;
            }
            return s;
        }
    }
}
