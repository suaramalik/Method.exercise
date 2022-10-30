using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class exerciseclass
    {
        public static string Name(string a, string b =" hello  ")
        {
            string c= b+a;
            return c;
        }
        public static void BiggerNumber(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("A is the biggest number");
            }
            else
            {
                Console.WriteLine("B is the biggest number");
            }
        }
         public static int   DigitWord(int a)
            {
                int b = a % 10;
                switch(b)
                {
                    case 0: Console.WriteLine("zero");break;
                    case 1: Console.WriteLine("one");break;
                    case 2:Console.WriteLine("two");break;
                    case 3:Console.WriteLine("three");break;
                    case 4:Console.WriteLine("four");break;
                    case 5:Console.WriteLine("five");break;
                    case 6:Console.WriteLine("six");break;
                    case 7:Console.WriteLine("seven");break;
                    case 8:Console.WriteLine("eight");break;
                    case 9:Console.WriteLine("nine");break;
                    default:Console.WriteLine("error");break;
                }  
            return b;
            
        }
    }
}
