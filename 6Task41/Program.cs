// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите числа, разделенные запятой:");
        string numbersInput = Console.ReadLine();

        string[] numbers = numbersInput.Split(',');

        int count = 0;

        foreach (string number in numbers)
        {
            if (int.Parse(number) > 0)
            {
                count++;
            }
        }

        Console.WriteLine("Количество чисел больше 0: " + count);
    }
}

