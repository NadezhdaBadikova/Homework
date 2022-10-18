void Zadacha0064()
{// Задача 64: Задайте значения N и M. Напишите программу, которая выведет 
// все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8


Console.Clear();

Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

string NumbersRecUp(int M, int N) 
{  
    if (M % 2 == 0)
    {
        if (M < N) return $"{M} " + NumbersRecUp(M + 2, N);
        else return String.Empty;
    }
    else
    {
        if (M < N) return $"{M + 1} " + NumbersRecUp(M + 2, N);
        else return String.Empty;   
    }
}

string NumbersRecDown(int M, int N) 
{
    if (M % 2 == 0)
    {
        if (N < M) return $"{M} " + NumbersRecDown(M - 2, N);
        else return String.Empty;
    }
    else
    {
        if (N <= M) return $"{M - 1} " + NumbersRecDown(M - 2, N);
        else return String.Empty;   
    }
}

Console.WriteLine();

if (N >= M)
{
    Console.WriteLine(NumbersRecUp(M, N));
}
else
{
    Console.WriteLine(NumbersRecDown(M, N));
}
}


void Zadacha0066()
{// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Clear();

Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumElements(M, N));
}

int SumElements(int M, int N, int sum = 0)
{
    if (M == N + 1)
    {
        return sum;
    }
    sum = sum + M;
    M++;
    return SumElements(M, N, sum);
}

void Zadacha0068()
{// Задача 68: Задайте значения M и N. Напишите программу, которая найдёт 
// наибольший общий делитель (НОД) этих чисел с помощью рекурсии.

// M = 28; N = 7 -> 7


Console.Clear();
    Console.Write("Введите число M: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите  число N: ");
    int N = Convert.ToInt32(Console.ReadLine());

void Delitel (int M, int N)
{
    if (M > N)
    {
        M = M % N;
    }
    else
    {
        N = N % M;
    }
    if (M != 0 && N != 0)
    {
        Delitel(M, N);
    }
    else
    {
        Console.WriteLine("Наибольший общий делитель (НОД) этих чисел = " + (M+N).ToString());
    }
}

Delitel(M, N);
    
}

Zadacha0064 ();
// Zadacha0066 ();
// Zadacha0068 ();