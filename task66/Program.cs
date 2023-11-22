/*

66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int intN(int numberM,int numberN)
{
    if (numberN > numberM) return numberM + intN(numberM + 1, numberN);
    return numberM;
}

Console.Clear();

int userNumberM = Prompt("Введите число M ");

int userNumberN = Prompt("Введите число N ");;

System.Console.WriteLine(intN(userNumberM, userNumberN));



