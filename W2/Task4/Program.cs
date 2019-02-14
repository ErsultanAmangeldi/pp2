using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "Imersik.txt";// name of file that i want to cut
            string path = "C:/Books";// first place where i will cut
            string path1 = "C:/projects";// second place where i will put

            string s = Path.Combine(path, fileName);
            string s1 = Path.Combine(path1, fileName);

            FileStream fs = File.Create(s);
            fs.Close();
            File.Copy(s, s1);
            File.Delete(s);

        }
    }
}
