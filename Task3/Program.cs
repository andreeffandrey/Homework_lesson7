// Задача 3: Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.
class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 5, 0, 10, 34 };

        PrintArrayRevers(array, array.Length - 1);

        Console.ReadLine();

    }
    static void PrintArrayRevers(int[] arr, int i)

    {
        if (i < 0)
            return;

        Console.Write(arr[i] + " ");

        PrintArrayRevers(arr, i - 1);
    }
}


