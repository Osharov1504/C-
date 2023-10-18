/*
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

Console.Clear();

System.Console.Write("Введите число N: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int result(int number)
{
    int count = 1;

    for (int i = 1; i <= number; i ++)
    {
        count = count * i;
    }
    return count;
}
    int userCount = result(userNumber);
    System.Console.WriteLine(userCount);
