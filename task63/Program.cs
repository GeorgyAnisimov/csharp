/*

63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void intN(int number, int current = 1)
{
    if (number < current) return;
    else
    {
        System.Console.Write(current + " ");

        intN(number, current + 1);
    }
}

Console.Clear();

int userNumber = Prompt("Введите число ");

intN(userNumber);