// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("________________________________");
int [,] matrix = new int [row, column];

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        matrix[i,j] = new Random().Next(10);
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}

double sum = 0;
Console.WriteLine();
Console.WriteLine("Среднее арифметическое кардого столбца: ");

for (int j = 0; j < column; j++)
{
    for (int i = 0; i < row; i++)
    {
        sum += matrix[i,j];
    }
Console.Write(sum + "/ " + row + " = ");
Console.Write(sum/row + "\t");
sum = 0;
}