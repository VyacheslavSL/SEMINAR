// Написать программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру чила.

int MaxDigit(int number)
{
    int ed = number % 10;
    int dec = number / 10;
    int result = 0;
    
    if(ed > dec) result = ed;
    if(ed < dec) result = dec;
    return result;
}

int randNum = new Random().Next(10, 100);
int newNum = MaxDigit(randNum);

Console.WriteLine($"Max digit of {randNum} is a {newNum}");
