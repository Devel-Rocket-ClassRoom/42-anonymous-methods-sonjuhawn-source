using System;
using System.Collections.Generic;

// README.md를 읽고 아래에 코드를 작성하세요.

DataProcessor data = new DataProcessor();
Console.WriteLine("=== 원본 배열 출력 ===");
data.ForEach(delegate (int i) { Console.Write($"{i} "); });
Console.WriteLine();

Console.WriteLine("=== 2배로 변환 ===");
int[] num1 = data.Transform(delegate (int i) { return i * 2; });
foreach (int i in num1)
{
    Console.Write($"{i} ");
}
Console.WriteLine();

Console.WriteLine("=== 짝수만 필터링 ===");
List<int> num2= data.Filter(delegate (int i) { return i % 2 == 0; });
foreach (int i in num2)
{
    Console.Write($"{i} ");
}
Console.WriteLine();

Console.WriteLine("=== 합계 계산 ===");
data.Reduce(delegate (int x, int y) { return x + y; }, 0);

