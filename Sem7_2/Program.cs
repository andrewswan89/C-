string FindArray(int[,] arr)
{
    Console.Write("Введите позицию в строке: ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Введите позицию в столбце: ");
    int y = int.Parse(Console.ReadLine());
    x--; y--;
    if (x >= arr.GetLength(0) || y >= arr.GetLength(1))
        return $"There is no value at {x+1} and {y+1}";
        
    return $"{arr[x, y]}";
}


void PrintArray(int[,] arr)         /// вывод массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}    ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int[,] arr, int from, int to)        /// заполненение массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}


Console.Write("Введите количество строк: ");
int x= int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int y = int.Parse(Console.ReadLine());
int[,] arr = new int[x, y];


FillArray(arr, 0, 10);
PrintArray(arr);
Console.WriteLine(FindArray(arr));
