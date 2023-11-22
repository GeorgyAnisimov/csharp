/*

08. Напишите программу которая на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.

*/

Console.Clear();

System.Console.WriteLine("Введите число ");

int userNumber = Convert.ToInt32(Console.ReadLine());

for (var i = 1; i <= userNumber; i ++)
{   if (i == 1)
    {
        System.Console.WriteLine(i);
    }   
    else if (i %2 == 0)
    {
        System.Console.Write(i  + "\t");
    }
}