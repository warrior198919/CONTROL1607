// Hello Word C#
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк: ");
        int n;
        if (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
            return;
        }

        string[] inputArr = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите строку {i + 1}: ");
            inputArr[i] = Console.ReadLine();
        }

        string[] resultArr = inputArr.Where(str => str.Length <= 3).ToArray();

        Console.WriteLine("Результат:");
        foreach (string str in resultArr)
        {
            Console.WriteLine(str);
        }
    }
}
