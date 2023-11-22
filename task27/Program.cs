/*

27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

*/

Console.Clear();

System.Console.WriteLine("Введите число  ");

int userNumber = Convert.ToInt32(Console.ReadLine());

void Sum(int a)
{
    int result = 0;
    for (int i = a; i > 0; i /= 10)
    {
        result = result + i % 10;
    }
    System.Console.WriteLine(result);

}

Sum(userNumber);