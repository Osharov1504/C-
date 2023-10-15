/*
17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта
точка.
*/

string f(int x, int y)
{
    if(x > 0 && y > 0)
       return"1";
    else if(x < 0 && y > 0)
       return"2";
    else if(x < 0 && y < 0)
       return"3";
    return "4";
}
System.Console.Write("Введите первое число: ");
int X = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int Y = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(f(X,Y));


