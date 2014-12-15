using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public static class Extention
    {
        public static int TotalCharWithoutSpace(this string str)
        {
            int totalCharWithoutSpace = 0;
            string[] userString = str.Split(' ');
            foreach (string stringValue in userString)
            {
                totalCharWithoutSpace += stringValue.Length;
            }
            return totalCharWithoutSpace;
        }
    }
}
