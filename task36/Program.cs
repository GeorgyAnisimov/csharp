/*

36. Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых чисел и выводит результат на экран.
Аргументы, передаваемые в метод/функцию:
'18, 76, 11' 
Сумма нечетных элементов: 76

*/

int[] GetRandArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
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

void Check(int[] array)
{
    int check = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0 )
        {
            check = check + array[i];
        }
        
    }

    System.Console.WriteLine("Сумма нечетных элементов:" + check);
}

Console.Clear();

System.Console.WriteLine("Введите размер ");

int size = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandArray(size);

PrintArray(userArray);

System.Console.WriteLine();

Check(userArray);




