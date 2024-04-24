using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 5;
        Console.WriteLine($"The factorial of {number} is {Factorial(number)}");
    }

    static int Factorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }
}

