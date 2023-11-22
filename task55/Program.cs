/*

55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7

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
        System.Console.Write($"[" + i + "]\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] SwaptRowAndColumns(int[,] array)
{
    int[,] array2 = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array2[i, j] = array[j, i];
        }
    }
    return array2;
}

Console.Clear();

int userRow = Prompt("Введите кло-во строк ");

int userColumn = Prompt("Введите кло-во столбцов ");

int[,] userArray = GetRand2DArray(userRow, userColumn);

int[,] userConvertedArray = SwaptRowAndColumns(userArray);

Print2DArray(userArray);

System.Console.WriteLine();

Print2DArray(userConvertedArray); ;

/*
55 задача

int Prompt(string massage)
{
    System.Console.Write(massage);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    int result = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();
    return result;
}

int[,] GenerateMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    System.Console.WriteLine("\nДвумерный массив:");
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.Write(matrixOne[i, j]);
            if (j < matrixOne.GetLength(1) - 1)
                System.Console.Write("\t");
            else System.Console.WriteLine();
            Console.ResetColor();
        }
    }
    System.Console.WriteLine("\nНовый массив:");
    for (int i = 0; i < matrixTwo.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.Write(matrixTwo[i, j]);
            if (j < matrixTwo.GetLength(1) - 1)
                System.Console.Write("\t");
            else System.Console.WriteLine();
            Console.ResetColor();
        }
    }
}

int[,] ConvertMatrix(int[,] matrixOne)
{
    int[,] matrixTwo = new int[matrixOne.GetLength(1), matrixOne.GetLength(0)];
    for (int i = 0; i < matrixTwo.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            matrixTwo[i, j] = matrixOne[j, i];
        }
    }
    return matrixTwo;
}

int rows = Prompt("Количество строк: ");
int columns = Prompt("Количество столбцов: ");
int min = Prompt("Минимальное значение: ");
int max = Prompt("Максимальное значене: ");
int[,] matrix = GenerateMatrix(rows, columns, min, max);
PrintMatrix(matrix, ConvertMatrix(matrix));
*/