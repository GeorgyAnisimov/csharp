/*

15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

*/

Console.Clear();

System.Console.WriteLine("Введите номер дня недели");

int userNumber = Convert.ToInt32(Console.ReadLine());

int index = 1;

string[] weekDays = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Субота", "Воскресенье" };

if (userNumber <= 5 && userNumber > 0)
{
    System.Console.WriteLine(weekDays[userNumber - index] + ", не выходной");
}
else if (userNumber >= 6 && userNumber > 0)
{
    System.Console.WriteLine(weekDays[userNumber - index] + ", выходной");
    
}
else
{
    System.Console.WriteLine("Нет такого дня недели");
}