// Напишите программу, которая принимает на вход три целых числа (a, m, n) и проверяет, кратно ли число a одновременно m и n.
bool Krat(int a1, int m1, int n1)
{
    if(a1 % m1 == 0 && a1 % n1 == 0)
        return true;
    else
        return false;
}

Console.WriteLine("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input a second number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input a third number: ");
int n = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(Krat(a, m, n));