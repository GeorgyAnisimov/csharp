/*

12.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если второе число некратно первому, то программа выводит остаток от деления.
34, 5 -> некратно, остаток 4
16, 4 -> кратно

*/
System.Console.WriteLine("Введите первое число");

int first = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число");

int second = Convert.ToInt32(Console.ReadLine());

if (second == 0 )
{
    System.Console.WriteLine($"На 0 делить нельзя");
}
else if (first % second == 0 )
{
    System.Console.WriteLine($"Кратно ");
}
else
{
    System.Console.WriteLine($"Не кратно, остаток {first % second}");
}
