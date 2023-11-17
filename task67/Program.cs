/*
Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = SumOfDigits(number);

        Console.WriteLine($"Сумма цифр числа {number} равна: {sum}");

        Console.ReadLine();
    }

    static int SumOfDigits(int num)
    {
        if (num == 0)
        {
            return 0;
        }
        else
        {
            return num % 10 + SumOfDigits(num / 10);
        }
    }
}