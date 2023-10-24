/*
Напишите программу, которая подсчитывает количество четных элементов в массиве целых положительных трехзначных чисел и выводит результат на экран.
Если аргументы командной строки не переданы, программа использует массив по умолчанию, который содержит следующие значения: 
{100, 102, 105, 166, 283, 764, 300, 499, 133}.
*/

int Promt(string massage)
{
    System.Console.WriteLine(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
       array[i] = random.Next(minValue, maxValue +1) ;
    }
    return array;
}
int CountEvenElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] %2 == 0)
        count++;
    }
    return count;
}
void PrintArray(int[] arrayOne)
{
    System.Console.Write("Массив: ");
    for (int i = 0; i < arrayOne.Length; i++)
    {
       System.Console.Write(arrayOne[i]); 
       if(i < arrayOne.Length - 1)
       System.Console.Write("\t");
    }
    System.Console.WriteLine();
    System.Console.Write($"Колличество четных элементов: {CountEvenElements(arrayOne)}");
}

int length = Promt("Длинна массива: ");
int min = Promt("Начальное значение для диапазона случайного числа: ");
int max = Promt("Конечное значение для диапазона случайного числа: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);

