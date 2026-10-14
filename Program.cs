using System;
using System.Text;

namespace Lab3_Dyachenko
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Random rand = new();

            Console.WriteLine("=== Завдання 1: Сума елементів на непарних позиціях ===");
            Console.Write("Введіть кількість елементів послідовності: ");
            int seqLength = int.Parse(Console.ReadLine()!);

            int[] sequence = new int[seqLength];
            int sumOddPositions = 0;

            Console.WriteLine("Згенерована послідовність:");
            for (int i = 0; i < seqLength; i++)
            {
                sequence[i] = rand.Next(1, 50);
                Console.Write(sequence[i] + " ");

                {
                    sumOddPositions += sequence[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Сума елементів на непарних позиціях: {sumOddPositions}");
            Console.WriteLine();





            Console.WriteLine("=== Завдання 2: Кількість нульових елементів у масиві ===");
            Console.Write("Введіть розмір масиву: ");
            int n = int.Parse(Console.ReadLine()!);

            int[] array = new int[n];
            int zeroCount = 0;

            Console.WriteLine("Згенерований масив:");
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(-3, 4);
                Console.Write(array[i] + " ");

                if (array[i] == 0)
                {
                    zeroCount++;
                }
            }
            Console.WriteLine();

            Console.WriteLine($"Кількість нульових елементів: {zeroCount}");

            Console.ReadLine();
        }
    }
}
