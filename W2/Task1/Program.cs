using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class Program
    {

        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader("C:/string.txt");
            string s = sr.ReadToEnd();//READ STRING FROM .TXT FILE
            int k = 1;

            for (int i = 0; i < s.Length; i++)//THEN CHECK FOR PALINDROME
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    k = 0;//IF IT'S NOT PALINDROME K IS EQUAL TO 0
                }
            }

            if (k == 1)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}