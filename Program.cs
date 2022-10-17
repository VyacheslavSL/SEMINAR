//int a = 31; // Целочисленная переменная
//double b = -12.45; // Вещественные чила
//string c = "word"; // Строка, переменная обязательно в двойных кавычках
//char d = '@'; // Еденничные символы
//bool e = true;// Логическая переменная

//Console.WriteLine("My number is " + a + " and it is good!");
//Console.WriteLine($"My number is {a} and it is good!");

// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

//________________________________________________________________________________________________________________________

// ДЗ1
// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго. 

/*Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quad2 = n2 * n2;

if(quad2 == n1)
{
Console.WriteLine($"Number {n1} is a square of {n2}");
}
else
{
Console.WriteLine($"Number {n1} is not a square of {n2}"); 
}
*/

//________________________________________________________________________________________________________________________

//Задача 2. Напищите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

/*Console.Write("Input a positive integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

while(current <= number)
{
    Console.Write(current + " ");
    current++;    // То же самое что и current = current + 1
}
*/

//________________________________________________________________________________________________________________________

// Задача 3. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

/*Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number % 10;
Console.WriteLine($"Last digit of {number} is {result}");
*/







