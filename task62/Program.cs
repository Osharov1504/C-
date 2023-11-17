/*
Заполните спирально массив 4 на 4.

*/
using System;

class Program
{
    static void Main()
    {
        int[,] spiralArray = GenerateSpiralArray(4, 4);
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(spiralArray[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static int[,] GenerateSpiralArray(int rows, int columns)
    {
        int[,] result = new int[rows, columns];

        int value = 1;
        int rowStart = 0, rowEnd = rows - 1;
        int colStart = 0, colEnd = columns - 1;

        while (rowStart <= rowEnd && colStart <= colEnd)
        {
            for (int i = colStart; i <= colEnd; ++i)
            {
                result[rowStart, i] = value++;
            }
            rowStart++;
            for (int i = rowStart; i <= rowEnd; ++i)
            {
                result[i, colEnd] = value++;
            }
            colEnd--;

            if (rowStart <= rowEnd)
            {
                for (int i = colEnd; i >= colStart; --i)
                {
                    result[rowEnd, i] = value++;
                }
                rowEnd--;
            }

            if (colStart <= colEnd)
            {
                for (int i = rowEnd; i >= rowStart; --i)
                {
                    result[i, colStart] = value++;
                }
                colStart++;
            }
        }

        return result;
    }
}