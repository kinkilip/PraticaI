using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//EJERCICIO#7

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdusca el primer valor: ");
            float dato1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Introdusca el segundo valor: ");
            float dato2 = int.Parse(Console.ReadLine());
            Console.Clear();
            float cociente = dato1 / dato2;
            if (dato2 == 0)
            {
                Console.WriteLine("Error al introducir valores");
            }
            else
            {
                Console.WriteLine("El cociente entre estos dos valores es: {0}", cociente);
            }
            Console.ReadKey();
        }
    }
}
