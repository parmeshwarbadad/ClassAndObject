using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndObject
{
    class Student
    {
        int sid;
        string sname;
        int s1marks;
        int s2marks;
        int s3marks;

        public void AcceptDetails(int id,string name,int s1, int s2, int s3 )
        {
            sid = id;
            sname = name;
            s1marks = s1;
            s2marks = s2;
            s3marks = s3;

        }

        public void CalculatePercentageOfStudent()
        {
            double per = (s1marks +s2marks + s3marks) / 3;
            Console.WriteLine(" Percentage of student is: "+ per);
        }
        public void DisplayStudnetDetails()
        {
            Console.WriteLine("  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ");
            Console.WriteLine();
            Console.WriteLine("     Student Details   ");
            Console.WriteLine("     Id   : " + sid);
            Console.WriteLine("     Name : " + sname);
            Console.WriteLine("     Marks in s1 Sub  : "+ s1marks);
            Console.WriteLine("     Marks in s2 Sub  : "+ s2marks);
            Console.WriteLine("     Marks in s3 Sub  : "+ s3marks);
            Console.WriteLine();
            Console.WriteLine("  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ");
        }

        static void Main(string[] args)
        {
            Student s = new Student();
            s.AcceptDetails(1, "Param", 97, 98, 99);
            s.DisplayStudnetDetails();
            s.CalculatePercentageOfStudent();

        }
    }
}
