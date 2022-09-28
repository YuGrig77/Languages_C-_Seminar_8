// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку
// массива.

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
//RowsSwitch();
PrintArray(array);

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

void RowsSwitch(int[,] result)
{
    
}