/*
11. Напишите программу, которая принимает на вход
трёхзначное число и на выходе удаляет вторую
цифру этого числа.
*/

int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);

int number2 = number / 100;
int number3 = number % 10;

// int result = number2 * 10 + number3
// System.Console.WriteLine(result);

System.Console.WriteLine($"{number2} {number3}");