using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//PRACTICA#11
namespace ConsoleApp5
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Cual tabla quiere consultar: ");
            int x = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("hasta que numero la decea consultar: ");
            int y = int.Parse(Console.ReadLine());
            Console.Clear();
            int z = 1, r;
            while (z <= y)
            {
                r = x * z;
                Console.WriteLine("{0} x {1} = {2}", x, z, r);
                z = z + 1;
              
            }
            Console.ReadKey();
        }
    
      
    

    } 
}
