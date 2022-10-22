// Напишите программу, которая проинимает на вход два числа и проверяет, является ли одно число квадратом другого.
bool Quad(int n1, int n2)
{
    int quad1 = n2 * n2;
    int quad2 = n1 * n1;

    if(quad1 == n1 || quad2 == n2)
        return true;
    else
        return false;

}

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = Quad(num1, num2);
Console.WriteLine(result);