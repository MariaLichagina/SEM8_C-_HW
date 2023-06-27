// See https://aka.ms/new-console-template for more information

// / Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


using System;
using static System.Console;

WriteLine("Введите число строк в матрицах: ");
int m = int.Parse(ReadLine());

WriteLine("Введите число столбцов в матрицах: ");
int n = int.Parse(ReadLine());

int [,] array = GetArray(m, n);
PrintArray(array);
WriteLine();
int [,] array1 = GetArray(m, n);
GetArray(m, n);
PrintArray(array1);
WriteLine();
int [,] result = SumMatrix(array, array1);
PrintArray(result);


int [,] GetArray (int m, int n)
{
int [,] array = new int [m, n];
Random random = new Random();
int maxValue = 10;

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = random.Next(maxValue);
        
    }
    
}
return array;
    
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

int[,] SumMatrix(int[,] array1, int [,] array2)
{
    int [,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < array3.GetLength(0); i++)
        {
            for (int j = 0; j < array3.GetLength(1); j++)
            {
             array3[i, j] = 0;
                for (int n = 0; n < array1.GetLength(1); n++)
                {
                 array3[i, j] += array1[i, n] * array2[n, j];
                }
            }
        }
    }
    return array3;
}