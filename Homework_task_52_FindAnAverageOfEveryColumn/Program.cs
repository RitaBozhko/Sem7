// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = 5;
int n = 5;
int[,] array = new int[m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next(10);
        Console.Write($"{array[i,j]} ");
    
    }
    Console.WriteLine();
}

void FindAverage(int[,] array)
{
    double sum = 0;
    for (int j = 0; j < n; j++)
    {
        for (int i = 0; i < m; i++)
        {
            sum += array[i,j];
        }
        Console.WriteLine($"Среднее арифметическое столбца с индексом {j} равно {Math.Round(sum/m, 2)}");
        sum = 0;
    }
}

FindAverage(array);