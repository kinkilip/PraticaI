using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//EJERCICIO#6
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdusca el primer valor: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Introdusca el segundo valor: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Clear();
            int producto = n1 * n2;
            Console.WriteLine("el producto de la eleccion es: {0}", producto);
            Console.ReadKey();
        }
    }
}
