/*
Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых чисел и выводит результат на экран.
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
int SumOddElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
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
    System.Console.Write($"Сумма нечетных элементов: {SumOddElements(arrayOne)}");
}

int length = Promt("Длинна массива: ");
int min = Promt("Минимальное значение: ");
int max = Promt("Максимальное значение: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);

