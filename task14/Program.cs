﻿/*
14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно
одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


if (num % 7 == 0 && num % 23 == 0)
{
    System.Console.WriteLine("Ответ: да");
}
else
{
    System.Console.WriteLine("Ответ: нет");
}