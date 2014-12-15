using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Circle
    {
        private float _D;

        public float Radius
        {
            get { return _D; }
            set { _D = value; }
        }
        
        public float getArea()
        {
            return (float)Math.PI * _D * _D / 4;
        }

    }
    
}
