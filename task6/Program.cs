Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int remDiv = n % 2;
if (remDiv == 0)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");


  

