using System;

namespace NewC_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int lengthArray = 10;
            int heightArray = 10;
            int wildcardNumbers = 0;
            int minRandomNumbers = 1;
            int maxRandomNumbers = 100;
            int maxNumbers = int.MinValue;

            int[,] numbers = new int[lengthArray, heightArray];

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(minRandomNumbers, maxRandomNumbers);
                    Console.Write($"{numbers[i, j]} ");

                    if (maxNumbers < numbers[i, j])
                        maxNumbers = numbers[i, j];
                }

                Console.WriteLine();
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (maxNumbers == numbers[i, j])
                        numbers[i, j] = wildcardNumbers;

                    Console.Write($"{numbers[i, j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}