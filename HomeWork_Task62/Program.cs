// Задача 62: Заполните спирально массив 4 на 4.
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

Console.Clear();

int size = 4;
int[,] sqareMatrix = new int[size, size];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
    sqareMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

PrintArray(sqareMatrix);

void PrintArray(int[,] res)
{
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            if (res[i, j] / 10 <= 0)
                Console.Write($" {res[i, j]} ");

            else Console.Write($"{res[i, j]} ");
        }
        Console.WriteLine();
    }
}
