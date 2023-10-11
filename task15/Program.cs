/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

System.Console.Write("Введите номер: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if(userNumber == 1)
{
    System.Console.WriteLine("Ответ: Нет");
}
if(userNumber == 2)
{
    System.Console.WriteLine("Ответ: Нет");
}
if(userNumber == 3)
{
    System.Console.WriteLine("Ответ: Нет");
}
if(userNumber == 4)
{
    System.Console.WriteLine("Ответ: Нет");
}
if(userNumber == 5)
{
    System.Console.WriteLine("Ответ: Нет");
}
if(userNumber == 6)
{
    System.Console.WriteLine("Ответ: Да");
}
if(userNumber == 7)
{
    System.Console.WriteLine("Ответ: Да");
}
if(userNumber > 7)
{
    System.Console.WriteLine("Ответ: В неделе всего семь дней. Введите номер от 1 до 7");
}