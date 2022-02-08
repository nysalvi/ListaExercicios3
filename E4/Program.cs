using System;

namespace E4
{
    internal class Program
    {
        /*• Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e
    calcule a tabuada de N.
    • Mostre a tabuada na forma: 0 x N = 0, 1 x N = 1N, 2 x N = 2N, ..., 10 x N =
    10N*/

        static void Main(string[] args)
        {
            int n, resul;

            while (true)
            {
                Console.WriteLine("Digite um valor entre 1 e 10 : ");
                n = int.Parse(Console.ReadLine());
                if (n > 0 && n < 11)
                {
                    for (int i = 0; i < 11; i++)
                    {
                        resul = i * n;
                        Console.Write(i + " * " + n + " = " + resul + ", ");
                    }
                    break;
                }                    
            }
            Console.ReadLine();
        }
    }
}
