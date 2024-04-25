// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите натуральное число m:");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите натуральное число n:");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = AckermannFunction(m, n);
        Console.WriteLine($"Результат функции Аккермана для m = {m} и n = {n}");
        Console.WriteLine(result);


        static int AckermannFunction(int m, int n)
        {
            if (m == 0)
                return n + 1;
            else if (n == 0)
                return AckermannFunction(m - 1, 1);
            else
                return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}