using System;

namespace Task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            int sum = 0;
            int composition = 1;
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(1, 20);
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {                
                sum += array[1, i];
            }

            for (int i = 0; i < array.GetLength(1); i++)
            {
                composition *= array[i, 0];
            }

            Console.WriteLine($"сумма второй строки {sum}.");
            Console.WriteLine($"произведение первого столбца {composition}.");
            Console.ReadKey();
        }
    }
}
