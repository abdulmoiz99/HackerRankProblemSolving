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
            List<int> grades = new List<int> { 75, 67, 40, 33 };
            grades = gradingStudents(grades);
            foreach (var item in grades)
            {
                Console.WriteLine(item);
            }
        }
        public static List<int> gradingStudents(List<int> grades)
        {
            int grade = 0;
            for (int i = 0; i < grades.Count; i++)
            {
                grade = 5 * ((grades[i] - 1) / 5 + 1);
                if (grade - grades[i] < 3)
                {
                    grades[i] = grade;
                }
            }
            return grades;
        }
    }
}
