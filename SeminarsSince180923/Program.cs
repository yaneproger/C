﻿




// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49



// Console.WriteLine("Enter a number");

// int number = int.Parse(Console.ReadLine());

// Console.WriteLine("result is " + number * number);










// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3, b = 9 -> нет

// Console.WriteLine("Enter 1st number");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter 2st number");
// int b = int.Parse(Console.ReadLine());

// if (a == b * b)
// {

//     Console.WriteLine("it's true");
// }
// else
// {
//     Console.WriteLine("false");
// }



// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница

// Console.WriteLine("Enter week number");
// int number = int.Parse(Console.ReadLine());
// if (number == 1)
// {
//     Console.WriteLine("its monday");
// }
// else if (number == 2)
// {
//     Console.WriteLine("its tuesday");
// }
// else if (number == 3)
// {
//     Console.WriteLine("its wednesday");
// }
// else if (number == 4)
// {
//     Console.WriteLine("its thursday");
// }
// else if (number == 5)
// {
//     Console.WriteLine("its friday");
// }
// else if (number == 6)
// {
//     Console.WriteLine("its saturday");
// }
// else if (number == 7)
// {
//     Console.WriteLine("its sunday");
// }
// else
// {
//     Console.WriteLine("You are entered not a week number");
// }


// 5. Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("enter a  number");
// int number = int.Parse(Console.ReadLine());

// int negative = -number;

// while (negative <= number)
// {
//     Console.WriteLine(" number " + negative);
//     negative++;
// }


// 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

// Console.WriteLine("enter a  number");
// int number = int.Parse(Console.ReadLine());

// if (number >= 100 && number < 1000)
// {
//     Console.WriteLine("result is  " + number % 10);
// }
// else
// {
//     Console.WriteLine("you entered wrong number");
// }




// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// int InputAndCheck(string message)
// {
//     bool check = false;
//     int output = 0;
//     while (check != true)
//     {
//         Console.WriteLine(message);
//         string input = Console.ReadLine();
//         check = int.TryParse(input, out output);
//         if (check == false)
//         {
//             Console.WriteLine("wrong input");
//         }
//     }
//     return output;
// }

// void CheckNumber(int number1, int number2)
// {
//     if (number1 > number2)
//     {
//         Console.WriteLine("the bigger number is  " + number1);
//     }
//     else if (number1 < number2)
//     {
//         Console.WriteLine("the bigger number is  " + number2);
//     }
//     else if (number1 == number2)
//     {
//         Console.WriteLine("the numbers is  equals  " + number1 + " and " + number2);
//     }
//     else
//     {
//         Console.WriteLine("wrong input ");
//     }
// }
// Console.Clear();
// int number1 = InputAndCheck("Enter 1st number");
// int number2 = InputAndCheck("Enter 2nd number");
// CheckNumber(number1, number2);


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// int InputAndCheck(string message)
// {
//     bool check = false;
//     int output = 0;
//     while (check != true)
//     {
//         Console.WriteLine(message);
//         string input = Console.ReadLine();
//         check = int.TryParse(input, out output);
//         if (check == false)
//         {
//             Console.WriteLine("wrong input");
//         }
//     }
//     return output;
// }

// void FindMax(int number1, int number2, int number3)
// {
//     int max = number1;
//     if (number2 > max)
//     {
//         max = number2;
//         Console.WriteLine($"max number is {max}");
//     }
//     else if (number3 > max)
//     {
//         max = number3;
//         Console.WriteLine($"max number is {max}");
//     }
//     else
//     {
//         Console.WriteLine("wrong input");
//     }
// }

// void CheckNumber(int number1, int number2, int number3)
// {
//     if (number1 > number2 && number1 > number3)
//     {
//         Console.WriteLine("the bigger number is  " + number1);
//     }
//     else if (number2 > number1 && number2 > number3)
//     {
//         Console.WriteLine("the bigger number is  " + number3);
//     }
//     else if (number3 > number1 && number3 > number2)
//     {
//         Console.WriteLine("the bigger number is  " + number3);
//     }
//     else if (number3 == number1 && number3 == number2 && number1 == number2)
//     {
//         Console.WriteLine(" " + number1, number2, number3);
//         Console.WriteLine("the numbers equals ");
//     }
//     else
//     {
//         Console.WriteLine("wrong input ");
//     }
// }
// Console.Clear();

