using System;

class Program
{
    static void Main()
    {
       
        int[,] matriz = new int[4, 4];

       
        Random random = new Random();

        for (int i = 0; i < 4; i++) 
        {
            for (int j = 0; j < 4; j++) 
            {
                matriz[i, j] = random.Next(1, 101); 
            }
        }

        for (int i = 0; i < 4; i++) 
        {
            for (int j = 0; j < 4; j++) 
            {
                if(matriz[i, j] % 2 == 0) 
                {
                    Console.Write(matriz[i, j] + "\t"); 
                }
                else
                {
                    Console.Write("-\t"); 
                }
            }
        Console.ReadKey();
        }
    }
}