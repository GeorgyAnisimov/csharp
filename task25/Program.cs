/*

25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

*/

Console.Clear();

System.Console.WriteLine("Введите число A ");

int userNumberA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число B ");

int userNumberB = Convert.ToInt32(Console.ReadLine());

void APowB (int A, int B)
{
    System.Console.WriteLine((Math.Pow(A, B)));
}

APowB(userNumberA, userNumberB);