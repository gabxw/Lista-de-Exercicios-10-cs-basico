using System;

class Program
{
    static void Main()
    {
        // Passo 1: Criar a matriz 10x10
        int[,] matriz = new int[10, 10];

        // Passo 2: Ler os elementos da matriz
        Console.WriteLine("Digite os elementos da matriz 10x10:");
        for (int i = 0; i < 10; i++) // Percorre as linhas
        {
            for (int j = 0; j < 10; j++) // Percorre as colunas
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine()); // Lê o valor do usuário
            }
        }

        // Passo 3: Exibir a matriz, ignorando a diagonal principal
        Console.WriteLine("\nMatriz 10x10 (exceto diagonal principal):");
        for (int i = 0; i < 10; i++) // Percorre as linhas
        {
            for (int j = 0; j < 10; j++) // Percorre as colunas
            {
                if (i != j) // Ignora a diagonal principal
                {
                    Console.Write(matriz[i, j] + "\t"); // Exibe o elemento
                }
                else
                {
                    Console.Write("-\t"); // Exibe um traço para a diagonal principal
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}