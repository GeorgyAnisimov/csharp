/*

59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим следующий массив:
9 2 3
4 2 4
2 6 7
*/

// int Prompt(string massage)
// {
//     System.Console.Write(massage);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int[,] GetRand2DArray(int row, int column)
// {
//     int[,] matrix = new int[row, column];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             matrix[i, j] = new Random().Next(0, 11);
//         }
//     }
//     return matrix;
// }

// void Print2DArray(int[,] array)
// {
//     System.Console.Write($"[ ]\t");
//     int start = 0;
//     for (int i = start; i < start + array.GetLength(1); i++)
//     {
//         System.Console.Write($"[{i}]\t");
//     }
//     System.Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         System.Console.Write($"[" + i + "]\t");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] FindMinIndex(int[,] array)
// {
//     int min = array[0,0];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < min) min = array[i, j];
//         }
//     }

//     return min;
// }

// int[,] DeleteMinColumnRow(int[,] array,int row,int colomn,)
// {
//     int[,] result = new int [array.GetLength(0) - 1, array.GetLength(1) - 1];

//     for (var i = 0; i < array.GetLength(0); i++)
//     {
//         if(i != row)
//         for (var j = 0; j < array.GetLength(i); j++)
//         {
            
//         }
//     }



// }


// Console.Clear();

// int userRow = Prompt("Введите кло-во строк ");

// int userColumn = Prompt("Введите кло-во столбцов ");

// int[,] userArray = GetRand2DArray(userRow, userColumn);

// int[,] userminIndex = FindMinIndex(userArray);

// int userMinRow = userminIndex[0];

// int userMinColomn = userminIndex[1];

// Print2DArray(userArray);

// System.Console.WriteLine();

// FindMinIndex(userArray);





