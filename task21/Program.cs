/*
21 напишите метод DistanceBetweenPoints, который принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел,
 и возвращает расстояние между ними в 3D пространстве.
 A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

System.Console.Write("Введите число A: ");
int x1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число A: ");
int y1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число A: ");
int z1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число B: ");
int x2 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число B: ");
int y2 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2);
double g = Math.Round(Math.Sqrt(d), 2);

System.Console.WriteLine(g);