/*

13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

*/

Console.Clear();

System.Console.WriteLine("Введите число ");

int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else if (userNumber > 1000)
{
    while (userNumber > 1000)
    {
        userNumber = userNumber / 10;
    }
    System.Console.WriteLine(userNumber%10);
}
else
{
    System.Console.WriteLine(userNumber%10);
}