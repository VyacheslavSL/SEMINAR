// Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т. д.)

// int[] CreateRandomArray(int size, int minValue, int maxValue) // Генерация массива
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " "); // Вывод  массива на экран

//     Console.WriteLine();
// }

// void ReverseArray(int[] array)
// {
//     for (int i = 0, j = array.Length - 1; i < j; i++, j--)
//     {
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
// }

// Console.Write("Input a number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(n, min, max);
// ShowArray(myArray);
// ReverseArray(myArray);
// ShowArray(myArray);
//________________________________________________________________________________________________________________________


// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

// void ShowArray(int[] array)

// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " "); // Вывод  массива на экран

//     Console.WriteLine();
// }


// int[] Fibanacci(int size, int a, int b)
// {
//     int [] array = new int[size];
//     array[0] = a;
//     array[1] = b;
//     for(int i = 2; i < size; i++)
//         array[i] = array[i - 1] + array[i - 2];
//     return array;
// }

// Console.Write("Input a number of elements fibonacci N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input b: ");
// int b = Convert.ToInt32(Console.ReadLine());


// ShowArray(Fibanacci(n, a, b));

//________________________________________________________________________________________________________

// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// int[] CreateRandomArray(int size, int minValue, int maxValue) // Генерация массива
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " "); // Вывод  массива на экран

//     Console.WriteLine();
// }


// int[] Copy(int[] array)
// {
//     int[] copyArray = new int[array.Length];
//     for(int i = 0; i < array.Length; i++)
//          copyArray[i] = array[i];
//     return copyArray;
// }


// Console.Write("Input a number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(n, min, max);
// ShowArray(myArray);
// ShowArray(Copy(myArray));

//_______________________________________________________________________________________________________

// Напишите программу, которая принимает на вход три числа и проверяет, может ли уществовать треугольник
// со сторонами такой длины.

bool Ttriangle(int a, int b, int c)
{
    return a + b > c && a + c > b && b + c > a;
}

Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input c: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Ttriangle(a, b, c));
