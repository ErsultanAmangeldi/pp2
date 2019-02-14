using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task2
{
    class Program
    {   public static bool isPrime(int x)
        {
            bool ok = false;
            if (x == 1)
            {
                ok = true;
            }
            else
            {
                for (int i = 2; i < x / 2; i++)
                {
                    if (x % i == 0)
                    { //we will find all divsors of number x
                        ok = true;
                        break;
                    }
                }
            }
            return ok;
        }    
            
            
            static void Main(string[] args) {
            StreamReader sr = new StreamReader("C:/given.txt");// READ GIVEN FROM .TXT FILE
            StreamWriter sw = new StreamWriter("C:/answer.txt"); // THE FILE THAT I WILL WRITE RESULTS
            string s = sr.ReadToEnd();
            string[] ss = s.Split();// ARRAY THAT I PUT GIVEN NUMBERS

            for (int i = 0; i < ss.Length; i++)
            {
                if (isPrime(int.Parse(ss[i])))// CHECH FOR PRIME
                {
                    sw.Write(ss[i] + " ");//SO EASY WRITE TO THIS FILE;

                }
            }

            sw.Close();// LASTLY DONT FORGET TO CLOSE FILE:)


        }
    }
}
