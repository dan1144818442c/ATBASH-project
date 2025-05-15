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



             string level_of_danger(int point, string message)
            {
                if ((0 < point) && (point < 6))
                {
                    message += " WARRING";
                }
                else if ((5 < point) && (point < 11))
                {
                    message += " DANGER";
                }
                else if ((10 < point) && (point < 16))
                {
                    message += " ULTRA ALERT!";
                }

                string result = message +" " + point.ToString();
                Console.WriteLine(result);
                return result;
            }

 
                string Decoding_Athbaz(string encryptedText)
                {

                    string Decryption = "";
                    Dictionary<char, char> Letters = new Dictionary<char, char>
 {
{'A','Z'},{'B','Y'},{'C','X'},{'D','W'},{'E','V'},{'F','U'},{'G','T'},{'H','S'},{'I','R'},{'J','Q'},{'K','P'},{'L','O'},{'M','N'},{'N','M'},{'O','L'},{'P','K'},{'Q','J'},{'R','I'},{'S','H'},{'T','G'},{'U','F'},{'V','E'},{'W','D'},{'X','C'},{'Y','B'},{'Z','A'},
{'a','z'},{'b','y'},{'c','x'},{'d','w'},{'e','v'},{'f','u'},{'g','t'},{'h','s'},{'i','r'},{'j','q'},{'k','p'},{'l','o'},{'m','n'},{'n','m'},{'o','l'},{'p','k'},{'q','j'},{'r','i'},{'s','h'},{'t','g'},{'u','f'},{'v','e'},{'w','d'},{'x','c'},{'y','b'},{'z','a'} };
                    foreach (var kvp in encryptedText)
                    {
                        if (char.IsLetter(kvp))
                        {
                            Decryption += Letters[kvp].ToString();
                        }
                        else
                        {
                            Decryption += kvp;
                        }



                    }
                    return Decryption;
                }
        
        }
    }
}
