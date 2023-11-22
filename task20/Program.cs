/*
20
Напишите программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21

*/

System.Console.WriteLine("Введите кординаты точки A (x,y): ");

int userAx = Convert.ToInt32(Console.ReadLine());

int userAy = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine("Введите кординаты точки B (x,y): ");

int userBx = Convert.ToInt32(Console.ReadLine());

int userBy = Convert.ToInt32(Console.ReadLine());

// int userSquareX = (userBx - userAx) * 2

double userSquareX = Math.Pow(userBx - userAx, 2); // Math.Pow(a, 3) возведение в степень, (что возводим в степень, в какую степень)

double userSquareY = Math.Pow(userBy - userAy, 2);

double rootXY = Math.Sqrt(userSquareX + userSquareY); // Math.Sqrt(X) - корень

System.Console.WriteLine(Math.Round(rootXY, 3)); // Math.Round(x, 3) - округление (3 - знаки после ,)