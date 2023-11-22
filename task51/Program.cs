/*

51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.


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

int SumIndex(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = array[i,i] + sum;
    }    
    return sum;
}

Console.Clear();

int userRow = Prompt("Введите кло-во строк ");

int userColumn = Prompt("Введите кло-во столбцов ");

int[,] userArray = GetRand2DArray(userRow, userColumn);

Print2DArray(userArray);

System.Console.WriteLine();

System.Console.WriteLine(SumIndex(userArray));