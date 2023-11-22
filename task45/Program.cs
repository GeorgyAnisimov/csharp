/*

45. Напишите программу, которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования.

*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] GetRandArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

int[] CopyArray(int size, int[] array)
{
    int[] arrayCopy = new int[size];
    for (int i = 0; i < size; i++)
    {
        arrayCopy[i] = array[i];
    }
    return arrayCopy;
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

Console.Clear();

int size = Prompt("Введите размер массива ");

int[] userArray = GetRandArray(size);

int[] userArrayCopy =  CopyArray(size, userArray);

PrintArray(userArray);

System.Console.WriteLine();

PrintArray(userArrayCopy);


