/*

69. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}


int intN(int numberA, int numberB)
{
    if (numberB == 1)
    {
        return numberA;
    }
    else
    {
        return numberA * intN(numberA, numberB - 1);
    }

}

Console.Clear();

int userNumberA = Prompt("Введите число M ");

int userNumberB = Prompt("Введите число N ");;

int result = intN(userNumberA, userNumberB);

System.Console.WriteLine(result);