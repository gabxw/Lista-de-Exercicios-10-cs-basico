using System;

namespace Exercicio02
{
    class Program
    {
        static void Main()
        {
            // Passo 1: Criar a matriz 10x10
            int[,] matriz = new int[10, 10];

            // Passo 2: Preencher a matriz
            // Aqui você pode escolher preencher manualmente ou automaticamente
            // Vamos preencher com valores de exemplo para facilitar
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matriz[i, j] = i * 10 + j; // Exemplo de preenchimento
                }
            }

            // Passo 3: Imprimir a diagonal principal
            Console.WriteLine("Elementos da diagonal principal:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }
            Console.ReadKey();
        }
    }
}

