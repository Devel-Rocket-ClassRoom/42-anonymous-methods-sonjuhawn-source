using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Console.WriteLine("=== 단순 카운터 ===");
var c = CounterFactory.CreateSimpleCounter();
for (int i = 0; i < 5; i++)
{
    Console.Write($"{c()} ");
}
Console.WriteLine("\n");

Console.WriteLine("=== 스텝 카운터 (step=3) ===");
var c1 = CounterFactory.CreateStepCounter(3);
for (int i = 0; i < 4; i++)
{
    Console.Write($"{c1()} ");
}
Console.WriteLine("\n");

Console.WriteLine("=== 범위 카운터 (1~3) ===");
var c2 = CounterFactory.CreateBoundedCounter(1,3);
for (int i = 0; i < 7; i++)
{
    Console.Write($"{c2()} ");
}
Console.WriteLine();

Console.WriteLine("=== 리셋 가능 카운터 ===");
Action reset;
CounterFactory.CreateResettableCounter(out reset, out c2);

Console.Write("호출:");
for (int i = 0; i < 3; i++)
{
    Console.Write($"{c2()} ");
}
Console.WriteLine();
reset();
Console.Write("리셋 후:");
for (int i = 0; i < 2; i++)
{
    Console.Write($"{c2()} ");
}
Console.WriteLine();

