/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int M = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        int sum = GetSumOfNaturalNumbers(M, N);
        Console.WriteLine($"Сумма натуральных чисел от {M} до {N}: {sum}");
    }

    static int GetSumOfNaturalNumbers(int m, int n)
    {
        if (m > n)
        {
            throw new ArgumentException("Значение M должно быть меньше или равно N.");
        }

        if (m == n)
        {
            return m;
        }
        else
        {
            return m + GetSumOfNaturalNumbers(m + 1, n);
        }
    }
}