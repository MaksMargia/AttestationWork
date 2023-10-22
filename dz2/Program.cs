// #2
using System;

class Programs
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        int sum = SumNaturalNumbersInRange(M, N);

        Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N} равна {sum}");

        Console.ReadLine(); // Чтобы консольное окно не закрылось сразу
    }

    static int SumNaturalNumbersInRange(int start, int end)
    {
        int sum = 0;

        for (int i = start; i <= end; i++)
        {
            sum += i;
        }

        return sum;
    }
}