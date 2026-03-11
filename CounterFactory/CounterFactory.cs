using System;
using System.Collections.Generic;
using System.Text;

class CounterFactory
{
    int c1 = 1;
    public static Func<int> CreateSimpleCounter()
    {
        int c1 = 1;
        return () => c1++;
    }
    public static Func<int> CreateStepCounter(int step)
    {
        int c2 = 0;
        return delegate { return c2 += step; };
    }
    public static Func<int> CreateBoundedCounter(int min, int max)
    {
        int c3 = min;

        return delegate {
            if (c3 > max)
            {
                c3 = min;
            }
            return c3++;
        };
    }
    public static void CreateResettableCounter(out Action reset, out Func<int> c)
    {
        int c4 = 1;
        reset = () => c4 = 1;

        c = () => c4++;
    }
}
