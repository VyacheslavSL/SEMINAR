// Напишите программу, которая выводит случайное трёхзначное чило и удаляет вторую цифру этого числа.
int CutDigit(int number)
{
    int ed = number % 10;
    int sot = number / 100;
    
    int result = sot * 10 + ed;
    return result;
}

int randNum = new Random().Next(100, 1000); // диапазон от 100 до 999.
int newNum = CutDigit(randNum);

Console.WriteLine($"New version of {randNum} is {newNum}");