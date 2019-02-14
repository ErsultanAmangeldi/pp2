using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Acer\Desktop\Aktore\ДЧС\Кравцов");//this is directory i want to show;
            PrintInfo(dir, 0);
        }
        static void PrintInfo(FileSystemInfo fsi, int k)
        {
            string s = new string(' ', k);
            Console.WriteLine(s + fsi.Name);
            if (fsi.GetType() == typeof(DirectoryInfo))// if it's have an directory also in it
            {
                FileSystemInfo[] arr = ((DirectoryInfo)fsi).GetFileSystemInfos();
                for(int i = 0; i < arr.Length; i++)
                {
                    PrintInfo(arr[i], k + 3);// and 3 ' ' before new directory files
                }
            }
 
        }
    }
}
