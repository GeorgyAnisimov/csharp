/*

53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив: 
8 4 2 4
5 9 2 3
1 4 7 2

*/



int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[,] GetRand2DArray(int row, int column)
{
    int[,] matrix = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
        }
    }
    return matrix;
}

void Print2DArray(int[,] array)
{
System.Console.Write($"[ ]\t");
int start = 0;
for (int i = start; i < start + array.GetLength(1); i++)
{
System.Console.Write($"[{i}]\t");
}
System.Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
System.Console.Write($"["+ i +"]\t");
for (int j = 0; j < array.GetLength(1); j++)
{
System.Console.Write(array[i, j] + "\t");
}
System.Console.WriteLine();
}
}

void SwapFirstAndLastRow(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int columns = arr.GetLength(1);

        for (int j = 0; j < columns; j++)
        {
            int tmp = arr[0, j];
            arr[0, j] = arr[rows - 1, j];
            arr[rows - 1, j] = tmp;
        }
    }


Console.Clear();

int userRow = Prompt("Введите кло-во строк ");

int userColumn = Prompt("Введите кло-во столбцов ");

int[,] userArray = GetRand2DArray(userRow, userColumn);

Print2DArray(userArray);

System.Console.WriteLine();

SwapFirstAndLastRow(userArray);

System.Console.WriteLine();

Print2DArray(userArray);