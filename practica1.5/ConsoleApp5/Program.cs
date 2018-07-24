using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EJERCICIO#5
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 80, y = 30, z = 20, a = 90, c = 40, n = 5, promedio;
            promedio = (x + y + z + a + c) / n;
            Console.WriteLine("el promedio obtenido es: {0}", promedio);
            Console.ReadKey();

        }
    }
}
