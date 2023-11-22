/*

67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}


int intN(int n)
{
    if (n % 10 > 0)
    {
        return n % 10 + intN(n/10);
    }
    else
    {
        return 0;
    }

}

Console.Clear();

int userNumber = Prompt("Введите число ");

int result = intN(userNumber);

System.Console.WriteLine(result);