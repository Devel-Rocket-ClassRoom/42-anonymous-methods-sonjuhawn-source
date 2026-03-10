using System;

// README.md를 읽고 아래에 코드를 작성하세요.
//Console.WriteLine("'''");
//{
//    Calculator calc = delegate (int x) { return x * x; };
//    calc(5);

//    delegate int Calculator(int x);
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    int factor = 3;

//    Func<int, int> multiplier = delegate (int n) { return n * factor; };
//    multiplier(10);
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    int factor = 2;

//    Func<int, int> multiplier = delegate (int n) { return n * factor; };
//    multiplier(5);
//    factor = 10;
//    multiplier(5);
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    int counter = 0;

//    Action increment = delegate { counter++;  Console.WriteLine($"현재 카운터: {counter}"); };
//    increment();
//    increment();
//    increment();
//    Console.WriteLine($"최종 카운터: {counter}");
//}
//Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    Func<int> counter1 = CreateCounter();
    Func<int> counter2 = CreateCounter();
    Console.WriteLine($"counter1: {counter1}");
    Console.WriteLine($"counter1: {counter1}");
    Console.WriteLine($"counter1: {counter1}");
    Console.WriteLine($"counter2: {counter2}");
    Console.WriteLine($"counter2: {counter2}");
}
Console.WriteLine("'''\n");


static Func<int> CreateCounter()
{
    int count = 0;
    return delegate
    {
        count++;
        return count;
    };
}
