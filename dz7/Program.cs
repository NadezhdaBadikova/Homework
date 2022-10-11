
void Zadacha0047()
{
    // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    // m = 3, n = 4.

    // 0,5 7 -2 -0,2
    // 1 -3,3 8 -9,9
    // 8 7,8 -7,1 9


    Console.Clear();

    int rows = 3;
    int columns = 4;
    float [,] numbers = new float [rows, columns];
    FillArray(numbers);
    PrintArray(numbers);

    void FillArray(float [,] numbers)
    {
        Random random = new Random();
        
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                numbers [i,j] = random.Next(-10, 10);
            }
        }
    }

    void PrintArray(float[,] numbers)
    {
        
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.Write((float)numbers[i,j] + "\t");
            }
            Console.WriteLine ();
        }
    }
}


void Zadacha0050()
{
    // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
    // и возвращает значение этого элемента или же указание, что такого элемента нет.
    // Например, задан массив:

    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 17 -> такого числа в массиве нет

    Console.Clear();
    Random random = new Random();
    int rows = random.Next(4,5);
    int columns = random.Next(4,5);
    int[,] numbers = new int [rows, columns];

    FillArray1(numbers);
    PrintArray1(numbers);
    FindNum(numbers);

    void FillArray1(int[,] numbers)
    {
        Random random = new Random();
        
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                numbers [i,j] = random.Next(-10, 10);
            }
        }
    }

    void PrintArray1(int[,] numbers)
    {
        
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.Write(numbers[i,j] + "\t");
            }
            Console.WriteLine ();
        }
    }
    void FindNum(int[,] numbers)
    {
    Console.Write ("Введите число: ");
    int num = int.Parse(Console.ReadLine());
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                if (num == numbers[i,j])
                {
                    return;
                }
            }
        }
        Console.Write ("Такого числа в массиве нет"); 
    }
}


void Zadacha0052()
{
    // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

    Console.Clear();
    Random random = new Random();
    int rows = random.Next(4,5);
    int columns = random.Next(4,5);
    int[,] numbers = new int [rows, columns];

    FillArray2(numbers);
    PrintArray2(numbers);
    MathMass(numbers);

    void FillArray2(int[,] numbers)
    {
        Random random = new Random();
        
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                numbers [i,j] = random.Next(0, 10);
            }
        }
    }

    void PrintArray2(int[,] numbers)
    {
        
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.Write(numbers[i,j] + "\t");
            }
            Console.WriteLine ();
        }
    }

    void MathMass(int[,] numbers)
    {
        for (int i = 0; i < numbers.GetLength(0); i++) 
            {
                int srAr = 0;
                
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    srAr += numbers[j, i];
                }
                Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)srAr/columns}");
                
            }
    }

}

Zadacha0047 ();
// Zadacha0050 ();
// Zadacha0052 ();
