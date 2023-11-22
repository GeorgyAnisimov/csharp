/*

26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5


*/

Console.Clear();

System.Console.WriteLine("Введите число: ");

int userNumber = Convert.ToInt32(Console.ReadLine());

int Sum(int num)
{ 
    int count = 0;

    for (int i = num; i > 0; i /= 10)
    {
        count = count + 1;
    }
    return count;
}

System.Console.WriteLine(Sum(userNumber));