// int number1 = InputAndCheck("Enter 1st number");
// int number2 = InputAndCheck("Enter 2nd number");
// int number3 = InputAndCheck("Enter 3rd number");
// // CheckNumber(number1, number2, number3);
// FindMax(number1, number2, number3);



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("enter a number ");
// string input = Console.ReadLine();
// int number = Math.Abs(Convert.ToInt32(input));

// if (number % 2 == 0)
// {
//     Console.WriteLine("the " + number + " is even ");
// }
// else
// {
//     Console.WriteLine("the " + number + "is odd ");
// }


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// int InputAndCheck(string message)
// {
//     bool check = false;
//     int output = 0;
//     while (check != true)
//     {
//         Console.WriteLine(message);
//         string input = Console.ReadLine();
//         check = int.TryParse(input, out output);
//         if (check == false)
//         {
//             Console.WriteLine("wrong input");
//         }
//     }
//     return output;
// }

// void ShowNumber(int start, int number)
// {
//     while (start <= number)
//     {
//         if (start % 2 == 0)
//         {
//             Console.WriteLine("the next even number is " + start);
//         }
//         start++;
//     }
// }
// Console.Clear();
// int number1 = InputAndCheck("enter 1st number");
// int number2 = InputAndCheck("enter 2nd number");
// ShowNumber(number1, number2);








// Console.WriteLine("enter a number");
// int input = int.Parse(Console.ReadLine());

// int number1 = input / 100;

// int number2 = input % 10;

// int result = number1 * 10 + number2;

// Console.WriteLine(result);




// Console.WriteLine("enter 1 number");
// int input1 = int.Parse(Console.ReadLine());


// Console.WriteLine("enter 2 number");
// int input2 = int.Parse(Console.ReadLine());



// if (input2 % input1 == 0)
// {

//     Console.WriteLine(" number2 is multiple of number1");
// }
// else
// {
//     Console.WriteLine(" division result is" + input2 % input1);

// }








// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8


// int number = Random.Shared.Next(10, 100);
// Console.WriteLine(" number" + number);

// int lastdigit = number % 10;
// Console.WriteLine(" lastdigit " + lastdigit);

// int firstdigit = number / 10;
// Console.WriteLine($ " firstdigit  { firstdigit}");

// if (firstdigit > lastdigit)
// {
//     Console.WriteLine($" firstdigit is bigger { firstdigit } " );
// }

// else if (firstdigit < lastdigit)
// {
//     Console.WriteLine($" lastdigit  is bigger {lastdigit} ");
// }
// else
// {
//     Console.WriteLine($" the digits is equals  {firstdigit + lastdigit}");
// }



// 11. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int input(string message)
// {
//     Console.WriteLine(message);
//     int number = Random.Shared.Next(100, 1000);
//     return number;
// }
// void SecondDigit(int arg1)
// {
//     if (arg1 >= 100 && arg1 < 1000)
//     {
//         int number = (arg1 / 100) * 10 + arg1 % 10;
//         Console.WriteLine($" result is  {number} ");
//     }
//     Console.WriteLine($" no 3 digit number entered  {arg1} ");
// }
// int number = input("Enter a 3dgit number");
// Console.WriteLine($"Random number is {number}");
// SecondDigit(number);



// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


// Console.WriteLine("enter 1st number");
// int number1 = int.Parse(Console.ReadLine());


// Console.WriteLine("enter 2nd number");
// int number2 = int.Parse(Console.ReadLine());


// if (number1 % number2 == 0)
// {
//     Console.WriteLine("number1 is multiple of number2");
// }
// else
// {
//     Console.WriteLine($"number is not  multiple {number1 % number2}");
// }


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.WriteLine("enter 1st number");
// int number1 = int.Parse(Console.ReadLine());

