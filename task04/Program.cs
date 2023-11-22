/*

Внутри класса Answer напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.

*/

System.Console.WriteLine("Введите первое число");

int userNumber1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число");

int userNumber2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите третье число");

int userNumber3 = Convert.ToInt32(Console.ReadLine());

int max = userNumber1;

if (max < userNumber2)
{
    max = userNumber2;
}
if (max < userNumber3)
{
    max = userNumber3;
    System.Console.WriteLine($"`{max}` максимальное из этих чисел ");
}
else
{
    System.Console.WriteLine($"`{max}` максимальное из этих чисел ");
}