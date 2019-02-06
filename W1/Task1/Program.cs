
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // we create integer n
            string[] arr = Console.ReadLine().Split();// and array that counting to n
            for (int i = 0; i < n; i++)// we run array to n
            {
                int x; // i=0 arr[0]=x  && n times
                x = int.Parse(arr[i]);// arr[0] we convert this to integer
                Console.Write(x + " " + x + " "); // and simply write this number 2 times

            }
        }
    }
}