// if (number1 % 7 == 0 && number1 % 23 == 0)
// {
//     Console.WriteLine("number1 is multiple of 7 and 23");
// }
// else
// {
//     Console.WriteLine($"number is not  multiple {number1}");
// }



// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Console.WriteLine("enter 1st number");
// int number1 = Math.Abs(int.Parse(Console.ReadLine()));

// Console.WriteLine("enter 2nd number");
// int number2 = Math.Abs(int.Parse(Console.ReadLine()));

// if (number1 == number2 * number2 || number2 == number1 * number1)
// {
//     Console.WriteLine("yes");
// }
// else if (number2 == number1 * number1)
// {
//     Console.WriteLine("yes");
// }
// else
// {
//     Console.WriteLine("no");
// }


// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int InputAndCheck(string message)
// {
//     bool check = false;
//     int output = 0;
//     while (check != true)
//     {
//         Console.WriteLine(message);
//         string input = Console.ReadLine();
//         check = int.TryParse(input, out output);
//         if (check == false)
//         {
//             Console.WriteLine("wrong input");
//         }
//     }
//     return output;
// }

// void SecondDigitFind(int arg1)
// {
//     if (arg1 < 100 || arg1 > 1000)
//     {
//         Console.WriteLine($"incorrect number {arg1}  ");
//     }
//     else
//     {
//         while (arg1 > 100)
//         {
//             arg1 = arg1 / 10;
//         }
//         Console.WriteLine($"result is  {arg1 % 10}");
//     }
// }
// Console.Clear();
// int number = InputAndCheck("enter a number");
// SecondDigitFind(number);



// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// long InputAndCheck(string message)
// {
//     bool check = false;
//     long output = 0;
//     while (check != true)
//     {
//         Console.WriteLine(message);
//         string input = Console.ReadLine();
//         check = long.TryParse(input, out output);
//         if (check == false)
//         {
//             Console.WriteLine("wrong input");
//         }
//     }
//     return output;
// }
// void ThirddDigitFind(long arg1)
// {
//     if (arg1 < 100)
//     {
//         Console.WriteLine($"the number {arg1} has two digits only  ");
//     }
//     else
//     {
//         while (arg1 >= 1000)
//         {
//             arg1 = arg1 / 10;
//         }
//         Console.WriteLine($"result is  {arg1 % 10}");
//     }
// }
// Console.Clear();
// long number = InputAndCheck("enter a number");
// ThirddDigitFind(number);



// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

// int InputAndCheck(string message)
// {
//     bool check = false;
//     int output = 0;
//     while (check != true)
//     {
//         Console.WriteLine(message);
//         string input = Console.ReadLine();
//         check = int.TryParse(input, out output);
//         if (check == false)
//         {
//             Console.WriteLine("wrong input");
//         }
//     }
//     return output;
// }

// void DayCheck(int arg1)
// {
//     if (arg1 >= 1 && arg1 <= 7)
//     {
//         if (arg1 == 6 || arg1 == 7)
//         {
//             Console.WriteLine("its weekend, partytime!");
//         }
//         else if (arg1 >= 1 && arg1 <= 5)
//         {

//             for (arg1 = 1; arg1 <= 5; arg1++)
//             {
//                 Console.WriteLine("its weekday, go to work");
//                 break;
//             }
//         }
//     }
//     else
//     {
//         Console.WriteLine("wrong input");
//     }
// }
// Console.Clear();
// int number = InputAndCheck("enter a number");
// DayCheck(number);

//
//
//



//This method checks for number and digits quantity - 5 digits

// int InputAndCheck(string message)
// {
//     int output;
//     Console.WriteLine(message);
//     while ((!int.TryParse(Console.ReadLine(), out output)) || (output >= 100000))
//     {
//         Console.WriteLine("wrong input");
//     }
//     return output;
// }
// int number = InputAndCheck("Введите число");








