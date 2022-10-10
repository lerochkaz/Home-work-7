// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] RequestForNumbers()
{
    Console.Write("Введите число m: ");
    int m = int.Parse(Console.ReadLine()!);
    Console.Write("Введите число n: ");
    int n = int.Parse(Console.ReadLine()!);
    int[,] array = new int[m, n];
    return array;
}

void FillArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Random generator = new Random();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
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

int[] Result(int[,] array)
{
    int[] arithmeticMean = new int[array.GetLength(1)];
    int sum = 0;
    for (int n = 0; n < array.GetLength(1); n++)
    {
        sum = 0;
        for (int m = 0; m < array.GetLength(0); m++)
        {
            sum += array[m, n];
            arithmeticMean[n] = sum / array.GetLength(0);
        }
        // arithmeticMean[n] = sum / n + 1;
    }
    return arithmeticMean;
}

void PrintResult(int[] array)
{
    Console.Write("Среднее арифметическое в каждом столбце: ");
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write($"{array[i]}; ");

    }
}

int[,] newArray = RequestForNumbers();
FillArray(newArray);
PrintArray(newArray);
int[] res = Result(newArray);
PrintResult(res);