using System;

namespace ConsoleApp
{
class Program
{
static void Main(string[] args)
{
float m, n, a, b, c;
float z, alf, bat;

Console.WriteLine("Введите сходные данные m, n:");
m = float.Parse(Console.ReadLine());
n = float.Parse(Console.ReadLine());

if (m > n)
alf = m;
else if (m < n)
alf = n;
else if (m == n)
alf = n * (float)Math.Cos(n);

if (m < 5)
bat = a;
else if (m == 5)
bat = b;
else if (m > 5)
bat = c;

z = (float)Math.Pow(alf * alf + bat + Math.Exp(alf) - Math.Cos(bat), 1.0 / 3.0);

Console.WriteLine(z);
}
}
}