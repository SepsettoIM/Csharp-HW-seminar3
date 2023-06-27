// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int arrayLength = 4;
        int[] numbers = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            numbers[i] = random.Next(100, 1000);
        }
        int evenCount = 0;
        for (int i = 0; i < arrayLength; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                evenCount++;
            }
        }
        Console.WriteLine("Массив случайных трехзначных чисел:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
        Console.WriteLine("Количество четных чисел: " + evenCount);
    }
}