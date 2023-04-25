


//Returns a square of a number


// Console.Write("Enter a number : ");
// int number = int.Parse(Console.ReadLine());
// int sqr = number * number;
// Console.WriteLine("Square of our number is = " + sqr);







// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет


// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// if (b * b == a)
//     Console.WriteLine("Yes");
// else
//     Console.WriteLine("No");


// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница



// Console.Write("Enter a number");
// int number = int.Parse(Console.ReadLine());
// if (number == 1)
// {
//     Console.WriteLine("Monday");
// }
// else if (number == 2)
// {
//     Console.WriteLine("Tuesday");
// }
// else if (number == 3)
// {
//     Console.WriteLine("Wednesday");
// }
// else if (number == 2)
// {
//     Console.WriteLine("Thursday");
// }
// else if (number == 2)
// {
//     Console.WriteLine("Friday");
// }
// else if (number == 2)
// {
//     Console.WriteLine("Saturday");
// }
// else if (number == 2)
// {
//     Console.WriteLine("Sunday");
// }
// else
// {
//     Console.WriteLine("Wrong  number");
// }



// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"


// Console.WriteLine("Enter a number");
// int number = int.Parse(Console.ReadLine());
// int start = -number;

// while (start <= number)
// {
//     Console.Write(start + " ");
//     start++;
// }





// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

// Console.WriteLine("Enter 3 digit number");
// int number = int.Parse(Console.ReadLine());
// if (number >= 100 && number < 1000)
// {
//     Console.Write("The Last digit is : " + number % 10);
// }
// else
// {
//     Console.WriteLine("This is not a 3 digit number");
// }





//Exercises for test checking after seminar at 210423


// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// Console.WriteLine("Enter first number");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter sec. number");
// int b = int.Parse(Console.ReadLine());
// int max = 0;

// if (a > b)
// {
//     max = a;
//     Console.WriteLine("max number is : " + max);
// }
// else
//     Console.WriteLine("max number is : " + b);





// Convert.ToInt32() can also cause this FormatException.

// Check for int.Parse() and Convert.ToInt32() in your code.


//     string input = Console.ReadLine();

//     // ToInt32 can throw FormatException or OverflowException.
//     try
//     {
//         numVal = Convert.ToInt32(input);
//     }
//     catch (FormatException e)
//     {
//         Console.WriteLine("Input string is not a sequence of digits.");
//     }
//     catch (OverflowException e)
//     {
//         Console.WriteLine("The number cannot fit in an Int32.");
//     }

// http://msdn.microsoft.com/en-us/library/bb397679.aspx









// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Enter first number");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter sec. number");
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter 3rd number");
// int c = int.Parse(Console.ReadLine());
// int max = 0;
// if (a > b && a > c)
// {
//     max = a;
//     Console.WriteLine("max number is : " + max);
// }
// else if (b > a && b > c)
// {
//     max = b;
//     Console.WriteLine("max number is : " + max);
// }
// else
//     max = c;
// Console.WriteLine("max number is : " + max);




// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет


// Console.WriteLine("Enter a number");
// int number = int.Parse(Console.ReadLine());

// if (number == 0)
// {
//     Console.WriteLine("The number is a 0 ");
// }

// else if (number % 2 == 0)
// {
//     Console.WriteLine("The number is an even");
// }
// else
//     Console.WriteLine("The number is an odd");


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// Console.WriteLine("Enter a number");
// int number = int.Parse(Console.ReadLine());
// int start = 1;
// while (start <= number)
// {
//     if (start % 2 == 0)
//     {
//         Console.Write(start + "  ");
//     }
//     start++;
// }


// To summarize two random numbers


// int numberA = new Random().Next(1, 10);
// Console.WriteLine(numberA);
// int numberB = new Random().Next(1, 10);
// Console.WriteLine(numberB);
// int result = numberA + numberB;
// Console.WriteLine(result);


// to find max from 5 numbers 1 8 3 2 6

// int a = 1;
// int b = 8;
// int c = 3;
// int d = 2;
// int e = 6;

// int max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// if (d > max) max = d;
// if (e > max) max = e;
// Console.WriteLine("max number is  " + max);


// Write multiple points


// Console.Clear();
// // Console.SetCursorPosition(10, 4);
// // Console.WriteLine("+");
// int xa = 1, ya = 40;
// int xb = 40, yb = 1;
// int xc = 80, yc = 40;
// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("+");
// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("+");
// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("+");
// int x = xa, y = xb;
// int count = 0;
// while (count < 10000)
// {
//     int point = new Random().Next(0, 3); //[0:3] 0 1 2
//     if (point == 0)
//     {
//         x = (x + xa) / 2;
//         y = (y + ya) / 2;
//     }
//     if (point == 1)
//     {
//         x = (x + xb) / 2;
//         y = (y + yb) / 2;
//     }
//     if (point == 2)
//     {
//         x = (x + xc) / 2;
//         y = (y + yc) / 2;
//     }
//     Console.SetCursorPosition(x, y);
//     Console.WriteLine("+");
//     count++;
// }

// to find max from 9 numbers

// array index  =    0     1     2    3    4    5    6    7    8
// int[] numbers = { 1453, 259, 33, 47, 56, 654, 78, 86, 99 };

// int a1 = 1;
// int b1 = 2;
// int c1 = 3;
// int a2 = 4;
// int b2 = 5;
// int c2 = 6;
// int a3 = 7;
// int b3 = 8;
// int c3 = 9;

// int max = 0;

// if (a1 > max) max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;

// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;

// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;


// int Fmax(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int max1 = Fmax(a1, b1, c1);
// int max2 = Fmax(a2, b2, c2);
// int max3 = Fmax(a3, b3, c3);

// int Summax = Fmax(max1, max2, max3);

// int Summax = Fmax
// (
//     Fmax(a1, b1, c1),
//     Fmax(a2, b2, c2),
//     Fmax(a3, b3, c3)
// );


// int Summax = Fmax
// (
//     Fmax(numbers[0], numbers[1], numbers[2]),
//     Fmax(numbers[3], numbers[4], numbers[5]),
//     Fmax(numbers[6], numbers[7], numbers[8])
// );

// Console.WriteLine(Summax);


// to find an index of the entered number

// Console.WriteLine("enter a number 1 to 9 : ");
// int find = int.Parse(Console.ReadLine());
// int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// // Console.WriteLine(array);
// int index = 0;
// // array[index] = 0;
// int size = array.Length;
// // int find = 5;

// while (index < size)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine("position(index) of the find is: " + index);

//     }
//     index++;
// }
// Console.WriteLine("the find is :" + find);



