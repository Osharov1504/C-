/*
Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

/*System.Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= A; i++)
{
    sum = sum + i;
}

System.Console.WriteLine(sum);
*/


System.Console.Write("Введите число A: ");
int userA = Convert.ToInt32(Console.ReadLine());

int Summer(int a)
{
    int summ = 0;

    for (int i = 1; i <= a; i++)
    {
        summ = summ + i;
    }
    return summ;
}
int userResult = Summer(userA);
System.Console.WriteLine(userResult);