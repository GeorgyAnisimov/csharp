/*

30. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке

*/

Console.Clear();

System.Console.WriteLine("Введите число: ");

int size = Convert.ToInt32(Console.ReadLine());

int[] GetRandArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

// void Printarray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write($"{arr[i]}, ");
//     }
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