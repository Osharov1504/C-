/*
Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента.
*/
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите размеры трехмерного массива:");

        Console.Write("Размер по оси X: ");
        int xSize = int.Parse(Console.ReadLine());

        Console.Write("Размер по оси Y: ");
        int ySize = int.Parse(Console.ReadLine());

        Console.Write("Размер по оси Z: ");
        int zSize = int.Parse(Console.ReadLine());
        int[,,] threeDimensionalArray = new int[xSize, ySize, zSize];

        int currentValue = 10;

        for (int i = 0; i < xSize; i++)
        {
            for (int j = 0; j < ySize; j++)
            {
                for (int k = 0; k < zSize; k++)
                {
                    threeDimensionalArray[i, j, k] = currentValue++;
                }
            }
        }

        for (int i = 0; i < xSize; i++)
        {
            for (int j = 0; j < ySize; j++)
            {
                for (int k = 0; k < zSize; k++)
                {
                    Console.WriteLine($"[{i}, {j}, {k}] = {threeDimensionalArray[i, j, k]}");
                }
            }
        }

        Console.ReadLine();
    }
}
