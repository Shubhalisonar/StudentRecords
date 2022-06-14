using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecords
{
    public class Student
    {


        private int RollNo;
        private string Name, dept;
        private float Prc;

        public Student()
        {
            RollNo = 0;
            Name = " ";
            dept = " ";
            Prc = 0.0f;

        }
        public Student(int RollNo, String Name, String Dept, float Prc)
        {
            this.RollNo = RollNo;
            this.Name = Name;
            this.dept = Dept;
            this.Prc= Prc;
        }
        public void Display()
        {
            Console.WriteLine($" RollNo : {RollNo}, Name : {Name},Dept : {dept}, Prc : {Prc} ");
        }
        static void Main(string[] args)
        {
            Student stud = new Student(7,"shubhali", "Computer",88.00f);
            stud.Display();
            Console.ReadLine();
        }

    }
}
