/*
Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент
входных данных
{ 1, 9, 9, 0, 2, 8, 0, 9 } 0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза

1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
*/
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int Rows;
        int Columns;
        Console.Write("Введите количество строк: ");
        Rows = Convert.ToInt16(Console.ReadLine());

        Console.Write("Введите количество колонок: ");
        Columns = Convert.ToInt16(Console.ReadLine());

        Random rnd = new Random();
        int[,] array = new int[Rows, Columns];
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                array[i, j] = rnd.Next(0, 50);
                Console.Write(array[i, j].ToString() + " ");
            }
            Console.WriteLine();
        }
        FrequencyDictionary<int> freq = new FrequencyDictionary<int>();
        foreach (int element in array)
        {
            freq.Add(element);
        }
        Console.WriteLine("\nЧастотный словарь:");
        foreach (KeyValuePair<int, int> pair in freq)
        {
            Console.WriteLine(pair.Key + $" встречается - {pair.Value} раз{GetEnding(pair.Value)}");
        }
    }

    private static string GetEnding(int count)
    {
        if (count % 100 >= 11 && count % 100 <= 19)
        {
            return "ов";
        }

        switch (count % 10)
        {
            case 1:
                return "";
            case 2:
            case 3:
            case 4:
                return "а";
            default:
                return "ов";
        }
    }
}

public class FrequencyDictionary<T> : Dictionary<T, int>
{
    public void Add(T element)
    {
        if (ContainsKey(element))
        {
            this[element]++;
        }
        else
        {
            base.Add(element, 1);
        }
    }
}