/*
Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

  using System;
Console.Clear();

int[] GetRandomArray(int start, int end, int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine("]");
}

int[] ChangePosAndNegArray(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i] * -1;
    }
    return result;
}

int TakeEntNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

bool CheckNumberInArray(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;
    }
    return false;
}

int userArraySize = TakeEntNum("Введите размер массива:");
int userArrayStart = TakeEntNum("Введите диапазон начальных номеров массива:");
int userArrayEnd = TakeEntNum("Введите диапазон конечных номеров массива:");
int userSearchNumber = TakeEntNum("Укажите номер для поиска в массиве: ");

int[] userArray = GetRandomArray(userArrayStart, userArrayEnd, userArraySize);

PrintArray(userArray);

System.Console.WriteLine(CheckNumberInArray(userArray, userSearchNumber));      
    
