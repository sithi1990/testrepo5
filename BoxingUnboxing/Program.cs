using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Boxing

            int x = 10;
            object o = x;

           
            
            Console.WriteLine(Object.ReferenceEquals(x,o));
            Console.WriteLine(o);

            //unboxing
            int y = (int)o;
            Console.WriteLine(y);

            Console.ReadLine();

        }
    }
}
