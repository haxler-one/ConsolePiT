using System;

class ProgramFibonacci
{
    static void Main(string[] args)
    {
        int result = Fibonacci(5);
        Console.WriteLine(result);
    }

    static int Fibonacci(int n)
    {
        if (n == 0) return 0; // Обработка случая, когда n = 0
        if (n == 1) return 1; // Обработка случая, когда n = 1

        int n1 = 0;
        int n2 = 1;
        int sum = 0;

        for (int i = 2; i <= n; i++)
        {
            sum = n1 + n2;
            n1 = n2;
            n2 = sum;
        }

        return n2; // Возвращаем n2, который содержит n-ое число Фибоначчи
    }
}

