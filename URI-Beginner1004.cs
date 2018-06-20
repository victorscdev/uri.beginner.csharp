using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_Beginner1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, PROD;
            string str1, str2;

            str1 = Console.ReadLine();
            str2 = Console.ReadLine();

            A = Int32.Parse(str1);
            B = Int32.Parse(str2);
            PROD = A * B;

            Console.WriteLine("PROD = " + PROD);
            Console.ReadKey();
        }
    }
}
