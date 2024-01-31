// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

{
    Console.WriteLine("Введите целое число M:");
    int M = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите целое число N:");
    int N = int.Parse(Console.ReadLine());

    int min, max;

    if (M < N)
    {
        min = M;
        max = N;
    }
    else
    {
        min = N;
        max = M;
    }

    PrintNumbers(min, max);
}

static void PrintNumbers(int m, int n)

{
    if (m > n)

        return;

    Console.Write(m);
    if (m < n)
    Console.Write(", ");

    PrintNumbers(++m, n);
}


