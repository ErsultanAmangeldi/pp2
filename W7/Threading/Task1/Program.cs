using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread mythread1= new Thread(func);
           mythread1.Start();
            mythread1.Sleep(0);
            
        }

        static void func()
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
                
                Console.Read();
            }
        }
    }
}
