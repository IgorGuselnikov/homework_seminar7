// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк массива:");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int coloumns = int.Parse(Console.ReadLine());


int[,] matrix = new int[rows, coloumns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-100, 100);
        Console.Write(matrix[i, j] + "\t");

    }
    Console.WriteLine();
}

Console.WriteLine("Введите номер строки элемента массива:");
int numberRows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента массива:");
int numberColoumns = int.Parse(Console.ReadLine());

if (numberRows >= 0 && numberRows <= matrix.GetLength(0) && numberColoumns >= 0 && numberColoumns <= matrix.GetLength(1))
{
    Console.Write($"Запрашиваемый элемент массива: {matrix[numberRows, numberColoumns]}");
}
else
{
    Console.Write("такого элемента в матрице не существует");
}
