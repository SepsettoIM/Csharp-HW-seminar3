// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
            numbers[i] = random.Next(1, 100);
        }
        int sum = 0;
        for (int i = 1; i < arrayLength; i += 2)
        {
            sum += numbers[i];
        }
        Console.WriteLine("Массив случайных чисел:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);
    }
}