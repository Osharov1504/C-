/*
Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.
*/

System.Console.WriteLine("Введите число А: ");
int userA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число В: ");
int userB = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число С: ");
int userC = Convert.ToInt32(Console.ReadLine());

bool Triagle(int a, int b, int c)
{
    bool result = false;
    if(a+b > c && a + c > b && b + c > a)
    {
        result = true;
    }
    return result;
}
System.Console.WriteLine(Triagle(userA, userB, userC));