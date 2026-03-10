using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("");

class CounterFactory
{
    public static Func<int> CreateSimpleCounter()
    {
        int c1 = 1;
        return delegate { return c1++; };
    }
    public static Func<int> CreateStepCounter(int step)
    {
        int c2 = step;
        return delegate { return c2 += step; };
    }
    public static Func<int> CreateBoundedCounter(int min, int max)
    {
        int c3 = min;
        if (min < c3 && c3 <= max)
        {
            return delegate { return c3; };
        }
        else
        {
            return delegate { return c3 % max + min; };
        }

    }
}