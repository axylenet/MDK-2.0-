using System;

class Program {
static void Main(string[] args) {
int x, y, e;
Console.Write("Введите x и y: ");
x = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());

e = (int)((Math.Pow(y, 2) + Math.Cos(6))/(Math.Pow(Math.Tan(y), 2) + Math.Sqrt(Math.Pow(x, 2) + 5)) + (Math.Pow(y, 4) + Math.Cos(24))/(Math.Pow(Math.Tan(y), 3) + Math.Sqrt(Math.Pow(x, 4) + 10)) + (Math.Pow(y, 6) + Math.Cos(120))/(Math.Pow(Math.Tan(y), 4) + Math.Sqrt(Math.Pow(x, 6) + 15)));

Console.WriteLine(e);
}
}