﻿


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



