/* Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9

*/

/*
int[,] Create2DRandomArray(int rows, int columns , int minValue, int maxValue)
{
    int [,] newArray = new int[rows,columns];
    for(int i = 0;i < rows; i++)
        for(int j = 0; j < columns; j ++)
        {
            newArray[i,j] = new Random().Next(minValue,maxValue + 1);
        }
    return newArray;    
}
void Show2DArray (int[,] array )
{
    for(int i = 0;i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }    
}
Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray= Create2DRandomArray(m , n , min, max);
Show2DArray(myArray);
*/


/*Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

/*
int [,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue, int a, int b)
{
    int[,] newArray = new int[rows, columns];                        
    for(int i = 0; i < rows; i++)                                   
        for(int j = 0; j < columns; j++)                             
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
        return newArray;
}
void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {                                   
        for(int j = 0; j < array.GetLength(1); j++)                             
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();}
}
int[,] ShowNumber(int[,] array, int a, int b)                                      
{   
    object Num = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) 
        {
            if(a > array.GetLength(0) && b > array.GetLength(1))
            {
                Console.WriteLine($"Число по указанным координатам отсутствует");
            }                                                               
            else 
            {
                Num = array.GetValue(a,b);
            }
        }
    }   
    Console.WriteLine($"Число, которое расположено по указанным координатам -> {Num}");
    return array;                                                                 
}
Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение:");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение по вертикали:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение по горизонтали:");
int b = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandomArray(m, n, minValue, maxValue, a, b);
Console.WriteLine();
Show2DArray(ShowNumber(myArray, a, b));

*/

/*Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

/*
int[,] Create2DRandomArray(int rows, int columns , int minValue, int maxValue)
{
    int [,] newArray = new int[rows,columns];
    for(int i = 0;i < rows; i++)
        for(int j = 0; j < columns; j ++)
        {
            newArray[i,j] = new Random().Next(minValue,maxValue + 1);
        }
    return newArray;    
}
void Show2DArray (int[,] array )
{
    for(int i = 0;i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }    
}
int [,] ElementsCount(int[,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        double result=0;
        
        for(int j =0; j < array.GetLength(1); j ++)
        {
            sum+=array[j,i];
            result= sum / array.GetLength(1) ;
        }
        Console.WriteLine(result);
    }
    return array;
   
} 
Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray= Create2DRandomArray(m , n , min, max);
Show2DArray(myArray);
ElementsCount(myArray);
*/

