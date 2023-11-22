/*

Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.

*/

System.Console.WriteLine("Введите первое число");

int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число");

int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    System.Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
}
else if (secondNumber > firstNumber)
{
    System.Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
}
else
{
    System.Console.WriteLine($"Введенные числа равны `{firstNumber}`");
}