/*
Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
*/

class Program
{
static void Main(string[] args)
{
Console.Clear();
System.Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int[] triangle = new int[N];
triangle[0] = 1;
for (int i = 1; i < N; i++)
{
triangle[i] = triangle[i-1] + 1;
}
for (int j = 0; j < N; j++)
{
for (int k = 0; k <= j; k++)
{
Console.Write($"{triangle[k]} ");
}
Console.WriteLine();
}
}
}
