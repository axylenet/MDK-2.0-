using System;

namespace QuickSort
{
class Program
{
const int N = 10;
const int MIN_VALUE = -50;
const int MAX_VALUE = 50;

static void Main(string[] args)
{
int[] arr = new int[N];
FillArrayRandomly(arr);
Console.WriteLine("Initial array:");
PrintArray(arr);
QuickSort(arr, 0, N - 1);
Console.WriteLine("Sorted array:");
PrintArray(arr);
}

static void FillArrayRandomly(int[] a)
{
Random rnd = new Random();
for (int i = 0; i < N; i++)
a[i] = rnd.Next(MIN_VALUE, MAX_VALUE + 1);
}

static void QuickSort(int[] a, int l, int r)
{
int i = l;
int j = r;
int x = a[(l + r) / 2];
do
{
while (a[i] < x)
i++;
while (x < a[j])
j--;
if (i <= j)
{
int y = a[i];
a[i] = a[j];
a[j] = y;
i++;
j--;
}
} while (i <= j);
if (l < j)
QuickSort(a, l, j);
if (i < r)
QuickSort(a, i, r);
}

static void PrintArray(int[] a)
{
for (int i = 0; i < N; i++)
Console.Write(a[i] + " ");
Console.WriteLine();
}
}
}
