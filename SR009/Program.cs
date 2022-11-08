// Задача 1. Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

int DigitCount(int number)
{
    int count = 0;
    int num1 = number; 
    while (num1 > 0)
    {
        num1 = num1 / 10;
        count++;
    }
    return count;
}

Console.WriteLine("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"cont digit is {DigitCount(a)}");
