using System;
using System.Collections.Generic;

// README.md를 읽고 아래에 코드를 작성하세요.
//Console.WriteLine("'''");
//{
//    Calculator anonymous = delegate (int x) { return x * x; };
//    Calculator lambda = x => x * x;

//    Console.WriteLine($"익명 메서드: {anonymous}");
//    Console.WriteLine($"람다식: {lambda}");

//    delegate int Calculator(int x);
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//    Filter two = Filter(numbers, delegate (int n) { return n % 2 == 0; });
//    Filter than5 = Filter(numbers, delegate (int n) { return n > 5; });

//    Console.WriteLine($"짝수: {string.Join(two, " ")}");
//    Console.WriteLine($"홀수: {string.Join(than5, " ")}");
//}
//Console.WriteLine("'''\n");

//static List<int> Filter(int[] source, Func<int, bool> predicate)
//{
//    List<int> result = new List<int>();
//    foreach(int i in source)
//    {
//        if (predicate(i))
//        {
//            result.Add(i);
//        }
//    }
//}