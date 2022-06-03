///Напишите программу, которая будет создавать копию заданного 2-мерного массива с помощью поэлементного копирования.

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void CopyArray(int[,] arr)
{
    int a = arr.GetLength(0);
    int b = arr.GetLength(1);
    int[,] new_arr = new int[a,b];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            new_arr[i, j] = arr[i, j];
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
CopyArray(matrix);
Console.WriteLine();
PrintArray(matrix);