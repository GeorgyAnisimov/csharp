/*

64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void intN(int number)
{
    if (number == 0) return;
    else if (number < 0) 
    {
         Prompt("Введите другое число ");
    }
    else
    {
        System.Console.Write(number + " ");

        intN(number -1 );
    }
}

Console.Clear();

int userNumber = Prompt("Введите число ");

intN(userNumber);


