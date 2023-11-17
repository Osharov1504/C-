/*
Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов.
*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк массива: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов массива: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        if (rows <= 0 || cols <= 0)
        {
            Console.WriteLine("Массив не прямоугольный.");
            return;
        }

        int[,] matrix = new int[rows, cols];
        Random random = new Random();
        Console.WriteLine("Массив:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(-100, 101);
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        bool isRectangular = true;
        for (int i = 1; i < rows; i++)
        {
            if (matrix.GetLength(1) != matrix.GetUpperBound(1) + 1)
            {
                isRectangular = false;
                break;
            }
        }

        if (!isRectangular)
        {
            Console.WriteLine("Массив не прямоугольный.");
            return;
        }

        int minSum = int.MaxValue,
            rowSum,
            minRowIndex = 0;
        for (int i = 0; i < rows; i++)
        {
            rowSum = 0;
            for (int j = 0; j < cols; j++)
            {
                rowSum += matrix[i, j];
            }

            if (rowSum < minSum)
            {
                minSum = rowSum;
                minRowIndex = i;
            }
        }

        Console.WriteLine($"Строка с наименьшей суммой: {minRowIndex}");
    }
}