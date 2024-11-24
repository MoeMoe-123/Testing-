using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Day 1");

            byte age = 253;
            byte day = 22;
            Console.WriteLine(age);
            Console.WriteLine(day);

            double dou = 76.123;
            float flo = 76.123f;
            decimal dec = 76.123m;
            Console.WriteLine(dou);
            Console.WriteLine(flo);
            Console.WriteLine(dec);

            //boolean 
            bool bol=true;
            Console.WriteLine(bol);

            DateTime dt=DateTime.Now;
            Console.WriteLine(dt);
            DateTime dt1 = DateTime.Now.Date;
            Console.WriteLine(dt1);
            DateTime dt2 = DateTime.Now.Date;
            Console.WriteLine(dt2.ToString("dd/mmm/yyyy"));

        }
    }
}
