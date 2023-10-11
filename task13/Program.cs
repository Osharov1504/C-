/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (number < 100)
    {
        System.Console.WriteLine("Третьей цифры нет ");
    }
if (number >= 100)
{
    while (number > 999)
    {
        number = number / 10;
    }
    result = number % 10;
    System.Console.WriteLine(result);

}

