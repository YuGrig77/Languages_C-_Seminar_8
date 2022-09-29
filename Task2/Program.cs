// Задача 55: Задайте двумерный массив. Напишите программу,
//которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

Console.Clear();

Console.Write("Pls enter rows number: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Pls enter columns number: ");
int columns = int.Parse(Console.ReadLine());

int minValue = 2;
int maxValue = 12;

int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
Console.WriteLine();
int[,] transArray = ArrayTranspose(array);
PrintArray(transArray);

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write($"{result[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ArrayTranspose(int[,] arrayToTranspose)
{
    int rows = arrayToTranspose.GetLength(0);
    int columns = arrayToTranspose.GetLength(1);
    int[,] transposedArray = new int[columns, rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            transposedArray[j, i] = arrayToTranspose[i, j];
        }
    }
    return transposedArray;
}