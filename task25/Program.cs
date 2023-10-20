/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

*/

Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень B: ");
int b = Convert.ToInt32(Console.ReadLine());

CalculatePower(a, b);
    

    static void CalculatePower(int a, int b)
    {
        if (a == 0)
        {
            Console.WriteLine($"0 не может быть возведено в степень {b}");
            return;
        }

        int result = 1;
        for (int i = 1; i <= b; i++)
        {
            result *= a;
        }

        Console.WriteLine($"{a}^({b}) = {result}");
    }
