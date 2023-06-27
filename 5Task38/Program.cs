// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

using System;

class Program
{
    static void Main()
    {
        double[] numbers = { 3.14, 2.71, 1.618, 0.577, 2.718 };
        double maxNumber = numbers[0];
        double minNumber = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }
            if (numbers[i] < minNumber)
            {
                minNumber = numbers[i];
            }
        }
        double difference = maxNumber - minNumber;
        Console.WriteLine("Массив вещественных чисел:");
        foreach (double number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
    }
}