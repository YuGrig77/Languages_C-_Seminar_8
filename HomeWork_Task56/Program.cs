// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

Console.Clear();

Console.WriteLine($"\nPls enter massive size m x n and range:");
int m = InputNumbers("Pls enter m: ");
int n = InputNumbers("Pls enter n: ");
int range = InputNumbers("Pls enter range: fm 1 to ");

int[,] array = new int[m, n];
GetArray(array);
PrintArray(array);

int minSumRow = 0;
int sumRow = RowElementsSum(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = RowElementsSum(array, i);
    if (sumRow > tempSumLine)
    {
        sumRow = tempSumLine;
        minSumRow = i;
    }
}

Console.WriteLine($"\n{minSumRow + 1} - The row with minimum sum ({sumRow}) of elements");


int RowElementsSum(int[,] array, int i)
{
    int sumRow = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumRow += array[i, j];
    }
    return sumRow;
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