// 250923 Seminar 3

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// AB = √(xb - xa)2 + (yb - ya)2


// int GetInt(string message)
// {
//     int result;
//     Console.WriteLine(message);
//     while (!int.TryParse(Console.ReadLine(), out result))
//     {
//         Console.WriteLine("Ошибка ввода. Введите число");
//     }
//     return result;
// }



// int InputAndCheck(string message)
// {
//     int output;
//     Console.WriteLine(message);
//     while ((!int.TryParse(Console.ReadLine(), out output)) || (output >= 100000))
//     {
//         Console.WriteLine("wrong input");
//     }
//     return output;
// }
// int number = InputAndCheck("Введите число");






// int InputAndCheck(string message)
// {
//     bool check = false;
//     int output = 0;
//     while (check != true)
//     {
//         Console.WriteLine(message);
//         string input = Console.ReadLine();
//         check = int.TryParse(input, out output);
//         if (check == false)
//         {
//             Console.WriteLine("wrong input");
//         }
//     }
//     return output;
// }


// void Distance(int x1, int y1, int x2, int y2)
// {
//     double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
//     Console.WriteLine(Math.Round(result, 3));
// }
// Console.Clear();
// int x1 = InputAndCheck("enter x1");
// int y1 = InputAndCheck("enter y1");
// int x2 = InputAndCheck("enter x2");
// int y2 = InputAndCheck("enter y2");
// Distance(x1, y1, x2, y2);



// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


// int InputAndCheck(string message)
// {
//     bool check = false;
//     int output = 0;
//     while (check != true)
//     {
//         Console.WriteLine(message);
//         string input = Console.ReadLine();
//         check = int.TryParse(input, out output);
//         if (check == false)
//         {
//             Console.WriteLine("wrong input");
//         }
//     }
//     return output;
// }

// void SquareTable(int N)
// {
//     for (int start = 1; start <= N; start++)
//     {
//         Console.WriteLine(Math.Pow(start, 3));
//     }
// }

// Console.Clear();
// int number = InputAndCheck("enter a number");
// SquareTable(number);



// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом

// string InputAndCheck(string message)
// {
//     Console.WriteLine(message);
//     string number = Console.ReadLine();
//     while ((!int.TryParse(number, out int output)) || (output > 100000))
//     {
//         Console.WriteLine("InputAndCheck method check false - wrong input");
//         break;
//     }
//     return number;
// }

// bool CheckPalindrom(string arg1)
// {
//     bool palicheck = false;

//     if (arg1.Length == 5)
//     {
//         for (int index = 0; index < arg1.Length / 2; index++)
//         {
//             if (arg1[index] == arg1[arg1.Length - 1 - index])
//             {
//                 Console.WriteLine($"the {arg1} is palindrom ");
//                 palicheck = true;
//             }
//             else
//             {
//                 Console.WriteLine($"the {arg1} is No palindrom ");
//                 palicheck = false;
//             }
//         }
//     }
//     else
//     {
//         Console.WriteLine($"CheckPalindrom method check false - enter 5 digit number ");
//     }
//     return palicheck;
// }

// void Result(bool arg1)
// {
//     if (arg1 == true)
//     {
//         Console.WriteLine($"entered symbols return - {arg1}-  is palindrom ");
//     }
//     else
//     {
//         Console.WriteLine($"entered symbols return - {arg1} - is No palindrom ");
//     }

// }

// Console.Clear();
// string number = InputAndCheck("Введите число");
// bool check = CheckPalindrom(number);
// Result(check);

//
//
//
// from 100




// bool CheckPalindrom(string arg1)
// {
//     bool palicheck = false;
//     bool digicheck;

//     if (!int.TryParse(arg1, out int output))
//     {
//         digicheck = false;
//     }
//     else digicheck = true;

//     if ((arg1.Length == 5) && (digicheck == true))
//     {
//         for (int index = 0; index < arg1.Length / 2; index++)
//         {
//             if (arg1[index] == arg1[arg1.Length - 1 - index])
//             {
//                 palicheck = true;
//             }
//             else
//             {
//                 palicheck = false;
//             }
//         }
//     }
//     else
//     {
//         Console.WriteLine($"Число не пятизначное");
//     }
//     return palicheck;
// }

