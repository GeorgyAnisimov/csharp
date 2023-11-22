/*

31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20

*/

Console.Clear();

System.Console.WriteLine("Введите число: ");

int size = Convert.ToInt32(Console.ReadLine());

int[] GetRandArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

void Sum(int[] array)
{
    int sumPos = 0;

    int sumNeg = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNeg += array[i];
        }
        else if (array[i] > 0)
        {
            sumPos += array[i];
        }
    }
    System.Console.WriteLine();

    System.Console.WriteLine($"Sum positive = {sumPos}");

    System.Console.WriteLine($"Sum negative = {sumNeg}");

}

// void PrintArray(int[] arr)
// {
//     System.Console.Write($"[ ");

//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write($"{arr[i]}, ");
//     }

//     System.Console.WriteLine($"]");
// }

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count)
    {
        if (position == (count - 1))
        {
            Console.Write($"{col[position]}");
            position++;
        }
        else
        {
            Console.Write($"{col[position]},");
            position++;
        }
    }
    Console.Write("]");
}

int[] userArray = GetRandArray(size);

PrintArray(userArray);

Sum(userArray);