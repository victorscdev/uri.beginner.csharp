using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// A Hello World! program in C#.
//console.writeline(print dos comandos)
//console(usar o terminal)

using System;
namespace escolha_variavel
{
    class Hello
    {
        static void Main()
        {

            String linha1 = Console.ReadLine();
            String linha2 = Console.ReadLine();

            int a = Int32.Parse(linha1);
            int b = Int32.Parse(linha2);
            int soma = a + b;

            Console.WriteLine("X = " + soma);

        }
    }
}
