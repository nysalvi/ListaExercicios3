using System;

namespace E1
{
    /*• Desenvolver um algoritmo que leia a altura de 15 pessoas. Este
    programa deverá calcular e mostrar:
    a. A menor altura do grupo;
    b. A maior altura do grupo; */

    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            float[] alturas = new float[15];
            string temp;
            while (contador < 15)
            {
                Console.WriteLine("Digite a altura da pessoa nº" + contador + " : ");
                temp = Console.ReadLine();
                alturas[contador] = float.Parse(temp);
                contador++; 
            }
            Array.Sort(alturas);
            Console.WriteLine("Menor Altura : " + alturas[0]);
            Console.WriteLine("Maior Altura : " + alturas[alturas.Length - 1]);
            Console.ReadLine();
        }
    }
}
