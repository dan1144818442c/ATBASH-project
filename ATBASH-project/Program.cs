using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ATBASH_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (int, string) Suspicious_word_score(string messege)
            {
                HashSet<string> dangerous_words = new HashSet<string> {  "gun", "knife", "bomb", "nukhba", "fighter", "rocket", "secret", "poison", "explosive" };

                string[] strings = messege.Split(' ');
                int score = 0;
                foreach (string word in strings)
                {
                    if (dangerous_words.Contains(word))
                    {
                        score++;
                    }
                }
                return (score, messege);

            }

        }
    }
}
