using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfParameters
{
     class Program
    {
        static void Change(int x)
        {
            x = 100;
            Console.WriteLine(x);
        }
        static void Change2(ref int a)
        {
            a = 500;
            Console.WriteLine(a);
        }
        static void Change3(out int x, out int y)
        {
            x = 10;
            y = 20;

        }
        static void Main(string[] args)
        {
            //call by value
            int y = 200;
            Change(y);
            Console.WriteLine(y);

            int b = 600;
            Change2(ref b);
            Console.WriteLine(b);

            int n = 50;
            int p;
            Change3(out n, out p);
            Console.WriteLine(n);
            Console.WriteLine(p);
            Console.ReadLine();

        }
    }
}
