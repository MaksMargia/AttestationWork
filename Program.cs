//Первая задачка
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        PrintNaturalNumbersFromNTo1(N);

        Console.ReadLine(); // Чтобы консольное окно не закрылось сразу
    }

    static void PrintNaturalNumbersFromNTo1(int N)
    {
        if (N >= 1)
        {
            Console.Write(N);

            if (N > 1)
            {
                Console.Write(", ");
            }

            PrintNaturalNumbersFromNTo1(N - 1);
        }
    }
}