// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива


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

// void ChangeRows(int[,] array, int row1, int row2)
// {
//     if(row1 >= 0 && row1 < array.GetLength(0) && 
//     row2 >=0 && row2 < array.GetLength(0) && row1 != row2)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1, j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = temp;
//         }
//     }
//     else Console.WriteLine("Impossible to change!");

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

// Console.Write("Input a number of the first row to change: ");
// int r1 = Convert.ToInt32(Console.ReadLine()) - 1; // для пользователя, чтобы не начинать нумеровать с нуля
// Console.Write("Input a number of the second row to change: ");
// int r2 = Convert.ToInt32(Console.ReadLine()) - 1;

// ChangeRows(myArray, r1, r2);
// Show2dArray(myArray);

//_____________________________________________________________________________________________________

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, 
// если это невозможно, прогамма должна вывести сообщение для пользователя.

// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

//  void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();

//     }   
//     Console.WriteLine();
// }

// void MatrixTransposition(int[,] array)
// {
// if(array.GetLength(0) == array.GetLength(1))
//     {
//         for(int i = 1; i < array.GetLength(0); i++)
//         {
//            for(int j = 0; j < i; j++) 
//             {
//                 int temp = array[i,j];
//                 array[i,j] = array[j,i];
//                 array[j,i] = temp;

//             }    

//         }


//     }   
//     else Console.WriteLine("Unable to perform matrix transposition");
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
// MatrixTransposition(myArray);
// Show2dArray(myArray);










//_____________________________________________________________________________________________________

// Из двумерного массива целых чисел удалить строку и столбец на пересечении которых расположен 
// наименьший элемент.


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

int[] GetMinIndexes(int[,] array)
{
    int[] minindexes = { 0, 0 };
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[minindexes[0], minindexes[1]])
            {
                minindexes[0] = i;
                minindexes[1] = j;
            }
        }
    }
    return minindexes;
}   

int[,] CompressArray(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int[] arrminindexes = GetMinIndexes(array); 

    for(int i = 0, k = 0; i < array.GetLength(0); i++, k++)
    {
        if(i != arrminindexes[0])
        {
            for(int j = 0, l = 0; j < array.GetLength(1); j++, l++)
                if(j != arrminindexes[1])
                    newArray[k,l] = array[i,j];
                else l--;
            
        }
        else k--;
    }
    return newArray;
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

int[] arraymin = GetMinIndexes(myArray);
Console.WriteLine($"Minimal value :{myArray[arraymin[0], arraymin[1]]}, indexes:({arraymin[0]}, {arraymin[1]})");

int[,] compresarray = CompressArray(myArray);
Show2dArray(compresarray);