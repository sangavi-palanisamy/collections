using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public delegate void delname(int total);
    class students
    {
        
        public void method(int a)
        {
            int avg = a / 2;
            Console.WriteLine(avg);
        }
        public void method1(int s)
        {
            int avg = s/ 5;
            Console.WriteLine(avg);
        }
        public void method2(int e)
        {
            int avg = e / 10;
            Console.WriteLine(avg);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            students ob = new students();
            delname del;
            /*del = ob.method;
            del(15);
            del = ob.method1;
            del(9);*/
            del = ob.method;
            del =del+ ob.method1;
            del = del + ob.method2;
            del(20);

            Console.ReadKey();


        }
    }
}
