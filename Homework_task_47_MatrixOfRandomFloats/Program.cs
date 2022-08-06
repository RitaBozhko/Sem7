// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// string.Format("{0:f1}", sum1column/);


Console.Write("Задайте размер массива MxN.\nm = ");
int.TryParse(Console.ReadLine(), out int m);
Console.Write("n = ");
int.TryParse(Console.ReadLine(), out int n);

double[,] arrayOfFloats = new double[m,n];

void FillArrayWithFloats(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100,100))/10;
            Console.Write(string.Format("{0,4:f1} ", array[i,j]));
        }
        Console.WriteLine();
    }
}

FillArrayWithFloats(arrayOfFloats);