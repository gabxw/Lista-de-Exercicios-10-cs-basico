using System;

class Program
{
    static void Main()
    {
        string[] lojas = new string[8] { "Nike", "Adidas", "Puma", "New Balance", "Zara", "Lacoste", "Renner", "Riachuelo" };
        string[] produtos = new string[4] { "Tênis", "Roupa", "Casaco", "Boné" };     
        int[,] preco = new int[8, 4];

        Random random = new Random();
        for (int i = 0; i < preco.GetLength(0); i++) 
        {
            for (int j = 0; j < preco.GetLength(1); j++) 
            {
                preco[i, j] = random.Next(1, 301); 
            }
        }
       
        Console.WriteLine("Relações (Produto - Loja - Preço) com preço até R$ 120,00:");
        for (int i = 0; i < preco.GetLength(0); i++) 
        {
            for (int j = 0; j < preco.GetLength(1); j++)
            {
                if (preco[i, j] <= 120) 
                {
                    Console.WriteLine($"{produtos[j]} - {lojas[i]} - R$ {preco[i, j]}");
                }
            }
        }

        Console.ReadKey();
    }
}