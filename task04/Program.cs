/*
Внутри класса Answer напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.
*/


System.Console.WriteLine("Введите a: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите b: ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите c: ");
int c = Convert.ToInt32(Console.ReadLine());

int result = a;
 if(b > result)
  {
    result = b;
  }  
  if(c > result)
  {
    result = c;
  }

System.Console.WriteLine($"Максимальное число {result}");

