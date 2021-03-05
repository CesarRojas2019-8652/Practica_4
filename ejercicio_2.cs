//programa que pida al usuario 5 números reales(pista: necesitarás un array de "float") y luego los muestre en el orden contrario al que se introdujeron.
using System;


namespace practica_4_ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {

            float[] Numeros = new float[5];
            Console.Clear();
            for (int i = 0; i <= 4; i++)
            {
                int M = 1 + i;
                Console.WriteLine("Ingrese un numero {0} ", M);
                Numeros[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
  
            for (int i = 4; i >= 0; i--)
            {
                int M = 1 + i;
                Console.WriteLine(" El numero: " + M + "[" + Numeros[i] + "] ");
                Console.ReadKey();
            }

        }
    }
}
