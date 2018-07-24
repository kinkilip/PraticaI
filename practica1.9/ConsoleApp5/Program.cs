using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//EJERCICIO#9
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

             int x = 2;
             while (x != 0)
            {
                Console.Write("Seleccione un numero entero: ");
                x = int.Parse(Console.ReadLine());
                Console.Clear();
                                                              
              if(x != 0 && x % 2 == 0)
                {
                    Console.WriteLine("su eleccion fue un numero par");                    
                }

              if(x != 0 && x % 2 != 0)
                {
                    Console.WriteLine("su eleccion fue un numero impar");
                }
                                                     
            }
              
            Console.ReadKey();
        }
    }
}
