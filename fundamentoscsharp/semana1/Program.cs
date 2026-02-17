using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar nombre
        Console.WriteLine("Ingrese su nombre:");
        string nombre = Console.ReadLine();

        // Solicitar edad
        Console.WriteLine("Ingrese su edad:");
        int edad = int.Parse(Console.ReadLine());

        // Mostrar saludo
        Console.WriteLine("Hola " + nombre + ", tienes " + edad + " años.");

        // Operador aritmético (sumar 5 años)
        int edadEnCincoAnios = edad + 5;
        Console.WriteLine("En 5 años tendrás " + edadEnCincoAnios + " años.");

        // Estructura condicional
        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad.");
        }
        else
        {
            Console.WriteLine("Eres menor de edad.");
        }
    }
}
