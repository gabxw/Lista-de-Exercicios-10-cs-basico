using System;

class Program
{
    static void Main()
    {
        // Passo 1: Criar a matriz 3x3
        int[,] matriz = new int[3, 3];

        // Passo 2: Preencher a matriz com valores aleatórios entre 1 e 100
        Random random = new Random();

        for (int i = 0; i < 3; i++) // Percorre as linhas
        {
            for (int j = 0; j < 3; j++) // Percorre as colunas
            {
                matriz[i, j] = random.Next(1, 101); // Gera um número aleatório entre 1 e 100
            }
        }

        // Passo 3: Encontrar o maior valor da matriz
        int maior = matriz[0, 0]; // Inicializa com o primeiro elemento da matriz

        for (int i = 0; i < 3; i++) // Percorre as linhas
        {
            for (int j = 0; j < 3; j++) // Percorre as colunas
            {
                if (matriz[i, j] > maior) // Verifica se o elemento atual é maior
                {
                    maior = matriz[i, j]; // Atualiza o maior valor
                }
            }
        }

        // Passo 4: Exibir a matriz e o maior valor
        Console.WriteLine("Matriz gerada:");
        for (int i = 0; i < 3; i++) // Percorre as linhas
        {
            for (int j = 0; j < 3; j++) // Percorre as colunas
            {
                Console.Write(matriz[i, j] + "\t"); // Exibe cada elemento
            }
            Console.WriteLine(); // Pula para a próxima linha
        }

        Console.WriteLine($"\nO maior valor da matriz é: {maior}");
        Console.ReadKey();
    }
}