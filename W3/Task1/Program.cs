using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace farmanager
{
    class FarManager
    {
        public int cursor;
        public string path;
        public int sz;
        public bool ok;
        DirectoryInfo directory = null;
        FileSystemInfo currentFs = null;


        public FarManager()
        {
            cursor = 0;
        }
        public FarManager(string path)
        {
            this.path = path;// this why?
            cursor = 0;
            directory = new DirectoryInfo(path);
            sz = directory.GetFileSystemInfos().Length;
            ok = true;// bool why/
        }


        public void Color(FileSystemInfo fs,int index)// index how to runs firstly
        {
            if (cursor == index)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else if (fs.GetType() == typeof(DirectoryInfo))
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.Green;

            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

            }
        }


        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();//why
            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();//[]
            for (int i = 0, k = 0; i < fs.Length; i++)//k?
            {
                if (ok == false && fs[i].Name[0] == '.')
                {
                    continue;
                }
                Color(fs[i], k);
                Console.WriteLine(fs[i].Name);
                k++;//k=???
            }

        }


        public void Up()
        {
            cursor--;
            if (cursor < 0)
                cursor = sz - 1;
           
           
        }
         public void Down()
        {
            cursor++;
            if (cursor == sz)
                cursor = 0;
        }



        public void Calcsz()
        {
            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            sz = fs.Length;
            if (ok == false)
                for (int i = 0; i < fs.Length; i++)
                    if (fs[i].Name[0] == '.')
                        sz--;
        }



        public void Start()
        {
            ConsoleKeyInfo consolekey = Console.ReadKey();

            while (consolekey.Key != ConsoleKey.Escape)
            {
                Calcsz();

                Show();

                consolekey = Console.ReadKey();

                if (consolekey.Key == ConsoleKey.UpArrow)
                {
                    Up();
                }
                if (consolekey.Key == ConsoleKey.DownArrow)
                {
                    Down();
                }
                if (consolekey.Key == ConsoleKey.RightArrow)
                {
                    ok = false;
                    cursor = 0;
                }
                if (consolekey.Key == ConsoleKey.LeftArrow)
                {
                    cursor = 0;
                    ok = true;
                }
                if (consolekey.Key == ConsoleKey.Enter)
                {
                    if (currentFs.GetType() == typeof(DirectoryInfo))
                    {
                        cursor = 0;
                        path = currentFs.FullName;

                    }
                }
                if (consolekey.Key == ConsoleKey.Backspace)
                {
                    cursor = 0;
                    path = directory.Parent.FullName;
                }

            }
        }

    }
    
    class Program
    {

        static void Main(string[] args)
        {
            string path = "C:/Users/Acer/source/repos/Lab2";
            FarManager farmanager = new FarManager(path);
            farmanager.Start();
        }
    }
}
