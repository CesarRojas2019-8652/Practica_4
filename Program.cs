//Crear una clase que permita ingresar valores enteros por teclado y nos muestre la tabla de multiplicar de dicho valor.
using System;


namespace practica_04_ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string linea;
            Console.Write("Ingrese un numero y se mostrará la tabla de multiplicar: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            for (int i = 1; i <= 12; i++)
            {
                Console.Write(i + " x " + n + " = " + i * n + "\n");
            }
            Console.ReadKey();

        }
    }
}