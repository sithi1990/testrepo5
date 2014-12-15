using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Man:IMan
    {
        private string name;
        public Man(string name)
        {
            this.name = name;
        }

        public void PrintAbout()
        {
            Console.WriteLine("I Am +" + name);
        }
    }
}
