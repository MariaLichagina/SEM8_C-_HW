// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;
using static System.Console;

WriteLine("Введите число строк массива: ");
int m = int.Parse(ReadLine());

WriteLine("Введите число столбцов массива: ");
int n = int.Parse(ReadLine());

int [,] array = GetArray(m, n);
PrintArray(array);
WriteLine();
SumArray(array);


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

void SumArray(int[,] array)
{
    int indexOfMinSum = 0;
    int minSum = 0;
    for (int j = 0; j < array.GetLength(1); j++) {
        minSum = minSum + array[0, j];
    }

    for (int i = 1; i < array.GetLength(0); i++)
    { 
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
           sum = sum + array[i, j];
        }
        if (minSum > sum) {
            minSum = sum;
            indexOfMinSum = i;
        }
    }

    WriteLine($"Номер строки с наименьшей суммой элементов: {indexOfMinSum + 1} ");
}