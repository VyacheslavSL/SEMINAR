// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и еденицами в случайном 
// порядке.

int[] CreateRandomArray(int size, int minValue, int maxValue) // Генерация массива
{
    int[] array = new int[size]; 

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;    
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " "); // Вывод  массива на экран
    
    Console.WriteLine();
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
