/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/

using System;
Console.Clear();

void PrintArray(int[] array);
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine(); 
    }
}
int TakeEnNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] TakeArray(string message, int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = TakeEnNum(message);
    }
    return result;
}
int CountPositiveNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int userArraySize = TakeEnNum("Введите размер массива:");
int[] userArray = TakeArray("Введите номер для массива:", userArraySize);
int userPosNumCount = CountPositiveNum(userArray);
PrintArray(userArray);
System.Console.WriteLine(userPosNumCount);