using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_basic
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "a, :, s, d, :, 2, 0, p, q, :";
            Console.WriteLine(x.Replace(":", ";"));
            Console.ReadKey();
        }
    }
}
