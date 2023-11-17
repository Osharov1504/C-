/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
*/
class Program
{
    static void Main()
    {
        Console.Write("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine($"Натуральные числа от 1 до {n}:");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }

        Console.ReadLine(); 
    }
}