// Console.Clear();
// Console.WriteLine("Введите число");
// string number = Console.ReadLine();
// bool check = CheckPalindrom(number);
// Console.WriteLine(check);



//280923-exercise 15-Check using Autocheck in gb.ru


// bool CheckPalindrom(int number)
// {
//     string arg1 = number.ToString();
//     bool palicheck = false;
//     bool digicheck;

//     if (!int.TryParse(arg1, out int output))
//     {
//         digicheck = false;
//     }
//     else digicheck = true;

//     if ((arg1.Length == 5) && (digicheck == true))
//     {
//         for (int index = 0; index < arg1.Length / 2; index++)
//         {
//             if (arg1[index] == arg1[arg1.Length - 1 - index])
//             {
//                 palicheck = true;
//             }
//             else
//             {
//                 palicheck = false;
//             }
//         }
//     }
//     else
//     {
//         Console.WriteLine($"Число не пятизначное");
//     }
//     return palicheck;
// }

// Console.Clear();
// Console.WriteLine("Введите число");
// int number = int.Parse(Console.ReadLine());
// bool check = CheckPalindrom(number);
// Console.WriteLine(check);





// Внутри класса Answer напишите метод DistanceBetweenPoints, 
// который принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел,
//  и возвращает расстояние между ними в 3D пространстве.


// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Формула вычисления расстояния между 
// двумя точками A(xa, ya, za) и B(xb, yb, zb) в пространстве:
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2




// using System;

// public class Answer
// {

//     private static int Square(int number)
//     {
//         return number * number;
//     }

//     private static int SumSquare(int[] pointA, int[] pointB)
//     {
//         int sum = 0;
//         for (int i = 0; i < pointA.Length; i++)
//         {
//             sum += Square(pointA[i] - pointB[i]);
//         }
//         return sum;
//     }

//     private static double Length(int[] pointA, int[] pointB)
//     {
//         double result = Math.Sqrt(SumSquare(pointA, pointB));
//         return result;
//     }

//     // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args)
//     {
//         int x1, x2, x3, y1, y2, y3;

//         if (args.Length >= 6)
//         {
//             x1 = int.Parse(args[0]);
//             x2 = int.Parse(args[1]);
//             x3 = int.Parse(args[2]);
//             y1 = int.Parse(args[3]);
//             y2 = int.Parse(args[4]);
//             y3 = int.Parse(args[5]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             x1 = 3;
//             x2 = 6;
//             x3 = 8;
//             y1 = 2;
//             y2 = 1;
//             y3 = -7;
//         }

//         // Не удаляйте строки ниже
//         double result = Length(new int[] { x1, x2, x3 }, new int[] { y1, y2, y3 });
//         Console.WriteLine($"{result:F2}");
//     }
// }















// using System;

// public class Answer
// {
//     private static double Length(int[] pointA, int[] pointB)
//     {
//         // Введите свое решение ниже
//         double distance = Math.Round(Math.Sqrt((Math.Pow(pointB[0] - pointA[0], 2)) + (Math.Pow(pointB[1] - pointA[1], 2)) + (Math.Pow(pointB[2] - pointA[2], 2))), 2);
//         return distance;

//     }

// Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args)
//     {
//         int x1, x2, x3, y1, y2, y3;

//         if (args.Length >= 6)
//         {
//             x1 = int.Parse(args[0]);
//             x2 = int.Parse(args[1]);
//             x3 = int.Parse(args[2]);
//             y1 = int.Parse(args[3]);
//             y2 = int.Parse(args[4]);
//             y3 = int.Parse(args[5]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             x1 = 3;
//             x2 = 6;
//             x3 = 8;
//             y1 = 2;
//             y2 = 1;
//             y3 = -7;
//         }

