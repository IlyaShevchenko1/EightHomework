// Eighth homework

// Task 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.

/*

int[,] CreateRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min value of array: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max value of array: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SortLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                int temp = array[i, k];
                array[i, k] = array[i, k + 1];
                array[i, k + 1] = temp;
                }

            }
            
        }
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();

SortLines(myArray);
Show2dArray(myArray);

*/

// Task 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.

/*

int[,] CreateRandom2dArray()
{
    int rows = 0;
    int columns = 0;
    while (rows == columns)
    {
        Console.Write("Input a quantity of rows: ");
        rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a quantity of columns: ");
        columns = Convert.ToInt32(Console.ReadLine());
        if (rows == columns) Console.WriteLine("Массив должен быть прямоугольным");
    }
    
    Console.Write("Input a min value of array: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max value of array: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;   
    
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void RowWithMinSumOfElements(int[,] array)
{
    int sum = 0;
    int minSum = 0;
    int minRow = 0;
    for(int i = 0, j = 0; j < array.GetLength(1); j++)
        {
           minSum = minSum + array[i, j];
           minRow = i;
        }
    for(int i = 1; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++ )
        {   
            sum = sum + array[i, j]; 
        }
        if(sum < minSum)
        {
        minSum = sum;
        minRow = i;
        }
        sum = 0;
    }
    Console.WriteLine($"Наименьшая сумма элеметов {minSum} в строке {minRow + 1}");  
}

int[,]myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
RowWithMinSumOfElements(myArray);

*/

// Task 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух
// матриц.

/*

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] firstArray, int[,] secondArray)
{
    int sum = 0;
    int[,] array = new int[firstArray.GetLength(0), secondArray.GetLength(1)];

    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                sum = sum + firstArray[i, k] * secondArray[k, j];
            }
            array[i, j] = sum;
            sum = 0;
        }
    }

    return array;
}

Console.Write("Input a quantity of rows of first matrix: ");
int firstRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of columns of first matrix: ");
int firstColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value of first matrix: ");
int firstMinValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value of first matrix: ");
int firstMaxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Quantity of second matrix rows have to be equal, " +
"to quantity of first matrix columns: " + firstColumns);
Console.Write("Input a quantity of columns of second matrix: ");
int secondColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value of second matrix: ");
int secondMinValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value of second matrix: ");
int secondMaxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] myFirstArray = CreateRandom2dArray(firstRows, firstColumns, firstMinValue, firstMaxValue);
int[,] mySecondArray = CreateRandom2dArray(firstColumns, secondColumns, secondMinValue, secondMaxValue);

Show2dArray(myFirstArray);
Console.WriteLine();
Show2dArray(mySecondArray);
Console.WriteLine();
int[,] multiArray = MatrixMultiplication(myFirstArray, mySecondArray);
Show2dArray(multiArray);

*/

// Task 60. Сформируйте трехмерный массив из неповторяющихся двухзначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*

int[,,] CreateRandom3dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of layers: ");
    int layers = Convert.ToInt32(Console.ReadLine());
    
    int[,,] array = new int[rows, columns, layers];
    int number = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < layers; k++)
            {
                number = new Random().Next(-99, 100);
                if (number < 10 && number > -10)
                {
                    k--;
                    continue;
                }
                if (CheckNumber(array, number))
                {
                    k--;
                    continue;
                }
                else array[i, j, k] = number;
            }
        }
        
    }

    return array;
}

void Show3dArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
     
}

bool CheckNumber(int [,,] array, int num) 
 { 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             for (int k = 0; k < array.GetLength(2); k++)
            {
                 if(num == array[i, j, k])
                {
                    return true; 
                } 
            } 
        }
    }
    return false; 
 }

int[,,] myArray = CreateRandom3dArray();
Console.WriteLine();
Show3dArray(myArray);

*/

// Task 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// (Попробовать написать программу для любого размера n x n).

/*

int[,] CreateSpiralArray()
{
    Console.Write("Input a size of array: ");
    int size = Convert.ToInt32(Console.ReadLine());
   
    int[,] array = new int[size, size];
    int i = 0;
    int j = 0;
    int number = 1;
    int finish = size * size;

    while (number <= finish)
    {
        array[i, j] = number;
        if (i <= j + 1 && i + j < size - 1) j++;
        else if (i < j && i + j >= size - 1) i++;
        else if (i >= j && i + j > size - 1) j--;
        else i--;
        number++;
    }
    return array;
}


void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10) Console.Write("0" + array[i, j] + " ");
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] myArray = CreateSpiralArray();
Show2dArray(myArray);

*/