// Написать программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.


int FindSum(int number)
{
    int sum = 0;

    for(int current = 1; current <= number; current++) // Величина current будет только внутри цикла!!!
        sum += current; // +=: присваивание после сложения. Присваивает левому операнду сумму левого 
                       // и правого операндов: выражение A += B равнозначно выражению A = A + B
    return sum; 
}

Console.Write("Input a numder: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of number from 1 to {a} is {FindSum(a)} ");
