using System;

namespace Exercicio01
{
    class Program
    {
        static void Main()
        {
            int[,] matriz = { { 1, 3, 4 }, { 4, 6, 8 }, { 3, 9, 3 } };

            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);

            Console.WriteLine("Número de linhas: " + linhas);
            Console.WriteLine("Número de colunas: " + colunas);

            for (int i = 0; i < linhas; i++)
            {
                for (int x = 0; x < colunas; x++)
                {
                    Console.Write(matriz[i, x] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}