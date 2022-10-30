using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method.exercise
{
    public class Exercise1
    {
        public int Add(int a, int b)
        {
            int c = a + b;

            return c;
        }
        public int Add(int x, int y, int z)
        {
            int e = x + y + z;
            return e;
        }
        public double Add(double r, double p = 3)
        {
            double q = p + r;
            return q;
        }
        public static void Average(int a, int b, int c)
        {
            int d = (a + b + c) / 3;
            Console.WriteLine(d);
        }
        
    }    
}
