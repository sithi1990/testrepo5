using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Character
    {
        char[] chars  = new char[24];
        public char[] getCharacters()
        {

            int j = 0;
            for (int i = 65; i<89; i++)
            {
                chars[j]=(char)i;
                j++;
               
            }


            return chars;
        }
        
    }
}
