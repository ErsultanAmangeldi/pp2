using System;
using System.IO;
using System.Xml.Serialization;

namespace task1
 {
    public class ComplexNumbers//class complex numbers
    {
        public double a;//first variable;
        public double b;//second variable;
        public void PrintInfo()
        {
            Console.WriteLine(a + "+" + b + "i");//this is a formula;
        }
        public void PrintFormula()
        {
            Console.WriteLine("a + bi");
        }
        public ComplexNumbers()//this requires to if u want to serialize;
        {

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


            ComplexNumbers cn = new ComplexNumbers();//according to the characteristics of class Mark we create  ;
            cn.PrintInfo();//this is a solution;
            cn.PrintFormula();//write in console formula


            FileStream fs = new FileStream("cn.txt", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(ComplexNumbers));

            xs.Serialize(fs, cn);//serializing-it's to save ur condition to txt or xml file to network with others in the internet or e.t.c
            fs.Close();

        }
    }
}
