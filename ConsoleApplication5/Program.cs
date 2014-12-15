using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        private const int n = 100;
        static IMan[] mans = new IMan[n];
        
        static void Main(string[] args)
        {
            ////seed();
            ////for (int i = 0; i < n; i++)
            //{
            //  mans[i].PrintAbout();
            //}
            //print();
            //checkNullable();

            //Test1();
           // double x = 10;
           // Double oo = new Double();

           //Console.WriteLine(oo.ToString());
            //testBoxing();
            //ListExample();
            testExtentionMethod();
            Console.ReadLine();
            //print();
           
            
            
        }

        private static void testBoxing()
        {
            
            int x = 10;
            TestBoxing tb = new TestBoxing();
            tb.doAction(x);
            Console.WriteLine(x.ToString());
        }
        public static  void seed()
        {
            for(int i=0; i<n;i++)
            {
                mans[i] = new Man("Man " + i);
            }
        }

        private static void print()
        {
            //Employee e = new Employee(1, "Emp 1", 10000);
            //Employee e2 = new Employee(1, "Emp 1", 10000);

            //Employee e3 = e2;

           // Console.WriteLine(e.Equals(e2));

            //Console.WriteLine(e2.Equals(e3));

            EmployeeList<Employee> emps = new EmployeeList<Employee>(5);
            emps.AddItem(0, new Employee(1, "Emp 1", 1000));
            emps.AddItem(1, new Employee(2, "Emp 2", 2000));
            emps.AddItem(2, new Employee(3, "Emp 3", 3000));
            emps.AddItem(3, new Employee(4, "Emp 4", 4000));
            emps.AddItem(4, new Employee(5, "Emp 5", 5000));

            for (int i = 0; i < 5;i++ )
            {
                Console.WriteLine(emps.GetItem(i));
            }
        }

        private static void checkNullable()
        {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.3234;
            bool? boolval = new bool?();
            Console.WriteLine("{0} , {1} , {2} , {3}, {4}", num1 ?? 1, num2, num3, num4,boolval ?? false);
        }

        private static void Test1()
        {
            try
            {
                Employee e = new Employee();
                e.Name = "gdfgdfg";
                Console.WriteLine(e.Name);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }


        private void LambdaEcpression()
        {
            List<int> elements = new List<int>() { 10,20,30,40};
            int OddIndex = elements.FindIndex(x => x % 2 == 0);
            Console.WriteLine(OddIndex);
        }

        private static void ListExample()
        {
            List<Employee> emps = new List<Employee>();
            emps.Add(new Employee(6, "Emp 6", 1000));
            emps.Add(new Employee(2, "Emp 7", 2000));
            emps.Add(new Employee(3, "Emp 3", 3000));
            emps.Add(new Employee(4, "Emp 4", 4000));
            emps.Add(new Employee(5, "Emp 5", 5000));
            //emps.Sort();
            //IEnumerator<Employee> enamurator = emps.GetEnumerator();
            EmployeeNamComparer namecomp = new EmployeeNamComparer();
            emps.Sort(namecomp);
            //while(enamurator.MoveNext())
            //{
               // Console.WriteLine(enamurator.Current);
           // }

           // emps.OrderBy(c => c.Name);

            foreach(Employee emp in emps)
            {
                Console.WriteLine(emp);
            }
        }

        private static void testExtentionMethod()
        {
            string userSentance = string.Empty;
            int totalWords = 0;
            int totalCharWithoutSpace = 0;
            Console.WriteLine("Enter the your sentance");
            userSentance = Console.ReadLine();

            //calling Extension Method to count character
            totalCharWithoutSpace = userSentance.TotalCharWithoutSpace();
            Console.WriteLine("Total number of character is :" + totalCharWithoutSpace);
            Console.ReadKey();
        }
       
    }
}
