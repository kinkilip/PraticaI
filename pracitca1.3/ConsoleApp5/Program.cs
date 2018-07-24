using System;
    //EJERCICIO#3
    class Program
    {
    static void Main(string[] args)
    {
        Console.Write("ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());
        if(edad >= 6 && edad < 12)
        {
            Console.WriteLine("su edad correspode a un niño");
        }
        if(edad > 12 && edad <= 20)
        {
            Console.WriteLine("su edad corresponde a un adolescente");
        }
        if(edad > 20 && edad <= 25)
        {
            Console.WriteLine("su edad corresponde a un joven");
        }
        if(edad > 25 && edad <= 60)
        {
            Console.WriteLine("su edad corresponde a una persona adulta");
        }
        if(edad > 60)
        {
            Console.WriteLine("este rango no es valorado en esta aplicacion");
        }
        if (edad < 6)
        {
            Console.WriteLine("este rango no es valorado en esta aplicacion");
        }
        Console.ReadKey();
    }
    
    }

