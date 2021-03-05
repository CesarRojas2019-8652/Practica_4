using System;


namespace Practica_04_ejercicio_3 
{
    class Program
    {
        
            public static void Main()
            {
                Console.WriteLine("programa que diga los dias que tiene cada mes y lo muestre en pantalla");
            int[]
             meses = { 31,28,31,30,31,30,31,31,30,31,30,31};
            string[] Mes =
                {
                "Enero",
                "Febrero",
                "Marzo",
                "Abri",
                "Mayo",
                "Junio",
                "Julio",
                "Agosto",
                "Septiembre",
                "Octubre",
                "Noviembre",
                "Diciembre"
            };
            Console.Clear();

            int M = 0;
            Console.WriteLine("coloque el numero del mes osea que el 1 es igual a enero");
            M = Convert.ToInt32(Console.ReadLine());
            int SE = M - 1;
            Console.WriteLine("El mes que seleccionó es: {0}\n Y este mes posee: {1} dias\n ", Mes[SE], meses[SE]);
            Console.ReadKey();
        }
    }
    }

    

