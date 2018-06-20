using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_Beginner1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("MEDIA = " + ((x * 3.5 + y * 7.5) / (3.5 + 7.5)).ToString("0.00000"));
            Console.ReadKey();
        }
    }
}
