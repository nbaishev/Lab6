using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] words = s.Split(' ');
            int max_len = 0;
            string max_word = "";

            foreach (string word in words)
            {
                if (word.Length > max_len)
                {
                    max_len = word.Length;
                    max_word = word;
                }
            }
            Console.WriteLine(max_word);
            Console.ReadKey();
        }
    }
}
