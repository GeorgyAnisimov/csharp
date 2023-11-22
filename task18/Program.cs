/*
18
Напишите программу, которая по заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).

*/

System.Console.WriteLine("Введите номер четверти: ");

int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber == 0)
{
    System.Console.WriteLine($"Введите другое число");
}
else if (userNumber == 1)
{
    System.Console.WriteLine($" X > 0  Y > 0" );
}
else if (userNumber == 2)
{
    System.Console.WriteLine($" X < 0 && Y > 0");
}
else if (userNumber == 3)
{
    System.Console.WriteLine($" X < 0 && Y < 0");
}
else if (userNumber == 4)
{
    System.Console.WriteLine($" X > 0 && Y < 0");
}