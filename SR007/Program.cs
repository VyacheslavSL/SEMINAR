// Задача 1.  Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек
// в этой четверти (x и y).

// void ShowQuart(int quartNum)
// {
//     if(quartNum >= 1 && quartNum <= 4)
//     {
//         if(quartNum == 1) Console.WriteLine("x > 0 and y > 0");
//         else if(quartNum == 2) Console.WriteLine("x < 0 and y > 0");
//         else if(quartNum == 3) Console.WriteLine("x < 0 and y < 0");
//         else Console.WriteLine("x > 0 and y < 0");
//     }
//     else
//         Console.WriteLine("Wrong number!");

// }

// Console.Write("Input a number of quart: ");
// int num = Convert.ToInt32(Console.ReadLine());

// ShowQuart(num);



// Задача 2. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X не равно 0,
// и Y не равно нулю и выдаёт номер четверти плоскости, в которой находится.

// int QuartNumber(double x, double y)
// {
//     if( x > 0 && y > 0) return 1;
//     if(x < 0 && y > 0) return 2;
//     if(x < 0 && y < 0) return 3;
//     if(x > 0 && y < 0) return 4;
//     return 0; 
// }
// Console.WriteLine("Input coordinate X:");
// double abc = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input coordinate Y:");
// double ord = Convert.ToInt32(Console.ReadLine());

// int result = QuartNumber(abc, ord);
// Console.WriteLine($" quadrant: {result}");




// Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
// между ними в 2D пространстве.

// double Point(double x1, double y1, double x2, double y2)
// {
//     double delx = x2 - x1;
//     double dely = y2 - y1;
//     double delxexp = Math.Pow(delx, 2);
//     double delyexp = Math.Pow(dely, 2);
//     double lengthsqrt = delxexp + delyexp;
//     double length = Math.Sqrt(lengthsqrt);
//     return length;
// }
// Console.WriteLine("Input Xa: ");
// double abc1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input Ya: ");
// double ord1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input Xb: ");
// double abc2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input Yb: ");
// double ord2 = Convert.ToDouble(Console.ReadLine());

// double result = Point(abc1, ord1, abc2, ord2);
// Console.WriteLine(result);



// Напишите программу, которая принимает на вход чило (N) и выдаёт таблицу квадратов чисел от 1 до N.

// void Table(int number)
// {
    
//     for(int i = 1; i <= number; i++)
//         { double result = Math.Pow(i,2);
//           Console.Write(result + " ");
//         }
        
    
// }

// Console.WriteLine("Input number");
// int n = Convert.ToInt32(Console.ReadLine());

// Table(n);
