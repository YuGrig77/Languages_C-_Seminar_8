// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Сразу зададим матрицу, которую можно перемножить, 
// т.е. количество столбцов первой равно количеству строк второй
Console.Clear();

Console.WriteLine("\nPls enter matrix sizes and random numbers range:");
int m = InputNumbers("Pls enter 1st matrix row's number: ");
int n = InputNumbers("Pls enter 1st matrix column's number (row's number of 2nd matrix): ");
int p = InputNumbers("Pls enter 2nd matrix columns's number: ");
int range = InputNumbers("Pls enter random numbers range: from 1 to ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine("\nFirst matrix:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine("\nSecond matrix:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MatrixMultiplication(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine("\nResult of multiplication:");
WriteArray(resultMatrix);

void MatrixMultiplication(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
