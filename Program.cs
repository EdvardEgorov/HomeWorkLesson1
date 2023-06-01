Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
for (int i = (0) * n; i <= n; i+=2)
    Console.Write($"{i} ");