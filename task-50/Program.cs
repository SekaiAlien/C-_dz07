// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Укажите строку:");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите столбец:");
int column = Convert.ToInt32(Console.ReadLine());


int [,] matrix = new int [3, 4];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrix[i,j] = new Random().Next(100);
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

if(((row < 0) || (row > 2)) && ((column < 0) || (column > 3)))
{
    Console.WriteLine("Такого элемента в массиве нет");
}

else
{
    Console.WriteLine("Значение указанного элемента = " + matrix[row, column]);
}