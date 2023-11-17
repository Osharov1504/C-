/*
Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц.
*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк первой матрицы: ");
        int rows1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество столбцов первой матрицы: ");
        int cols1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество строк второй матрицы: ");
        int rows2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество столбцов второй матрицы: ");
        int cols2 = Convert.ToInt32(Console.ReadLine());

        if (cols1 != rows2)
        {
            Console.WriteLine("Умножение матриц невозможно. Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");
            return;
        }

        int[,] matrix1 = GenerateRandomMatrix(rows1, cols1);
        int[,] matrix2 = GenerateRandomMatrix(rows2, cols2);

        Console.WriteLine("\nПервая матрица:");
        PrintMatrix(matrix1);

        Console.WriteLine("\nВторая матрица:");
        PrintMatrix(matrix2);

        int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);

        Console.WriteLine("\nРезультат умножения матриц:");
        PrintMatrix(resultMatrix);
    }

    static int[,] GenerateRandomMatrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(1, 11); 
            }
        }

        return matrix;
    }

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        int[,] resultMatrix = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                int sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }

        return resultMatrix;
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