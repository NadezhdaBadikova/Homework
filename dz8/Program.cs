
    void FillArray(int[,] numbers)
    {
        Random random = new Random();
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                numbers [i,j] = random.Next(0, 10);
            }
        }
    }
    

void PrintArray(int[,] numbers)
    {
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(numbers[i,j] + "\t");
            }
            Console.WriteLine ();
        }
    }


void Zadacha0054()
{// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

Random random = new Random();
int rows = random.Next(4,5);
int columns = random.Next(4,5);
int[,] numbers = new int [rows, columns];

FillArray(numbers);
PrintArray(numbers);

Console.WriteLine($"\nОтсортированный массив : ");
SortStringArray(numbers);
PrintArray(numbers);

void SortStringArray(int[,] numbers)
{
  for (int i = 0; i < numbers.GetLength(0); i++)
  {
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
      for (int k = 0; k < numbers.GetLength(1) - 1; k++)
      {
        if (numbers[i, k] < numbers[i, k + 1])
        {
          int temp = numbers[i, k + 1];
          numbers[i, k + 1] = numbers[i, k];
          numbers[i, k] = temp;
        }
      }
    }
  }
}
}

void Zadacha0056()
{// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
// 1 строка

Console.Clear();

Random random = new Random();
int rows = random.Next(4,4);
int columns = random.Next(4,4);
int[,] numbers = new int [rows, columns];

FillArray(numbers);
PrintArray(numbers);


int minSumLine = 0;
int sumLine = SumLineElements(numbers, 0);
for (int i = 1; i < numbers.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(numbers, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

int SumLineElements(int[,] numbers, int i)
{
  int sumLine = numbers[i,0];
  for (int j = 1; j < numbers.GetLength(1); j++)
  {
    sumLine += numbers[i,j];
  }
  return sumLine;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой элементов = {sumLine} ");
 

}

void Zadacha0058()
{    // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

Random random = new Random();
int rowsFirst = random.Next(4,8);
int columnsFirst = random.Next(4,8);
int rowsSecond = columnsFirst;
int columnsSecond = random.Next(5,5);
int[,] numbersFirst = new int [rowsFirst, columnsFirst];
int[,] numbersSecond = new int [rowsSecond, columnsSecond];
FillArray(numbersFirst);
PrintArray(numbersFirst);
Console.WriteLine();
FillArray(numbersSecond);
PrintArray(numbersSecond);

int [,] result = new int [rowsFirst,columnsSecond];
for (int i = 0; i < rowsFirst; i++)
{
    for (int j = 0; j < columnsSecond; j++)
    {
        for (int k = 0; k < rowsSecond; k++)
        {
            result[i,j] += numbersFirst[i,k]*numbersSecond[k,j];
        }
    }
}


Console.WriteLine();
PrintArray (result);
}

Zadacha0054 ();
// Zadacha0056 ();
// Zadacha0058 ();