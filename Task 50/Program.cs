// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1
// 7 -> такого числа в массиве нет


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

string[] ItemNumberQuery()
{
    Console.Write("Введите номер элемента в двухмерном массиве через пробел: ");
    string stringWhithNumberQuery = Console.ReadLine()!;
    string[] dataNumberQuery = stringWhithNumberQuery.Split(" ");
    return dataNumberQuery;
}

void PrintArrayElement(int[,] array, string[] dataNumberQuery)
{

    int elementX = int.Parse(dataNumberQuery[0]);
    int elementY = int.Parse(dataNumberQuery[1]);


    if (elementX < array.GetLength(0) && elementY < array.GetLength(1))
    {
        Console.WriteLine($"Значение элемента массива={array[elementX, elementY]}");
    }
    else
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
}

int[,] newArray = RequestForNumbers();
FillArray(newArray);
PrintArray(newArray);
string[] elementInArray = ItemNumberQuery();
PrintArrayElement(newArray, elementInArray);
