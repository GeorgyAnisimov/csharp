/*

34. Напишите программу, которая подсчитывает количество четных элементов в массиве целых положительных трехзначных чисел и выводит результат на экран.
Аргументы, передаваемые в метод/функцию:
'124, 378, 593, 821, 456'
Массив:
124     378     593     821     456 
Количество четных элементов: 3

*/

int[] GetRandArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
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
    if (array[i] %2 == 0)
    {
        check ++;
    }

    }
    System.Console.WriteLine("Количество четных элементов:" + check);
}

Console.Clear();

System.Console.WriteLine("Введите размер ");

int size = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandArray(size);

PrintArray(userArray);

System.Console.WriteLine();

Check(userArray);

