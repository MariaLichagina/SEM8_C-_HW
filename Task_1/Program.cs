// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


// Знакомство с языками программирования (семинары)
// Урок 8. Двумерные массивы. Продолжение
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;
using static System.Console;

int [,] array = GetArray(5, 5);
PrintArray(array);
WriteLine();
SortArrayTwoDim(array);
PrintArray(array);

int [,] GetArray (int m, int n)
{
int [,] array = new int [m, n];
Random random = new Random();
int maxValue = 100;

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

void SortArrayTwoDim (int [,] array) {
    for (int k=0; k < array.GetLength(0); k++) {
        for (int i = 0; i < array.GetLength(1); i++)
				for (int j = 0; j < array.GetLength(1) - 1; j++)
					if (array[k, j] < array[k, j + 1])
					{
						int t = array[k, j + 1];
						array[k, j + 1] = array[k, j];
						array[k, j] = t;
					}
    }
}