// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк массива:");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int coloumns = int.Parse(Console.ReadLine());
double [] resultArray = new double[coloumns];

int[,] matrix = new int[rows, coloumns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-100, 100);
        Console.Write(matrix[i, j] + "\t");
        resultArray [j] += Convert.ToDouble(matrix[i,j])/matrix.GetLength(0);
    }
    Console.WriteLine();
}

Console.Write("Среднее арифметическое столбцов массива равно:");
for (int i = 0; i < matrix.GetLength(1); i++)
{
    Console.Write(Math.Round(resultArray[i],2) + "; ");
}

