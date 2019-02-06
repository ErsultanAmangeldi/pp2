using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class Program
    {
        public static bool isPrime(int x)
        {
            // we will write funtion to check is number prime or not.
            for (int i = 2; i <x/2; i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            string s = "";
            string[] arr = Console.ReadLine().Split(); //we create array
            for (int i = 0; i < n; i++)
            {
                int x; 
                x = int.Parse(arr[i]); // and convert number and n times x
                if (isPrime(x) && x > 1) // we check number  (int x) is  prime or not 
                {
                    s = s + x; // if int x is prime we add this int to string s
                }
            }
            Console.WriteLine(s.Length); // we will show string length 
            for (int i = 0; i < s.Length; i++)// and running by string
            {
                Console.Write(s[i]+" "); // every string parts and space;
            
            }
            // that's all!

        }
    }
}
