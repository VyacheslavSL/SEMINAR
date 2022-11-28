// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 
// до N.

// void ShowNums(int n)
// {
//     if(n > 1) ShowNums(n - 1);
//     Console.Write(n + " ");

// }

// ShowNums(5);
// ================================================================================================
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// int SumOfDigits(int n)
// {
//     if(n !=0) return SumOfDigits(n / 10) + n % 10;
//     return 0;
// }
// Console.WriteLine(SumOfDigits(5243));
// =================================================================================================

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от M до N. 

// void ShowNumbers(int m, int n)
// {
//     if(m > n)
//     {
//         ShowNumbers(m, n + 1);
//         Console.Write($"{n} ");
//     }
//     else if(n > m)
//     {
//         Console.Write($"{m} ");
//         ShowNumbers(m + 1, n);
//     } 
//     else
//         Console.Write($"{m} ");
    

// }

// ShowNumbers(5,10);

// ====================================================================================================
// Напишите программу, которая на вход принимает два числа A и B, и возводит число A в целую степень B.

double CustomPower(double number, double power)
{
    if(power > 0)
        return CustomPower(number, power - 1) * number;
    else if(power < 0)
        return CustomPower(number, power + 1) / number;
    else
        return 1;
}
Console.WriteLine(CustomPower(2,3));