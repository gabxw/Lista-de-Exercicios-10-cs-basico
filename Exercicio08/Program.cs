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
            }
        }

        
        int somaDiagonalPrincipal = 0;
        for (int i = 0; i < 10; i++)
        {
            somaDiagonalPrincipal += matriz[i, i]; 
        }
        double mediaDiagonalPrincipal = (double)somaDiagonalPrincipal / 10;

        
        int somaDiagonalSecundaria = 0;
        for (int i = 0; i < 10; i++)
        {
            somaDiagonalSecundaria += matriz[i, 9 - i]; 
        }
        double mediaDiagonalSecundaria = (double)somaDiagonalSecundaria / 10;

        
        for (int i = 0; i < 10; i++) 
        {
            for (int j = 0; j < 10; j++) 
            {
                Console.Write(matriz[i, j].ToString().PadLeft(4) + " "); 
            }
            Console.WriteLine(); 
        }

        Console.WriteLine("\nResultados:");
        Console.WriteLine($"Soma da diagonal principal: {somaDiagonalPrincipal}");
        Console.WriteLine($"Média da diagonal principal: {mediaDiagonalPrincipal:F2}");
        Console.WriteLine($"Soma da diagonal secundária: {somaDiagonalSecundaria}");
        Console.WriteLine($"Média da diagonal secundária: {mediaDiagonalSecundaria:F2}");
        Console.ReadKey();
    }
}