// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// Функция - вывод созданного двумерного массива из случайных символов
void PrintCreateTwoDimensionalCharArray(char[,] array)
{
    Random rnd = new Random();
    Console.WriteLine("Созданный двумерный массив из случайных символов");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"Строка {i}: ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            char randomChar = (char)rnd.Next('a', 'z' + 1);
            array[i, j] = randomChar;
            Console.Write($"{randomChar}, ");
        }
        Console.WriteLine();
    }
}

// Функция - создание строки из двумерного массива символов
string GetStringFromTwoDimensionalCharArray(char[,] array)
{
    string str = ""; // StringBuilder class - посмотреть что это
    foreach (char e in array)
    {
        str += e;
    }
    return str;
}

Console.Clear();
Console.Write("Введите число - количество строк в двумерном массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите число - количество столбцов в двумерном массиве: ");
int col = int.Parse(Console.ReadLine()!);
char[,] charArray = new char[row, col];

PrintCreateTwoDimensionalCharArray(charArray);
string charOfArray = GetStringFromTwoDimensionalCharArray(charArray);
Console.Write($"Созданная строка из двумерного массива: [{charOfArray}]");