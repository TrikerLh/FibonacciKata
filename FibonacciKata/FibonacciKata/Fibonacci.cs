namespace FibonacciKata.Tests;

public class Fibonacci
{
    public static int Get(int number)
    {
        if (number == 0) return 0;
        if (number is 1 or 2) 
            return 1;
        return Get(number - 1) + Get(number - 2);
    }
}