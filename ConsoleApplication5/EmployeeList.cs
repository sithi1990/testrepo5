using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class EmployeeList<Employee>
    {
        private Employee[] array;

        public EmployeeList(int size)
        {
            array = new Employee[size];
        }

        public Employee GetItem(int index)
        {
            return array[index];
        }

        public void AddItem(int index,Employee e)
        {
            array[index] = e;
        }
    }
}
