/*

32. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]

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

void Rev(int[] array)
{
    System.Console.Write($"[ ");

    for (int i = 0; i < array.Length; i++)
    {
        /*if (array[i] < 0)
    
        {
            array[i] *= -1;
        }
        else if (array[i] > 0)
        {
            array[i] *= -1;
        }*/
        array[i] *= -1;
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine($"]");

}

void Printarray(int[] arr)
{
    System.Console.Write($"[ ");

    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}, ");
    }

    System.Console.WriteLine($"]");
}

int[] userArray = GetRandArray(size);

Printarray(userArray);

Rev(userArray);
