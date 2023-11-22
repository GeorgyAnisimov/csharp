/*

23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
N = 3 

1
8
27


N = 5

1
8
27
64
125

*/

Console.Clear();

System.Console.WriteLine("Введите число ");

int userNumber = Convert.ToInt32(Console.ReadLine());

for (var i = 1; i <= userNumber; i++)
{
    System.Console.WriteLine((Math.Pow(i, 3)));
}