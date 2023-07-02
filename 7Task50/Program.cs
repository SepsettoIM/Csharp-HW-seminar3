
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7] -> на этой позиции числа в массиве нет

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };
        Console.WriteLine("Введите позицию элемента в формате [строка, столбец]:");
        string positionInput = Console.ReadLine();

        string[] positionParts = positionInput.Split(',');
        int row = int.Parse(positionParts[0].Trim());
        int column = int.Parse(positionParts[1].Trim());

        if (row < 0 || row >= array.GetLength(0) || column < 0 || column >= array.GetLength(1))
        {
            Console.WriteLine("Указанная позиция находится вне границ массива.");
        }
        else
        {
            int element = array[row, column];
            Console.WriteLine("Значение элемента: " + element);
        }
    }
}
