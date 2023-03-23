using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    internal static class Operations
    {
        public static decimal Pow(int a, int s)
        {
            if (s != 0)
            {
                for (int i = 1; i <= s; i++)
                { a *= a; }
            }
            else
            { a = 1; }
            return a;
        }
        public static decimal Abs(int a) 
        {
            if (a >=0 )
            { return a; }
            else
            { a = -(a);
                return a;}
        }

    }
}
