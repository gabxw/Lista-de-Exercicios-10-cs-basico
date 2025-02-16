using System;

class Program
{
    static void Main()
    {

        int[,] matriz = new int[10, 10];

        Random random = new Random();

        Console.WriteLine("elementos da matriz 10x10:");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matriz[i, j] = random.Next(1, 101);
                Console.Write(matriz[i, j].ToString().PadLeft(4) + " ");
            }
        }


        int soma = 0;
        for (int i = 0; i < 10; i++)
        {
            for(int j = 0; j < 10; j++)
            {
                soma += matriz[i, j];
            }
            
        }


        Console.WriteLine("\nResultado:");
        Console.WriteLine($"Soma: {soma}");
        Console.ReadKey();
    }
}