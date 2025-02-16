using System;

namespace Exercicio05
{
    class Program
    {
        static void Main()
        {
            // Passo 1: Criar a matriz 2x2
            double[,] matriz = new double[2, 2];

            // Passo 2: Preencher a matriz com valores aleatórios entre 1 e 10
            Random random = new Random();

            for (int i = 0; i < 2; i++) // Percorre as linhas
            {
                for (int j = 0; j < 2; j++) // Percorre as colunas
                {
                    matriz[i, j] = random.Next(1, 11); // Gera um número aleatório entre 1 e 10
                }
            }

            // Passo 3: Calcular a soma dos elementos da matriz
            double soma = 0;

            for (int i = 0; i < 2; i++) // Percorre as linhas
            {
                for (int j = 0; j < 2; j++) // Percorre as colunas
                {
                    soma += matriz[i, j]; // Acumula a soma dos elementos
                }
            }

            // Passo 4: Calcular a média dos elementos da matriz
            double media = soma / (matriz.GetLength(0) * matriz.GetLength(1));

            // Passo 5: Exibir a matriz e a média
            Console.WriteLine("Matriz gerada:");
            for (int i = 0; i < 2; i++) // Percorre as linhas
            {
                for (int j = 0; j < 2; j++) // Percorre as colunas
                {
                    Console.Write(matriz[i, j] + "\t"); // Exibe cada elemento
                }
                Console.WriteLine(); // Pula para a próxima linha
            }

            Console.WriteLine($"\nSoma dos elementos da matriz: {soma}");
            Console.WriteLine($"Média dos elementos da matriz: {media}");
            Console.ReadKey();
        }
    }
}