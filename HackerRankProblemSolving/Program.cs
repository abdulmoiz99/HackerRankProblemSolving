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
            Console.WriteLine(caesarCipher(s, k));
        }
        public static string caesarCipher(string s, int k)
        {
            char[] cipherText = s.ToCharArray();
            char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int index = 0;
            for (   int i = 0; i < cipherText.Length; i++)
            {
                if (letters.Contains(Char.ToUpper(cipherText[i])))
                {
                    index = Array.IndexOf(letters, Char.ToUpper(cipherText[i]));
                    //(x+k) mod 26
                    index = (verifyIndex(index + k)) % 26;
                    if (Char.IsUpper(cipherText[i])) cipherText[i] = letters[index];
                    else cipherText[i] = Char.ToLower(letters[index]);
                }
            }
            return new string(cipherText);
        }
        public static int verifyIndex(int sum)
        {
            while (true)
            {
                if (sum >25) sum = sum - 26;
                else break;
            }
            return sum;
        }
    }
}
