using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student
    {
        public string name;
        public string id;
        public Student(string n, string i) //constructor 
        {
            name = n;
            id = i;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"name = {name} id = {id}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            string k;
            Student s = new Student($"Yersultan", "18BD111251");
            Console.WriteLine("Enter the year of study:");
            int y = int.Parse(Console.ReadLine());
            s.PrintInfo();
            Console.WriteLine($"Next year of study is: {y + 1}");
        }
    }
}
