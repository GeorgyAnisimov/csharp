/*

10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

*/

Console.Clear();

System.Console.WriteLine("Введите число ");

int userNumber = Convert.ToInt32(Console.ReadLine());

userNumber = userNumber / 10;

userNumber = userNumber % 10;

System.Console.WriteLine(userNumber);
