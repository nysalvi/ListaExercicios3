using System;

namespace E5
{
    /* Escreva um algoritmo que leia um valor inicial A e imprima a sequência de
    valores do cálculo de A! e o seu resultado.
    Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
    • Pesquise sobre “fatorial”*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um valor e será calculado o seu fatorial : ");
            int A = int.Parse(Console.ReadLine());            
            string resul = A + "! = " + A;
            for (int i = A - 1; i > 0; i--)
            {
                A *= i;
                resul += " X " + i;
            }
            Console.WriteLine(resul + " = " + A);
            Console.ReadLine();
        }        
    }
}
