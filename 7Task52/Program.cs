// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        double[] columnAverages = new double[columns]; 

        
        for (int j = 0; j < columns; j++)
        {
            double sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += array[i, j];
            }
            columnAverages[j] = sum / rows;
        }

        for (int j = 0; j < columns; j++)
        {
            Console.WriteLine("Среднее арифметическое столбца " + (j + 1) + ": " + columnAverages[j]);
        }
    }
}
