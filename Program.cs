using System;


namespace practica_04_ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                
                double[] numeros = new double[4]; 
                double suma = 0; 
                double media; 
                Console.WriteLine("este programa captura 4 numeros por teclado, despues muestra en pantalla la media y los numeros"); 
                                                                                                                                                                      
                for (int c = 0; c < 4; c++)
                {
                    Console.Write("Introduzca el valor {0}: ", c + 1); 
                    numeros[c] = Convert.ToDouble(Console.ReadLine()); 
                    suma += numeros[c]; 
                }
                media = suma / 4;
                Console.Write("\nLos numeros introducidos fueron: "); 
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(" ({0}) ", numeros[c]); 
                }
                Console.Write("\nLa media aritmetica es: {0}", media);
            Console.ReadKey();

        }
    }
}
    

