using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Employee : IComparable<Employee>
    {

        public Employee(int empid,string name, int salary)
        {
            this.empid = empid;
            this.name = name;
            this.salary = salary;
        }
        public Employee()
        {
           
        }
        private int empid;

        

        
        public int EmpID
        {
            get { return empid; }
            set { empid = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set 
            {
                if (value == null || value == "")
                {
                    throw new Exception("Please Enter Value");
                }
                else
                {
                    name = value; 
                }
                
            }
        }

        private int salary;

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public override string ToString()
        {
            return String.Format("Object Contains : ID :{0}, Name : {1}, Salary :{2}", this.EmpID, this.Name, this.Salary);
        }

        public override bool Equals(object obj)
        {
            if(obj is Employee)
            {
                Employee e = (Employee)obj;
                if (this.EmpID == e.EmpID && this.Name == e.Name && this.Salary == e.Salary)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           return false;
            
            
            
               //return base.Equals(obj);
        }






        public int CompareTo(Employee obj)
        {
            return this.EmpID - obj.EmpID;
        }
    }
}
