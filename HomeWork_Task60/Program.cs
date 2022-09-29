// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();

Console.WriteLine("\nPls enter massive dimensions X x Y x Z:");
int x = InputNumbers("Enter X: ");
int y = InputNumbers("Enter Y: ");
int z = InputNumbers("Enter Z: ");
Console.WriteLine("");

int minValue = 10;
int maxValue = 100;

int[,,] array = new int[x, y, z];
GetArray(array);
PrintArray(array);

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.Write($"X({i}) Y({j}) ");
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"Z({k}) = {array3D[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void GetArray(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(minValue, maxValue + 1);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(minValue, maxValue + 1);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}