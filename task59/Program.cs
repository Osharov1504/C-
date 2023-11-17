/*
Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7
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
        int[,] array = new int[rows, cols];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = random.Next(1, 101);
            }
        }
        int minElement = array[0, 0];
        int minRowIndex = 0;
        int minColIndex = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (array[i, j] < minElement)
                {
                    minElement = array[i, j];
                    minRowIndex = i;
                    minColIndex = j;
                }
            }
        }
        int[,] newArray = new int[rows - 1, cols - 1];

        for (int i = 0, newRow = 0; i < rows; i++)
        {
            if (i == minRowIndex)
                continue;

            for (int j = 0, newCol = 0; j < cols; j++)
            {
                if (j != minColIndex)
                {
                    newArray[newRow, newCol] = array[i, j];
                    newCol++;
                }
            }

            newRow++;
        }
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        Console.WriteLine("\nМассив после удаления строки и столбца с минимальным элементом:");
        PrintArray(newArray);
    }

    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + (j == array.GetLength(1) - 1 ? "\n" : " "));
            }
        }
    }
}

           