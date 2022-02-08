using System;

namespace E2
{
    internal class Program
    {
        /*• Escrever um algoritmo que gera e escreve os números ímpares entre 100
        e 200.  */

        static void Main(string[] args)
        {
            Console.WriteLine("Lista de números ímpares entre 100 - 200 : ");
            for (int i = 100; i < 200; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine("\tO número " + i + " é impar !");
            }
            Console.ReadLine();
        }
    }
}
