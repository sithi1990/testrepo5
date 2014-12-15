using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Student : Man
    {
        private string school;

        public Student(string name,string school):base(name)
        {
            this.school = school;
        }
        public string getSchool()
        {
            return school;
        }
        public new void PrintAbout()
        {
            base.PrintAbout();
            Console.WriteLine("My School is :" + school); 
        }
    }
}
