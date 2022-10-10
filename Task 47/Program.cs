// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] RequestForNumbers()
{
    Console.Write("Введите число m: ");
    int m = int.Parse(Console.ReadLine()!);
    Console.Write("Введите число n: ");
    int n = int.Parse(Console.ReadLine()!);
    double[,] array = new double[m, n];
    return array;
}

void FillArray(double[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Random generator = new Random();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(generator.Next(-100, 100) / 10.0);
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
double[,] newArray = RequestForNumbers();
FillArray(newArray);
PrintArray(newArray);