// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

internal class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 5, 0, 10, 34 };
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
