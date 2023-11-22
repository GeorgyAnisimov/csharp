/*

37. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21


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
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void ProdArray(int[] array, int size)
{
    int revIndex = size - 1;
    int[] result = new int[size / 2];

    System.Console.Write($" [");

    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] *= array[revIndex];

        revIndex = revIndex - 1;

        System.Console.Write($"{result[i]}, ");

    }
    System.Console.Write($"]");

}

// void PrintArray(int[] arr)
// {
//     System.Console.Write($" [");

//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write($" {arr[i]}, ");
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

ProdArray(userArray, size);