/*
Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.

*/



class Program
{
static void Main()
{
Random rnd = new Random();
Console.Write("Введите размер массива: ");  
int size = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[size, size];

for (int i = 0; i < size; i++)
for (int j = 0; j < size; j++)
array[i, j] = rnd.Next(1, 10);

Console.WriteLine("Исходный массив: ");
for (int i = 0; i < size; i++)
{
for (int j = 0; j < size; j++)
{
Console.Write($"{array[i,j]} ");
}
Console.WriteLine("");
}

for (int i = 0; i < array.GetLength(1); i++)
{
int temp = array[0, i];
array[0, i] = array[size - 1, i];
            array[size - 1, i] = temp;
        }

        Console.WriteLine("Массив после замены строк:");
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
                Console.Write($"{array[i, j]} ");
            }

            Console.WriteLine("");
        }
}
}

