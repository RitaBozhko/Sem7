// Задача 50. 
// Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Введите двухзначное число");
int userEnter = int.Parse(Console.ReadLine()!);

int m = 3;
int n = 4;
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

if(userEnter/10<=m && userEnter%10<=n)
    Console.WriteLine($"Элемент на позиции [{userEnter/10}, {userEnter%10}] является {array[userEnter/10,userEnter%10]}");
else Console.WriteLine($"Элемента на позиции [{userEnter/10}, {userEnter%10}] нет");