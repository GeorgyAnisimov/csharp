/*

65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void intN(int numberM, int numberN)
{
    if (numberN < numberM) return;
    else
    {
        System.Console.Write(numberM + " ");


        intN(numberM + 1, numberN);
    }

}

Console.Clear();

int userNumberM = Prompt("Введите число M ");

int userNumberN = Prompt("Введите число N ");;

intN(userNumberM, userNumberN);