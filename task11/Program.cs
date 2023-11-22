/*

11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98

*/

int number = new Random().Next(100, 1000);

System.Console.WriteLine(number);

int first = number / 100;

int second = number % 100 / 10;

int last = number % 10;

int result = first * 10 + last;

System.Console.WriteLine(first);

System.Console.WriteLine(second);

System.Console.WriteLine(last);

System.Console.WriteLine($"{result}");