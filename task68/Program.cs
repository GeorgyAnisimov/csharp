/*

68. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int Ack(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    else if (numberN == 0)
    {
        return Ack(numberM - 1, 1);
    }
    else
    {
        return Ack(numberM - 1, Ack(numberM, numberN - 1));
    }
}


Console.Clear();

int userNumberM = Prompt("Введите число M ");

int userNumberN = Prompt("Введите число N "); ;

System.Console.WriteLine(Ack(userNumberM, userNumberN));


