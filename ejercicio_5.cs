//programa que prepare espacio para un máximo de 100 nombres. El usuario deberá ir introduciendo un nombre cada vez, hasta que se pulse Intro sin teclear nada, momento en el que dejarán de pedirse más nombres y se mostrará en pantalla la lista de los nombres que se han introducido.
using System;


namespace practica_04_ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Nombres = new string[101];
            Console.WriteLine("Escriba los nombres de la lista, para concluir presione enter estando en blanco");
            int i = -1;

            do
            {
                i++;
                Nombres[i] = Console.ReadLine();
            }
             while (Nombres[i].Length != 0);

            
            Console.Clear();
            Console.WriteLine("Nombres ingresados: ");
            i = -1;

            do
            {
                i++;
                Console.WriteLine(Nombres[i]);
            } while (Nombres[i].Length != 0);

            Console.ReadKey();
        }



            }
        }
    

