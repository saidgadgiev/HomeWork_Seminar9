/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в 
промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SummNum(int m, int n, int result = 0)
{
    if (m <= n) return SummNum(m+1,n, result=result+m);
    return result;
}

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int res = SummNum(m,n);

Console.WriteLine($"M = {m}; N = {n} -> {res}");