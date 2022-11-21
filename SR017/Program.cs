// Двумерные массивы

// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
    
//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
    
//     }   
//     Console.WriteLine();
// }

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);

// _______________________________________________________________________________________________________
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i + j.
// Выведите полученный массив на экран.

// int[,] CreateRandom2dArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
    
//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = i + j;
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
    
//     }   
//     Console.WriteLine();
// }

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());


// int[,] myArray = CreateRandom2dArray(m, n);
// Show2dArray(myArray);

// ____________________________________________________________________________________________________

// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные,
// и замените этиэлементы на их квадраты.

// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
    
//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
    
//     }   
//     Console.WriteLine();
// }

// void ReplacElementSquare(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i = i + 2)
//     {
//         for(int j = 0; j < array.GetLength(1); j = j + 2)
//             array[i,j] *= array[i,j];
                
//     }

// }


// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);
// ReplacElementSquare(myArray);
// Show2dArray(myArray);

 // ______________________________________________________________________________________________________
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали(с индексами (0,0); (1,1); 
// и т. д. )


int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    
    }   
    Console.WriteLine();
}




Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

int SumMainDiagonal(int[,] array)
{   
    int sum = 0;
    int i = array.GetLength(0);             // int sum = 0;
    int j = array.GetLength(1); // Либо        for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++ )
    int min = i;                                    // sum += array[i,i];
    if(i > j)                               // return sum;
        min = j;
    for(i = 0; i < min; i++ )
        sum += array[i,i];
    return sum;

}
Console.WriteLine(SumMainDiagonal(myArray));