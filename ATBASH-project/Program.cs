using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
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

                string[] strings = Regex.Split(messege, @"\W+");
                int score = 0;
                foreach (string word in strings)
                {

                    string cleanedWord = new string(word.Where(char.IsLetter).ToArray()).ToLower();

                    if (dangerous_words.Contains(cleanedWord) ||(cleanedWord.EndsWith("s") && dangerous_words.Contains(cleanedWord.Substring(0, cleanedWord.Length - 1))))

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

            string message1 = "Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.Gsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.Ylnyh szev yvvm kozxvw mvzi pvb olxzgrlmh.Mfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm.Gsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.Dv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg.Erxglib rh mvzi. Hgzb ivzwb.";
            string decryptedMessage = Decoding_Athbaz(message1);
            (int num , string message2) = Suspicious_word_score(decryptedMessage);
            string result1 = level_of_danger(9, message2);
        }
    }
}
