/*

35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5

*/

Console.Clear();

System.Console.WriteLine("Введите размер ");

int size = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите число ");

// int userNumber = Convert.ToInt32(Console.ReadLine());

int[] GetRandArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
    return array;
}

void Check(int[] array)
{
    int check = 0;

    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] > 9 && array[i] < 100)
        {
            check = check + 1;
            //System.Console.Write($" Yes");  
                 
        }
    }
    
    if (check > 0 )
    {
        System.Console.Write($" {check}"); 
    }
    else if (check == 0)
    {
        System.Console.Write($" 0");
    }
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

Check(userArray);