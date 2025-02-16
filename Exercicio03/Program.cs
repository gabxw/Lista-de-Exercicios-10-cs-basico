using System;

namespace Exercico04
{
    class Program
    {
        static void Main()
        {
            int[,] matriz = new int[4, 2];

            Random random = new Random();

            for(int i = 0; i < 4; i++)
            {
                for(int x = 0; x < 2; x++)
                {
                    matriz[i, x] = random.Next(1, 11);
                }
            }

            int soma = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int x = 0; x < 2; x++)
                {
                    soma += matriz[i, x];
                }
            }
            Console.Write("Matriz gerada: ");
            for (int i = 0; i < 4; i++)
            {
                for (int x = 0; x < 2; x++)
                {
                    Console.Write(matriz[i, x] + " ");
                }
            }
            Console.Write($"\nValor da soma da matriz: {soma}");
            Console.ReadKey();
        }
    }
}