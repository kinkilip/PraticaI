using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//PRACTICA#10
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0 - 1;
            int B = 0;
            int C = 0;
            int Z = 0;

            do
            {

                A = A + 1;
                Console.Write("intraduscar un valor: ");
                B = int.Parse(Console.ReadLine());
                Console.Clear();
                C = Z + B;
                Z = C;
                C = 0;

            }
            while (B > 0);
            {
                Console.WriteLine("has introducido {0} cantidad de numenros y suman {1}", A, Z);
            }
            Console.ReadKey();
            
           }
    }
}
