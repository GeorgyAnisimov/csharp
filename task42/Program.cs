/*

Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10


*/

Console.Clear();

System.Console.WriteLine("Введите число ");

int userNumber = Convert.ToInt32(Console.ReadLine());

string userConverted = "";

for (int i = userNumber; i > 0; i /= 2)
{
    if (i % 2 != 0)
    {
        userConverted = userConverted + 1;
    }
    else if (i == 0)
    {
        userConverted = userConverted + 0;
    }
}

void Reversed(string input)
{
string reversed = "";

for (int i = input.Length - 1; i >= 0; i--)
{
    reversed += input[i];
}

System.Console.WriteLine(reversed);

}

System.Console.WriteLine(userConverted);

Reversed(userConverted);