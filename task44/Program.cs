/*
Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int userIntOut(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int userNum = userIntOut("Введите число: ");

string[] FebonachiNumber(int a)
{
    string[] result = "";
    if(a = 0 || a = 1) return 1;
    for (int i = 0; i <= number; i++)
    {
        result = result + i;
    }
    return result;
}

System.Console.WriteLine(FebonachiNumber(userNum));