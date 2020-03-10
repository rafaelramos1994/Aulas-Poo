using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();

            Console.WriteLine("Digite os numeros para somar ");
            c.addnumero(Convert.ToDouble(Console.ReadLine()));
            c.addnumero(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine(c.somar());

            Console.WriteLine("Digite os numeros para subitrair ");
            c.addnumero(Convert.ToDouble(Console.ReadLine()));
            c.addnumero(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine(c.subtrair());

            Console.WriteLine("Digite os numeros para multiplicar ");
            c.addnumero(Convert.ToDouble(Console.ReadLine()));
            c.addnumero(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine(c.mult());

            Console.WriteLine("Digite os numeros para dividir ");
            c.addnumero(Convert.ToDouble(Console.ReadLine()));
            c.addnumero(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine(c.divisao());

            Console.ReadKey();
        }
    }
}
