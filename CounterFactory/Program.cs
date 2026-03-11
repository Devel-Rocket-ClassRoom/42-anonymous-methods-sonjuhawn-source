using System;

// README.md를 읽고 아래에 코드를 작성하세요.

var c = CounterFactory.CreateSimpleCounter();

Console.WriteLine(c());
class CounterFactory
{
    static int c1 = 1;
    public static Func<int> CreateSimpleCounter()
    {
        
        return () => c1++;
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