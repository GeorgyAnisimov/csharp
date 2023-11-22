/*

40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.


a + b > c && a + c > b && b + c > a

Теорема о неравенстве треугольника: каждая сторона треугольника 
меньше суммы двух других сторон.
*/

Console.Clear();

System.Console.WriteLine("Введите число 1 ");

int userNumber1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 2 ");

int userNumber2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 3 ");

int userNumber3 = Convert.ToInt32(Console.ReadLine());

void Tiangle(int firstNumber, int secondNumber, int thirdNumber)
{
    if (firstNumber + secondNumber < thirdNumber || firstNumber + thirdNumber < secondNumber || secondNumber + thirdNumber < firstNumber ||
    firstNumber == secondNumber || firstNumber == thirdNumber || secondNumber == thirdNumber)
    {
        System.Console.WriteLine($"Треугольник существовать не может");
    }
    else
    {
        System.Console.WriteLine($"Треугольник существовать может");
    }
}

Tiangle(userNumber1, userNumber2, userNumber3);