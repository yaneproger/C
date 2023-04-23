


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

int a = 1;
int b = 8;
int c = 3;
int d = 2;
int e = 6;

int max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;
Console.WriteLine("max number is  " + max);




