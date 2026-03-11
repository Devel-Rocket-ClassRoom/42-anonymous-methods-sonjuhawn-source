using System;
using System.Collections.Generic;
using System.Text;

class DataProcessor
{
    int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    public void ForEach(Action<int> action)
    {
        foreach (int i in num)
        {
            action(i);
        }
    }
    public int[] Transform(Func<int, int> transformer)
    {
        int[] newnum = new int[11];
        foreach (int i in num)
        {
            newnum[i] = transformer(i);
        }
        return newnum;
    }
    public List<int> Filter(Func<int, bool> predicate)
    {
        List<int> ints = new List<int>();
        foreach (int i in num)
        {
            if (predicate(i))
            {
                ints.Add(i);
            }
        }
        return ints;
    }
    public void Reduce(Func<int, int, int> reducer, int initialValue)
    {
        int sum = initialValue;
        foreach (int i in num)
        {
            sum = reducer(i, sum);
        }
        Console.WriteLine($"합계: {sum}");
    }
}