//         // Не удаляйте строки ниже
//         double result = Length(new int[] { x1, x2, x3 }, new int[] { y1, y2, y3 });
//         Console.WriteLine($"{result:F2}");
//     }
// }























// int Input(string message)
// {
//     Console.WriteLine(message);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }


// private static double Length(int[] pointA, int[] pointB)

// {
//     double distance = Math.Round(Math.Sqrt((Math.Pow(pointB[0] - pointA[0], 2)) + (Math.Pow(pointB[1] - pointA[1], 2)) + (Math.Pow(pointB[2] - pointA[2], 2))), 2);
//     return distance;

// }


// x1 = int.Parse(args[0]);
// x2 = int.Parse(args[1]);
// x3 = int.Parse(args[2]);
// y1 = int.Parse(args[3]);
// y2 = int.Parse(args[4]);
// y3 = int.Parse(args[5]);

















// double FindDistance(int x1, int x2, int x3, int y1, int y2, int y3)
// {
//     double distance = Math.Round(Math.Sqrt((Math.Pow(y1 - x1, 2)) + (Math.Pow(y2 - x2, 2)) + (Math.Pow(y3 - x3, 2))), 2);
//     return distance;
// }

// int x1 = Input("enter x1");
// int x2 = Input("enter x2");
// int x3 = Input("enter x3");
// int y1 = Input("enter y1");
// int y2 = Input("enter y2");
// int y3 = Input("enter y3");

// Console.WriteLine(FindDistance(x1, x2, x3, y1, y2, y3));













// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// int Input(string message)
// {
//     Console.WriteLine(message);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// int DigiQuantity(int number)
// {
//     int digicount = 0;
//     // while (number > 0)
//     for (digicount = 0; number > 0; digicount++)
//     {
//         number = number / 10;
//         // digicount++;
//     }
//     return digicount;
// }

// int number = Input("enter a number");
// Console.WriteLine(DigiQuantity(number));






// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// int Input(string message)
// {
//     Console.WriteLine(message);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }

// int NumQuantity(int arg1)
// {
//     int sum = 1;
//     for (int start = 2; start <= arg1; start++)
//     {
//         sum = sum * start;
//     }
//     return sum;
// }

// int number = Input("enter a number");
// Console.WriteLine(NumQuantity(number));


// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] FillArray(int size)
// {
//     int[] array = new int[size];

//     for (int index = 0; index < array.Length; index++)
//     {
//         array[index] = new Random().Next(0, 111);
//         Console.Write($" {array[index]}, ");
//     }
//     return array;
// }

// int[] SummArray(int[] arr1, int[] arr2)
// {
//     int[] array = new int[arr1.Length];

//     for (int index = 0; index < arr1.Length; index++)
//     {
//         array[index] = arr1[index] + arr2[index];
//         Console.Write($" {array[index]}, ");
//     }
//     return array;
// }

// Console.WriteLine("enter array1 size");
// int size = int.Parse(Console.ReadLine());

// int[] array1 = FillArray(size);
// Console.WriteLine();
// int[] array2 = FillArray(size);
// Console.WriteLine();
// int[] array3 = SummArray(array1, array2);
// Console.WriteLine();












// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// int Input(string message)
// {
//     Console.WriteLine(message);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }

// int Multiple(int num1, int num2)
// {
//     int sum = 1;
//     for (int count = 0; count < num2; count++)
//     {
//         sum = sum * num1;
//     }
//     return sum;
// }

// int number1 = Input("enter 1 number");
// int number2 = Input("enter 2 number");
// Console.WriteLine(Multiple(number1, number2));




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Input(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int Multiple(int num)
{
    int sum = 0;

    for (int count = 0; num > 0; count++)
    {
        int lastdigit = num % 10;
        Console.WriteLine(lastdigit);
        num = num / 10;
        Console.WriteLine(num);
        sum = sum + lastdigit;
    }
    return sum;
}
int number = Input("enter  number");
int result = Multiple(number);
Console.WriteLine($"the summ of the digits of the number {number} equals {result} ");

















// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]








