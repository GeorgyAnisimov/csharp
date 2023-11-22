/*

33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да

*/

Console.Clear();

System.Console.WriteLine("Введите размер ");

int size = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число ");

int userNumber = Convert.ToInt32(Console.ReadLine());

int[] GetRandArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

void Check(int[] array, int number)
{
    int check = 0;

    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] == number || array[i] == number * -1)
        {
            check = 1;
            //System.Console.Write($" Yes");  
            break;          
        }
        else 
        {
            check = 2;
            //System.Console.Write($" No");
        }
    }
    
    if (check == 1)
    {
        System.Console.Write($" Yes"); 
    }
    else if (check == 2)
    {
        System.Console.Write($" No");
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

Check(userArray, userNumber);