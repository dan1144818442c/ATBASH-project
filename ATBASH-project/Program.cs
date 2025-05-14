using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBASH_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace ConsoleApp8
    {
        internal class Program
        {
            static void Main(string[] args)
            {
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
                Console.WriteLine(Decoding_Athbaz("Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.\r\nGsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.\r\nYlnyh szev yvvm kozxvw mvzi pvb olxzgrlmh.\r\nMfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm.\r\nGsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.\r\nDv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg.\r\nErxglib rh mvzi. Hgzb ivzwb."));

            }
        }
    }


}
    }
}
