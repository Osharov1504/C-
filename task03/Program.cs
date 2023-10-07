/*
3.	Напишите программу, которая будет выдавать название дня недели по заданному номеру. 3 -> Среда 5 -> Пятница
*/
System.Console.Write("Введите номер: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if(userNumber == 1)
{
    System.Console.WriteLine("Ответ: Понедельник");
}
if(userNumber == 2)
{
    System.Console.WriteLine("Ответ: Вторник");
}
if(userNumber == 3)
{
    System.Console.WriteLine("Ответ: Среда");
}
if(userNumber == 4)
{
    System.Console.WriteLine("Ответ: Четверг");
}
if(userNumber == 5)
{
    System.Console.WriteLine("Ответ: Пятница");
}
if(userNumber == 6)
{
    System.Console.WriteLine("Ответ: Суббота");
}
if(userNumber == 7)
{
    System.Console.WriteLine("Ответ: Воскресение");
}
if(userNumber > 7)
{
    System.Console.WriteLine("Ответ: В неделе всего семь дней. Введите номер от 1 до 7");
}