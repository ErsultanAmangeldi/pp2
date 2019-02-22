using System;
using System.IO;
using System.Xml.Serialization;


namespace Task2._1
{
    public class Mark // create class num;
    {
        public int num;
        public string ltr;
        public void getLetter() //create function getLetter
        {
            if (num <= 100 && num >= 95)
                ltr += "A+";
            if (num < 95 && num >= 90)
                ltr += "A-";
        }
        public override string ToString()
        {
            return ltr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            F1();//we call function;
        }
        public static void F1()
        {
            Mark m = new Mark();// according to the characteristics of class Mark we create  ;
            m.num = int.Parse(Console.ReadLine());// first chararteristic is num
            m.getLetter();// we check it and give char;
            Console.WriteLine(m);// we will print Mark in Console using to string 

            FileStream fs = new FileStream("mark.txt", FileMode.Create, FileAccess.Write);// open file that we will serialize
            XmlSerializer xs = new XmlSerializer(typeof(Mark));

            xs.Serialize(fs, m);//serializing;
            fs.Close();


        }
    }
}
