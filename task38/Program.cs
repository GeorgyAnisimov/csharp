/*

38. Напишите программу для работы с массивом вещественных чисел.
Аргументы, передаваемые в метод/функцию:
3.17    8.94    2.36    5.72    0.85    
Разность между максимальным и минимальным элементом = 8.09

*/

int[] GetRandArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 20);
    }
    return array;
}

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

void FindDiff(int[] array)
{
    int diff = 0;
    int min = array[0];
    int max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }

    // if (array[i] %2 == 0)
    // {
    //     check ++;
    // }

    }

    diff = max - min;

    System.Console.WriteLine("Разность между максимальным и минимальным элементом : " + diff);
}

Console.Clear();

System.Console.WriteLine("Введите размер ");

int size = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandArray(size);

PrintArray(userArray);

System.Console.WriteLine();

FindDiff(userArray);

