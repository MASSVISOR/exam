// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

public class Program
{
    static void Main(string[] args)
    {
        int[] array = { 0, 1, 2, 5, 6, 7, 9, 10, 11, 12, 13, 14, 15 };
        Console.WriteLine("Элементы массива, начиная с конца:");
        PrintArrayReverse(array, array.Length - 1);
    }

    static void PrintArrayReverse(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(array[index]);
            PrintArrayReverse(array, index - 1);
        }
    }
}
