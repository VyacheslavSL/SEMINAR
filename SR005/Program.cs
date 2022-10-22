// Напишите программу, которая будет принимать на вход два числа выводить, является ли второе чило кратным первому. (Делится без остатка)
bool Krat(int n1, int n2)
{
    if(n2 % n1 == 0 && n2 > n1)
        return true;
    else
        return false;
}

Console.WriteLine("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Krat(num1, num2));