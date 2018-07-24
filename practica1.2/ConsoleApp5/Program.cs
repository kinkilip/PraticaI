using System;

    class Program
    //EJERCICIO#2
    {
    static void Main(string[] args)
    {
        Console.Write("ingrese un valor: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Clear();
        //usé el operador de módulo pues todo # par es divicible entre 2 y su resto siempre será 0.
        if (numero % 2 == 0)
        {
            Console.WriteLine("el numero ingresado es par");
        }
        else
        {
            Console.WriteLine("El numero ingresado es impar");
        }
        Console.ReadKey();
    }
       
    }

