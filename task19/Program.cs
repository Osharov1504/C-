/*
напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.

Для остальных чисел вернуть True или False.
*/


Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

/*
int num1 = num / 1000;
int num2 = num / 1000 % 10;
int num4 = num / 10 % 10;
int num5 = num / 10;

if (num >= 10000 & num <= 99999)
{
  if (num1 == num5 & num2 == num4)
  {
    System.Console.WriteLine("да");
  }
  else
  {
    System.Console.WriteLine("нет");
  }
}
else
{
    System.Console.WriteLine("Число не пятизначное!");
}
*/
int revers = 0;
int count = 0;
for (int i = number; i > 0; i /= 10)
{
    revers = (revers * 10) + (i % 10);
    count++;
}
if (revers == number)
{
    System.Console.WriteLine("True");
}
else if (count != 5)
{
  System.Console.WriteLine("Число не пятизначное");
  System.Console.WriteLine("/t/t/t/t/t False");
}
else  System.Console.WriteLine("False");
    