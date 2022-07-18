using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndObject
{
    class ClassWork
    {
        public int id;
        public string name;
        public int marks;
        static void Main(string[] args)
        {
            ClassWork cw = new ClassWork();
            cw.id = 12;
            cw.name = "Swaraj";
            cw.marks = 79;


            ClassWork w = new ClassWork();
            w.id = 11;
            w.name = " Suraj";
            w.marks = 69;
            Console.WriteLine("1st student details are \n ID---> " + cw.id + " \n Name---> " + cw.name + " \n Marks---> " + cw.marks);

            Console.WriteLine("2nd students details are \n ID---> " + w.id + " \n Name---> " + w.name + " \n Marks---> " + w.marks);
        }
    }
    class StudInfo
    {
        static void Main(string[] args)
        {
            ClassWork c;
            c= new ClassWork();
            c.id = 09;
            c.name = "Anuj";
            c.marks = 46;
            Console.WriteLine(c.id+" "+c.name+" "+c.marks);
        }
    }class MethodDemo
    {
        //1. No return type no parameter
        public void Show()
        {
            Console.WriteLine(" Show method");//method defination/body
        }
        //2. No return type with parameter
        public void Addition(int a,int b,double c)
        {
           // double add = a + b + c;
           // return add;
            Console.WriteLine(" Addition = "+(a+b+c));
        }
        //3. With return type no parameter
        public double Area()
        {
            double area = 3.14 * 4 * 4;
            return area;
        }
        // 4. with return type and with parameter
        public float Calculate(int a, float b)
        {
            float ans = a* b;
            return ans;
        }

        static void Main(string[] args)
        {
            MethodDemo md = new MethodDemo();
            md.Show();
           md.Addition(4, 5, 8.2d);
            //double add = md.Addition(4, 5, 4.3);
            //Console.WriteLine("addition "+add);
           double result= md.Area();
            Console.WriteLine("Area of circle is "+md.Area());
            float ans =md.Calculate(9, 4.5f);
            Console.WriteLine("multiplication of two numbers is "+ans);
            Console.WriteLine();
        }



    }
}
