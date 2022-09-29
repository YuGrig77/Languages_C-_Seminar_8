// Дополнительная задача 61: Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника

Console.Clear();

int n = InputNumbers("Pls enter number of rows: ");

double[,] pascalTriangle = new double[n + 1, 2 * n + 1];

BuildPascalTriangle(pascalTriangle);

Console.WriteLine();
PrintArray(pascalTriangle);

PascalTriangleTransform(pascalTriangle);

Console.WriteLine();
PrintArray(pascalTriangle);

void PascalTriangleTransform(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int count = 0;
        for (int j = array.GetLength(1) - 1; j >= 0; j--)
        {
            if (array[i, j] != 0)
            {
                array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
                array[i, j] = 0;
                count++;
            }
        }
    }
    array[array.GetLength(0) - 1, 0] = 1;
}

void BuildPascalTriangle(double[,] pascalTriangle)
{
    for (int k = 0; k < pascalTriangle.GetLength(0) - 1; k++)
    {
        pascalTriangle[k, 0] = 1;
    }
    for (int i = 1; i < pascalTriangle.GetLength(0) - 1; i++)
    {
        for (int j = 1; j < i + 1; j++)
        {
            pascalTriangle[i, j] = pascalTriangle[i - 1, j] + pascalTriangle[i - 1, j - 1];
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (array[i, j] != 0)
            {
                Console.Write($"{array[i, j]} ");
            }
            else Console.Write("  ");
        }
        Console.WriteLine();
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}