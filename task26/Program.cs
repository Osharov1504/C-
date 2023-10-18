/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
Console.Clear();

System.Console.Write("Введите число A: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

/*int count = 0;

for (int i = number; i > 0; i /= 10)
{
    count = count +1;
}
*/

int result(int number)
{
    int count = 0;

    for (int i = number; i > 0; i /= 10)
    {
        count = count + 1;
    }
    return count;
}
    int userCount = result(userNumber);
    System.Console.WriteLine(userCount);