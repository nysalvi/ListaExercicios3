using System;

namespace E3
{
    internal class Program
    {
        /*• Desenvolver um algoritmo que efetue a soma de todos os números
    ímpares que são múltiplos de três e que se encontram no conjunto dos
    números de 1 até 500.*/
        static void Main(string[] args)
        {
            int soma = 0;
            for (int i = 1; i < 501; i++)
            {
                if (i % 3 == 0 && i % 2 == 1)
                    soma+= i;
            }
            Console.WriteLine("A soma dos números múltiplos de 3 entre 1 - 500 é : " + soma);
            Console.ReadLine();
        }
    }
}
