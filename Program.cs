Console.Clear();
/* 
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

int[,] CreateMatrix(int row, int column, int leftside, int rightside)
{
    Random rnd = new Random();
    int[,] matr = new int[row, column];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(leftside, rightside);
        }
    }
    return matr;
}
 */
// Найти произведение двух матриц

/* int n = ReadInt("Введите количество строк в массиве: ");
int m = ReadInt("Введите количество столбцов в массиве: ");
int l = ReadInt("Введите границу левого диапазона чисел: ");
int r = ReadInt("Введите границу правого диапазона чисел: ");
int[,] matrix1 = CreateMatrix(n, m, l, r);
PrintMatrix(matrix1);
Console.WriteLine();
 */
/* int[,] matrix2 = CreateMatrix(n, m, l, r);
PrintMatrix(matrix2);
Console.WriteLine();

int[,] matr = new int[n, m];
for (int i = 0; i < matrix1.GetLength(0); i ++)
{
    for (int j = 0; j < matrix1.GetLength(1); j ++)
    {
        matr[i, j] = matrix1[i, j] * matrix2[i,j];
    }
}
PrintMatrix(matr); */

//В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

/* int min = matrix1[0,0];
int minrow = 0;
int mincol = 0;
for (int i = 0; i < matrix1.GetLength(0); i ++)
{
    for (int j = 0; j < matrix1.GetLength(0); j ++)
    {
        if (matrix1[i,j] < min)
        {
            min= matrix1[i, j];
            minrow = i;
            mincol = j;
        }
    }
}
 Console.WriteLine($" {min} , {minrow}, {mincol} .");
 void PrintItogMassive(int[,] matrix, int row, int col)
 {
    for (int i  = 0; i < matrix.GetLength(0); i ++)
    {
        for (int j = 0; j < matrix.GetLength(1); j ++)
        {
            if ((i != row) && (j != col))
            {
                Console.Write($"{matrix[i,j]} ");
            }
        }
        Console.WriteLine();
    }
 }
 */
// PrintItogMassive(matrix1, minrow, mincol);

//Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

/* Random rnd = new Random();

int[,,] CreateMatrix3(int row, int col, int lays)
{
    int[,,] matr3 = new int[row, col, lays];

    for (int i = 0; i < matr3.GetLength(0); i ++)
    {
        for (int j = 0; j < matr3.GetLength(1); j ++)
        {
            for (int k = 0; k < matr3.GetLength(2); k ++)
            {
                   matr3[i, j, k] = rnd.Next(10,100);
            }
        }
    }
    return matr3;
}

void PrintMatrix3(int[,,] matr3)
{
    for (int k = 0; k < matr3.GetLength(2); k++)
    {
        for (int i = 0; i < matr3.GetLength(0); i++)
        {
            for (int j = 0; j < matr3.GetLength(1); j++)
            {
                Console.Write($"{matr3[i, j, k]} ({i} , {j}, {k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] matrix3 = CreateMatrix3(2,2,2);
PrintMatrix3(matrix3);
 */

//Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

/* //Вариант1

  Console.WriteLine("Введите количество строк треугольника Паскаля:");
int numberrows = int.Parse(Console.ReadLine()) + 1;
  Console.WriteLine();
int[,] FillArray(int rows)
{
    int columns = rows + 2;
    int[,] array = new int[rows, columns];
    for (int i = 1; i < array.GetLength(0); i++)
    {
        array[i, 0] = 1;
        for (int j = 1; j < array.GetLength(1); j++)
        {
            array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
        }
        
    }
    return array;
}

void PrintPascalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = array.GetLength(0); j > i; j--)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < array.GetLength(1); j++)
            {
                 if (array[i, j] != 0) Console.Write($"{array[i, j]} " );
            }
        Console.WriteLine();
    }
}

int[,] array = FillArray(numberrows);

PrintPascalArray(array); */ 
 
/* // Вариант2

Console.WriteLine("Введите количество строк треугольника Паскаля:");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine();
float factorial(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}
void Pascal(int rows)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j <= (n - i); j++)
        {
            Console.Write(" ");
        }
        for (int c = 0; c <= i; c++)
        {
            Console.Write($"{factorial(i) / (factorial(c) * factorial(i - c))} ");
        }
        Console.WriteLine();
    }
}
Pascal(n); */