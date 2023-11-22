/*

39. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
Комментарий: эту задачу можно решить 2 способами: 
1) менять числа местами в исходном массиве; 
2) создать новый массив и в него записать перевёрнутый исходный массив по элементам.

*/

// int Prompt(string massage)
// {
//     System.Console.Write(massage);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

int[] GetRandArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void RevArray(int[] array, int size)
{
    int temp = 0;
    int revIndex = size - 1;

    //System.Console.Write($" [");

    for (int i = 0; i < array.Length /2  ; i++)
    {
        temp = array[revIndex];

        array[revIndex] = array[i];

        array[i] = temp;

        revIndex = revIndex - 1;

        //System.Console.Write($" {array[i]}, ");

    }

    //System.Console.WriteLine($"]");

}

// void Printarray(int[] arr)
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

Console.Clear();

System.Console.WriteLine("Введите размер ");

int size = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandArray(size);

PrintArray(userArray);

RevArray(userArray, size);

System.Console.WriteLine();

PrintArray(userArray);