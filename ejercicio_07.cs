//7.	Un programa que te pida tu nombre y lo muestre en pantalla separando cada letra de la siguiente con un espacio. Por ejemplo, si tu nombre es "Moreta", debería aparecer en pantalla "M o r e t a".
using System;


namespace practica_04_ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            {

                string Nombre = "";
                int n;
                Console.Write("Inserte su nombre: ");
                Nombre = Console.ReadLine();
                n = Nombre.Length;
                int c = 0;
                char[,] Letra = new char[n, n];
                foreach (char Letras in Nombre)
                {
                    if (c <= n)
                    {
                        Letra[c, 0] = Letras;
                    }
                    c++;
                }
                c = 0;
                do
                {
                    Console.Write("{0} ", Letra[c, 0]);
                    c++;
                } while (c <= n - 1);
                Console.ReadKey();
            } 
        }
    }
}
