/*
: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой
четверти (x и y).
*/

string f(int a)
{
    if(a == 1)
       return"x > 0 and y > 0";
    else if(a == 2)
       return"x < 0 and y > 0";
    else if(a == 3)
       return"x < 0 and y < 0";
    return "x > 0 and y < 0";
}
System.Console.Write("Введите номер четверти: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(f(x));