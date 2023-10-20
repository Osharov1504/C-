/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

 Console.Clear();

Console.Write("Введите число: ");
string number = Console.ReadLine();

        int sum = 0;
        foreach (char c in number)
        {
            sum += int.Parse(c.ToString());
        }

        Console.WriteLine($"Сумма цифр числа: {number} равна: {sum}");
        Console.ReadKey();



