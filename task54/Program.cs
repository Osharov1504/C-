/*
Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.
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

        int[,] matrix = GenerateRandomMatrix(rows, cols);

        Console.WriteLine("\nИсходный массив:");
        PrintMatrix(matrix);
        OrderRowsDescending(matrix);

        Console.WriteLine("\nМассив после упорядочивания каждой строки по убыванию:");
        PrintMatrix(matrix);
    }

    static int[,] GenerateRandomMatrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(-100, 101);
            }
        }

        return matrix;
    }

    static void OrderRowsDescending(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            int[] rowArray = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                rowArray[j] = matrix[i, j];
            }
            Array.Sort(rowArray, (a, b) => b.CompareTo(a));
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rowArray[j];
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}