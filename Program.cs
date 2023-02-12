Console.Clear();

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

// Составить частотный словарь элементов двумерного массива
/* 
int n = ReadInt("Введите количество строк в массиве: ");
int m = ReadInt("Введите количество столбцов в массиве: ");
int l = ReadInt("Введите границу левого диапазона чисел: ");
int r = ReadInt("Введите границу правого диапазона чисел: ");
int[,] matrix = CreateMatrix(n, m, l, r);
PrintMatrix(matrix);
Console.WriteLine();

int[] CreateArray(int[,] matrix)
{
    int[] array = new int[n * m];
    int size = 0;
    while (size < m * n)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                array[size] = matrix[i, j];
                size++;
            }
        }
    }
    return array;
}
int[] array = CreateArray(matrix);

Console.WriteLine(string.Join(", ", array));
Console.WriteLine();

void Count(int[] array)
{
    for (int temp = l; temp <= r; temp++)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == temp) count++;
        }
        if (count != 0)
        {
            double percent = (double)count * 100 / (double)array.Length;
            Console.WriteLine($"{temp} встречается {count} раз(а). Частота {Math.Round(percent, 2)}%");
        }
    }
}
Console.WriteLine("Частотный анализ может выглядеть так:");
Count(array); */

// на строках (вариант с сортировкой)

Console.WriteLine("Введите текст");
string res = Console.ReadLine()!; //ввод строки

string[] array = new string[res.Length];
for (int i = 0; i < res.Length; i++) array[i] = res[i].ToString(); //перевод строки в массив

Array.Sort(array); // Сортировка массива { / / /k/k/k/k/l/l/l/l}
                                        //0/1/2/3/4/5/6/7/8/9/10
void PrintElementsFromSortArray(string[] array)
{
    int j = 0;
    int firstPointer= -1;
    while (j < array.Length)
    {
        while ((j < array.Length - 1) && (array[j] == array[j + 1]))
        {
            j++;
        }
        int counter = j - firstPointer;
        Console.WriteLine($"Элемент '{array[j]}' встречается {counter.ToString()} раз. Частота вхождения {counter * 100 / array.Length} %. ");
        firstPointer = j;
        j++;
    }
}
PrintElementsFromSortArray(array);

/* string  CreateDictionary(int[] array)
{
    string dict = String.Empty;
    dict += array[0];
    for (int i = 0; i < array.Length; i++)
    {
        int counter = 0;
        for (int s = 0; s < dict.Length; s ++)
        {
            if (array[i] == dict[s]) 
            {
                counter ++;
            }
            else dict += array[i];
        }
    }
    return dict;
}

CreateDictionary(array); */

//https://learn.microsoft.com/ru-ru/dotnet/csharp/programming-guide/arrays/jagged-arrays









//Найти произведение двух матриц
/* 
int n1 = ReadInt("Введите количество строк в первом массиве: ");
int m1 = ReadInt("Введите количество столбцов в первом массиве: ");
int l1 = ReadInt("Введите границу левого диапазона чисел: ");
int r1 = ReadInt("Введите границу правого диапазона чисел: ");
int[,] matrix1 = CreateMatrix(n1,m1,l1,r1);
PrintMatrix(matrix1);
Console.WriteLine();
int n2 = ReadInt("Введите количество строк во втором массиве: ");
int m2 = ReadInt("Введите количество столбцов во втором массиве: ");
int l2 = ReadInt("Введите границу левого диапазона чисел: ");
int r2 = ReadInt("Введите границу правого диапазона чисел: "); 
int[,] matrix2 = CreateMatrix(n2,m2,l2,r2);
PrintMatrix(matrix2);
Console.WriteLine();
if (m1 == n2)
{
    int[,] powmatrix = new int[n1, m2];
    for (int i = 0; i < powmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < powmatrix.GetLength(1); j++)
        {
            for (int r = 0; r < n2; r++)
            {
                powmatrix[i, j] += matrix1[i, r] * matrix2[r, j];
            }
        }
    }
PrintMatrix(powmatrix); 
}
else Console.WriteLine("Матрицы не согласованы."); */

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

/* //Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

Random rnd = new Random();

int[] CreateMassiveElements(int count)
{
int[] elements = new int[count];
for (int i = 0; i < elements.Length; i++)
{
    elements[i] = 10 + i;
}
for (int i = elements.Length - 1; i >= 1; i--)
{
   int j = rnd.Next(i + 1);
   int temp = elements[j];
   elements[j] = elements[i];
   elements[i] = temp;
}
   return elements;
}

Console.WriteLine(string.Join(" ", CreateMassiveElements(50)));

int[,,] CreateMatrix3(int row, int col, int lays)
{
    int[,,] matr3 = new int[row, col, lays];
    int[] massive = CreateMassiveElements(matr3.Length);
    int m = 0;
    while (m < massive.Length)
    {
        for (int i = 0; i < matr3.GetLength(0); i++)
        {
            for (int j = 0; j < matr3.GetLength(1); j++)
            {
                for (int k = 0; k < matr3.GetLength(2); k++)
                {
                    matr3[i, j, k] = massive[m];
                    m++;
                }
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

int x = ReadInt("Введите количество строк в массиве: ");
int y = ReadInt("Введите количество столбцов в массиве: ");
int z = ReadInt("Введите количество слоев в массиве: ");

int[,,] matrix3 = CreateMatrix3(x, y, z);
if (matrix3.Length < 90) PrintMatrix3(matrix3);
else Console.WriteLine("Вывод невозможен"); 
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