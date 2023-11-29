




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

// int Input(string message)
// {
//     Console.WriteLine(message);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }
// int Multiple(int num)
// {
//     int sum = 0;

//     for (int count = 0; num > 0; count++)
//     {
//         int lastdigit = num % 10;
//         Console.WriteLine($" lastdigit is {lastdigit} ");
//         num = num / 10;
//         Console.WriteLine($" rest number is {num} ");
//         sum = sum + lastdigit;
//     }
//     return sum;
// }
// int number = Input("enter  number");
// int result = Multiple(number);
// Console.WriteLine($"the summ of the digits of the number {number} equals {result} ");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// string[] FillArray(int size)
// {
//     string[] array = new string[size];

//     for (int index = 0; index < array.Length; index++)
//     {
//         Console.WriteLine($"enter array's {index} 's element ");
//         array[index] = Convert.ToString(Console.ReadLine()!);
//     }
//     return array;
// }

// void PrintArray(string[] array)
// {
//     for (int index = 0; index < array.Length; index++)
//     {
//         Console.Write($" {array[index]}, ");
//     }
// }

// Console.Clear();
// Console.WriteLine("enter array's  size");
// int size = int.Parse(Console.ReadLine());

// string[] array1 = FillArray(size);
// Console.WriteLine();
// PrintArray(array1);









// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


// int[] FillArray(int size)
// {
//     int[] array = new int[size];
//     for (int index = 0; index < array.Length; index++)
//     {
//         array[index] = new Random().Next(-10, 10);
//         Console.Write($" {array[index]} ");
//     }
//     return array;
// }


// int[] PrintArray(int[] array)
// {
//     for (int index = 0; index < array.Length; index++)
//     {
//         array[index] = array[index] * -1;
//         Console.Write($" {array[index]} ");
//     }
//     return array;
// }


// Console.Clear();
// Console.WriteLine("enter array's  size");
// int size = int.Parse(Console.ReadLine());



// int[] array = FillArray(size);
// Console.WriteLine("");
// PrintArray(array);












// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


// int[] FillArray(int size)
// {
//     int[] array = new int[size];
//     for (int index = 0; index < array.Length; index++)
//     {
//         array[index] = new Random().Next(0, 10);
//         Console.Write($" {array[index]} ");
//     }
//     return array;
// }

// bool FindNum(int[] array, int num)
// {
//     for (int index = 0; index < array.Length; index++)
//     {
//         if (array[index] == num)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// void Result(bool arg1, int num)
// {
//     if (arg1 == true)
//     {
//         Console.WriteLine($" Selected number {num} is present ");
//     }
//     else Console.WriteLine($" Selected number {num} is Not present ");
// }

// Console.Clear();
// Console.WriteLine("enter searching number");
// int num = int.Parse(Console.ReadLine());

// Console.WriteLine("enter array's  size");
// int size = int.Parse(Console.ReadLine());

// int[] array = FillArray(size);
// Console.WriteLine("");

// bool check = FindNum(array, num);

// Result(check, num);




// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21



// int[] FillArray(int size)
// {
//     int[] array = new int[size];
//     for (int index = 0; index < array.Length; index++)
//     {
//         array[index] = new Random().Next(0, 10);
//         // Console.Write($" FillArray {array[index]} ");
//         Console.Write($"  {array[index]} ");
//     }
//     return array;
// }

// void MultipleArray(int[] array)

// // int[] MultipleArray(int[] array)
// {

//     // int[] newarray = new int[array.Length];

//     int[] newarray;

//     Console.WriteLine($" array {array.Length}   ");

//     if (array.Length % 2 != 0)
//     {
//         newarray = new int[array.Length / 2 + 1];

//         Console.WriteLine($" newarray {newarray.Length}   ");

//         for (int index = 0; index < newarray.Length; index++)
//         {
//             if (array[index] == array[(array.Length - 1) - index])
//             {
//                 newarray[index] = array[index];
//             }
//             else
//             {
//                 newarray[index] = array[index] * array[array.Length - 1 - index];
//             }
//             Console.Write($" {newarray[index]} ");
//         }
//     }
//     else
//     {
//         newarray = new int[array.Length / 2];

//         Console.WriteLine($" newarray {newarray.Length}   ");

//         for (int index = 0; index < newarray.Length; index++)
//         {
//             newarray[index] = array[index] * array[array.Length - 1 - index];

//             Console.Write($" {newarray[index]} ");
//         }
//     }
//     // return newarray;
// }

// Console.Clear();
// Console.WriteLine("enter array's  size");
// int size = int.Parse(Console.ReadLine());

// int[] array = FillArray(size);
// Console.WriteLine();
// // Console.WriteLine(FillArray(size));

// MultipleArray(array);

// // Console.WriteLine(MultipleArray(array));

// Console.WriteLine();











// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2



// int[] FillArray(int size)
// {
//     int[] array = new int[size];
//     for (int index = 0; index < array.Length; index++)
//     {
//         array[index] = new Random().Next(100, 1000);

//         Console.Write($"  {array[index]} ");
//     }
//     return array;
// }


// int CountEvenElements(int[] array)
// {
//     int summ = 0;

//     for (int index = 0; index < array.Length; index++)
//     {
//         if (array[index] % 2 == 0)
//         {
//             Console.WriteLine($" result {summ++} ");
//         }
//     }
//     return summ;
// }



// void PrintArray(int[] array)
// {
//     Console.WriteLine("  Массив: ");
//     for (int index = 0; index < array.Length; index++)
//     {
//         Console.Write($" ! {array[index]} ! ");
//     }
// }


// Console.Clear();
// Console.WriteLine("enter array's  size");
// int size = int.Parse(Console.ReadLine());
// int[] array = FillArray(size);
// Console.WriteLine(" ");
// PrintArray(array);
// // Console.WriteLine(PrintArray(array));
// Console.WriteLine();
// Console.WriteLine(CountEvenElements(array));




// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0

// int[] FillArray(int size)
// {
//     int[] array = new int[size];
//     for (int index = 0; index < array.Length; index++)
//     {
//         array[index] = new Random().Next(-10, 10);
//         // Console.Write($" FillArray {array[index]} ");
//         // Console.Write($"  {array[index]} ");
//     }
//     return array;
// }

// int SumOddElements(int[] array)
// {
//     int summ = 0;

//     for (int index = 0; index < array.Length; index++)
//     {
//         if (index % 2 != 0)
//         {
//             Console.WriteLine($" result {summ = summ + array[index]} ");
//         }
//     }
//     return summ;
// }

// void PrintArray(int[] array)
// {
//     // Console.WriteLine("  Массив: ");
//     // for (int index = 0; index < array.Length; index++)
//     // {
//     //     // Console.Write($" ! {array[index]} ! ");
//     // }
//     Console.WriteLine($"{string.Join("\t", array)}\t");
// }

// Console.Clear();
// Console.WriteLine("enter array's  size");
// int size = int.Parse(Console.ReadLine());
// int[] array = FillArray(size);
// Console.WriteLine();
// Console.WriteLine(SumOddElements(array));
// PrintArray(array);





// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76



// double[] FillArray(int size)
// {
//     // double[] array = new double[size];
//     double[] array = { 1.345, 6.567, 4.5678, 7.4567, 9.2344 };
//     // for (int index = 0; index < array.Length; index++)
//     // {
//     //     // array[index] = new Random().Next(-100, 100);
//     //     // Console.Write($" FillArray {array[index]} ");
//     //     Console.Write($"  {array[index]} ");
//     // }
//     return array;
// }

// double FindMax(double[] array)
// {
//     int index = 0;
//     double max = array[index];
//     for (index = 0; index < array.Length; index++)
//     {
//         if (array[index] > max)
//         {
//             max = Math.Round(array[index], 2);
//         }
//     }
//     return max;
// }

// double FindMin(double[] array)
// {
//     int index = 0;
//     double min = array[index];
//     for (index = 0; index < array.Length; index++)
//     {
//         if (array[index] < min)
//         {
//             min = Math.Round(array[index], 2);
//         }
//     }
//     return min;
// }

// double MaxMinDifference(double[] array)
// {
//     int index = 0;
//     double diff = 0;
//     double max = array[index];
//     double min = array[index];
//     for (index = 0; index < array.Length; index++)
//     {
//         if (array[index] > max)
//         {
//             max = Math.Round(array[index], 2);
//         }
//         if (array[index] < min)
//         {
//             min = Math.Round(array[index], 2);
//         }
//     }
//     Console.WriteLine($" max is {max} ");
//     Console.WriteLine($" min is {min} ");
//     diff = max - min;
//     return diff;
// }

// void PrintArray(double[] array)
// {
//     // Console.WriteLine("  Массив: ");
//     // for (int index = 0; index < array.Length; index++)
//     // {
//     //     Console.Write($"{Math.Round(array[index], 3)}    ");
//     // }

//     // Console.WriteLine($"{string.Join("\t", array)}\t");

// Console.WriteLine($"{string.Join("\t", Math.Round(array, 2))}\t");



// Console.WriteLine(string.Join("\t", array.Select(q => Math.Round(q, 2)).ToList()));

//     //  Console.WriteLine($"{string.Join("\t", array)}\t");
// }

// Console.Clear();
// Console.WriteLine("enter array's  size");
// int size = int.Parse(Console.ReadLine());
// double[] array = FillArray(size);
// Console.WriteLine();
// Console.WriteLine($" Max and Min El Difference is {MaxMinDifference(array)} ");
// PrintArray(array);










// int[] FillArray(int size)
// {
//     int[] array = new int[size];
//     for (int index = 0; index < array.Length; index++)
//     {
//         array[index] = new Random().Next(-10, 10);
//         // Console.Write($" FillArray {array[index]} ");
//         // Console.Write($"  {array[index]} ");
//     }
//     return array;
// }

// bool Istriangle(int[] array)
// {
//     if (array[0] < array[1] + array[2] && array[1] < array[0] + array[2] && array[2] < array[1] + array[0])
//         return true;
//     else
//         return false;


// }


// // int[] array = new int[3] { 3, 2, 3 };

// int[] array = FillArray(3);

// if (Istriangle(array))
// {

//     Console.WriteLine("yes");
// }
// else
// {
//     Console.WriteLine("no");
// }



// Console.WriteLine(string.Join("\t", array.Select(q => Math.Round(q, 2)).ToList()));

// Console.WriteLine(string.Join(", ", array.Select(x => Math.Round(x, 2))));








// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// 375 / 2 = 187 (остаток 1)      256/2 =128
// 187 / 2 = 93 (остаток 1)
// 93 / 2 = 46 (остаток 1)
// 46 / 2 = 23 (остаток 0)
// 23 / 2 = 11 (остаток 1)
// 11 / 2 = 5 (остаток 1)
// 5 / 2 = 2 (остаток 1)
// 2 / 2 = 1 (остаток 0)
// 1 / 2 = 0 (остаток 1)

// Console.WriteLine("enter a number");
// int number = int.Parse(Console.ReadLine()!);

// int convert(int arg1)
// {
//     int arraysize = 0;
//     int number = arg1;
//     for (int index = 0; arg1 > 0; index++)
//     {
//         arg1 = arg1 / 2;
//         arraysize++;
//         Console.WriteLine(arg1);
//     }
//     Console.WriteLine(arraysize);
//     return arraysize;
// }

// int[] Fillarray(int size, int number)
// {
//     int[] array = new int[size];
//     for (int index = 0; index < array.Length; index++)
//     {
//         // number = number % 2;
//         array[index] = number % 2;
//         number = number / 2;
//     }
//     return array;
// }

// int[] Reversearray(int[] array)
// {
//     for (int index = 0; index < array.Length / 2; index++)
//     {
//         int temp = array[index];
//         array[index] = array[array.Length - 1 - index];
//         array[array.Length - 1 - index] = temp;
//     }
//     return array;
// }

// Console.Clear();
// int numbersize = convert(number);
// int[] array = Fillarray(numbersize, number);
// Console.WriteLine($" {string.Join(",\t", Reversearray(array))}.");

// // Console.WriteLine($"{string.Join("\t", array)}\t");
// // Console.WriteLine($"{string.Join("\t", Math.Round(array), 2)}\t");









// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] Fillarray(int size)
// {
//     int[] array = new int[size];
//     for (int index = 0; index < array.Length; index++)
//     {
//         Console.WriteLine("Enter a digit");
//         array[index] = int.Parse(Console.ReadLine()!);
//     }
//     Console.WriteLine($" {string.Join(" ", array)} ");
//     return array;
// }

// void Checkdigits(int[] array)
// {
//     int summ = 0;
//     for (int index = 0; index < array.Length; index++)
//     {
//         if (array[index] > 0)
//         {
//             summ++;
//         }
//     }
//     Console.WriteLine($" Number of elements more ,than 0 in the array {string.Join(". ", array)} , equals {summ} ");
// }

// Console.Clear();
// Console.WriteLine("Enter number of digits will be entered");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = Fillarray(size);
// Checkdigits(array);




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// если a1b2 - a2b1 = 0 - параллельны,
// если a1b2 - a2b1 = 0 и c2b1-c1b2 = 0 - совпадают
// в остальных случаях - пересекаются

// Console.Clear();
// double b1 = input("Enter b1");
// double k1 = input("Enter k1");
// double b2 = input("Enter b2");
// double k2 = input("Enter k2");

// FindPoint(b1, k1, b2, k2);

// double input(string message)
// {
//     Console.WriteLine(message);
//     double number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// void FindPoint(double b1, double k1, double b2, double k2)
// {
//     double x = (b2 - b1) / (k1 - k2);
//     double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

//     if (k1 == k2)
//     {
//         Console.WriteLine("The lines is parallel");
//     }
//     else if ((k1 * b2) - (k2 * b1) == 0)
//     {
//         Console.WriteLine("The lines is match");
//     }
//     else
//     {
//         Console.WriteLine($"The lines is intersect, the point coordinates is {x},{y}");
//     }
// }


//Double Array testing

// Console.Clear();
// Console.WriteLine("enter rows number");
// int row = int.Parse(Console.ReadLine());

// Console.WriteLine("enter columns number");
// int column = int.Parse(Console.ReadLine());

// int[,] doublearray = new int[row, column];


// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.WriteLine("enter array's element");
//             array[i, j] = int.Parse(Console.ReadLine());
//         }
//     }

//     // Console.WriteLine($" , {string.Join(",", array)}  ");
// }


// FillArray(doublearray);
// PrintArray(doublearray);





// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($" , {array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }









// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5



// int[,] FillArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i + j;
//         }
//     }

//     return array;
// }



// void PrintArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             Console.Write($" , {array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }



// Console.Clear();
// Console.WriteLine("enter rows number");
// int row = int.Parse(Console.ReadLine());

// Console.WriteLine("enter columns number");
// int column = int.Parse(Console.ReadLine());

// int[,] array = FillArray(row, column);
// PrintArray(array);





// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4




// int[,] FillArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//             Console.Write($" , {array[i, j]} ");
//             if (i % 2 != 0 && j % 2 != 0)
//             {
//                 array[i, j] = array[i, j] * array[i, j];
//             }
//         }
//     }

//     return array;
// }



// void PrintArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             Console.Write($" , {array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }



// Console.Clear();
// Console.WriteLine("enter rows number");
// int row = int.Parse(Console.ReadLine());

// Console.WriteLine("enter columns number");
// int column = int.Parse(Console.ReadLine());

// int[,] array = FillArray(row, column);
// PrintArray(array);



// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// int[,] FillArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             Console.Write($" , {array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void Check(int[,] array)
// {
//     int summ = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 summ = summ + array[i, j];
//             }
//         }
//     }
//     Console.Write($" , {summ} ");
// }

// void Check(int[,] array)
// {
//     int summ = 0;
//     for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
//     {
//         summ = summ + array[i, i];
//     }
//     Console.Write($" , {summ} ");
// }

// Console.Clear();
// Console.WriteLine("enter rows number");
// int row = int.Parse(Console.ReadLine());

// Console.WriteLine("enter columns number");
// int column = int.Parse(Console.ReadLine());

// int[,] array = FillArray(row, column);
// PrintArray(array);
// Check(array);




// Найти среднее арифметическое элементов матрицы, расположенных "по углам"



// public static double Mean(int[,] arr)
//         {
//             return (arr[0,
//                 arr.GetLength(1)-1] + arr[0, 0] + arr[arr.GetLength(0)-1, 0] + arr[arr.GetLength(0)-1, arr.GetLength(1)-1])/4.0;
//         }



// double AngleSumm(int[,] array)
// {
//     double summ = (array[0, 0] + array[0, (array.GetLength(1) - 1)] + array[(array.GetLength(1) - 1), 0] + array[(array.GetLength(1) - 1), (array.GetLength(1) - 1)]) / 4.0;
//     Console.Write($" , AngleSumm {summ} ");
//     return summ;
// }


// int[,] FillArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             Console.Write($" , {array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// Console.Clear();
// Console.WriteLine("enter rows number");
// int row = int.Parse(Console.ReadLine());

// Console.WriteLine("enter columns number");
// int column = int.Parse(Console.ReadLine());

// int[,] array = FillArray(row, column);
// PrintArray(array);
// AngleSumm(array);





// Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// double[,] FillArray(int m, int n, int minLimitRandom, int maxLimitRandom)
// {
//     double[,] array = new double[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().NextDouble() * (maxLimitRandom - minLimitRandom) + minLimitRandom;
//         }
//     }
//     return array;
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             Console.Write($"\t{array[i, j]}");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.WriteLine("enter rows number");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine("enter columns number");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine("enter max range");
// int maxLimitRandom = int.Parse(Console.ReadLine());

// Console.WriteLine("enter min range");
// int minLimitRandom = int.Parse(Console.ReadLine());

// double[,] array = FillArray(m, n, minLimitRandom, maxLimitRandom);
// PrintArray(array);



















// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 0, 2 -> 7



// int[,] FillArray(int m, int n, int k)
// {
//     int[,] array = new int[m, n];
//     int increment = 1;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = array[i, j] + increment;
//             increment = increment + k;
//         }
//     }
//     return array;
// }


// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {

//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }


// int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
// {
//     if (rowPosition < 0 || columnPosition < 0 || rowPosition > matrix.GetLength(0) - 1 || columnPosition > matrix.GetLength(1) - 1)
//     {
//         // int[] array = new int[] { 0 };
//         // return array;
//         return new int[] { 0 };
//     }
//     else
//     {
//         int number = matrix[rowPosition, columnPosition];
//         int[] array = new int[] { number, 0 };
//         // new int[] { number, 0 };
//         Console.WriteLine($"number {number}   ");
//         // array[0] = matrix[rowPosition, columnPosition];
//         // array[1] = 0;
//         return array;
//     }
// }

// void PrintCheckIfError(int[] results, int X, int Y)
// {
//     if (results.Length != 1)
//     {
//         Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
//     }
//     else
//     {
//         Console.WriteLine($"There is no such index");
//     }
// }

// Console.Clear();
// Console.WriteLine("enter rows number");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine("enter columns number");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine("enter increment number");
// int k = int.Parse(Console.ReadLine());

// Console.WriteLine("enter searched row number");
// int rowPosition = int.Parse(Console.ReadLine());

// Console.WriteLine("enter searched column number");
// int columnPosition = int.Parse(Console.ReadLine());

// int[,] array = FillArray(m, n, k);
// PrintArray(array);
// int[] result = FindNumberByPosition(array, rowPosition, columnPosition);

// PrintCheckIfError(result, rowPosition, columnPosition);




// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.




// int[,] FillArray(int m, int n, int k)
// {
//     int[,] array = new int[m, n];
//     int increment = 1;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = array[i, j] + increment;
//             increment = increment + k;
//         }
//     }
//     return array;
// }


// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {

//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }


// double[] FindAverageInColumns(int[,] matrix)
// {
//     double columnsumm = 0;
//     double[] array = new double[matrix.GetLength(1)];

//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(0); j++)
//         {
//             columnsumm = columnsumm + array[j];
//         }
//         array[i] = columnsumm;
//         Console.Write($"{array[i]}, ");
//     }
//     return array;
// }















// int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
// {
//     if (rowPosition < 0 || columnPosition < 0 || rowPosition > matrix.GetLength(0) - 1 || columnPosition > matrix.GetLength(1) - 1)
//     {
//         // int[] array = new int[] { 0 };
//         // return array;
//         return new int[] { 0 };
//     }
//     else
//     {
//         int number = matrix[rowPosition, columnPosition];
//         int[] array = new int[] { number, 0 };
//         // new int[] { number, 0 };
//         Console.WriteLine($"number {number}   ");
//         // array[0] = matrix[rowPosition, columnPosition];
//         // array[1] = 0;
//         return array;
//     }
// }

// void PrintCheckIfError(int[] results, int X, int Y)
// {
//     if (results.Length != 1)
//     {
//         Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
//     }
//     else
//     {
//         Console.WriteLine($"There is no such index");
//     }
// }

// Console.Clear();
// Console.WriteLine("enter rows number");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine("enter columns number");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine("enter increment number");
// int k = int.Parse(Console.ReadLine());

// // Console.WriteLine("enter searched row number");
// // int rowPosition = int.Parse(Console.ReadLine());

// // Console.WriteLine("enter searched column number");
// // int columnPosition = int.Parse(Console.ReadLine());

// int[,] array = FillArray(m, n, k);
// PrintArray(array);

// FindAverageInColumns(array);




// int[] result = FindNumberByPosition(array, rowPosition, columnPosition);

// PrintCheckIfError(result, rowPosition, columnPosition);







// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return array;
// }


// int[,] SwapArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(1); i++)
//     {

//         int temp = array[0, i];
//         array[0, i] = array[array.GetLength(0) - 1, i];
//         array[array.GetLength(0) - 1, i] = temp;

//     }




//     return array;



// }











// Console.Clear();
// Console.WriteLine("enter rows number");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine("enter columns number");
// int n = int.Parse(Console.ReadLine());


// int[,] array = FillArray(m, n);









// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.


// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return array;
// }

// int[,] ChangeArray(int[,] array)
// {

//     int[,] newarray = new int[array.GetLength(1), array.GetLength(0)];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             newarray[j, i] = array[i, j];
//         }
//     }
//     return newarray;
// }

// int[,] PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($" {array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }

// Console.Clear();
// Console.WriteLine("enter rows number");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine("enter columns number");
// int n = int.Parse(Console.ReadLine());

// int[,] array = FillArray(m, n);
// PrintArray(array);
// Console.WriteLine();
// int[,] newarr = ChangeArray(array);
// Console.WriteLine();
// PrintArray(newarr);




// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.



// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return array;
// }

// int[,] PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($" {array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }


// void CheckArray(int[,] array)
// {
//     for (int k = 0; k <= 9; k++)
//     {
//         int count = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (array[i, j] == k)
//                 {
//                     count++;
//                 }
//             }
//         }
//         if (count > 0)
//         {
//             Console.WriteLine($" {k} has {count} times");
//         }
//     }
// }

// Console.Clear();
// Console.WriteLine("enter rows number");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine("enter columns number");
// int n = int.Parse(Console.ReadLine());

// int[,] array = FillArray(m, n);

// PrintArray(array);
// CheckArray(array);




// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7



// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return array;
// }

// int[,] PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($" {array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }


// int[] FindEl(int[,] array)
// {
//     int[] newarr = new int[2];
//     int min = array[0, 0];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < min)
//             {
//                 min = array[i, j];
//                 newarr[0] = i;
//                 newarr[1] = j;
//             }
//         }
//     }
//     Console.WriteLine($"min el in array {min}");

//     return newarr;

// }


// // // int[,] CheckArray(int[,] oldarray, int elrow, int elcol)

// int[,] CheckArray(int[,] oldarray, int[] elarray)

// {
//     int row = 0;
//     int column = 0;

//     Console.WriteLine($"el position - {string.Join(",", elarray)}\t");

//     int[,] newarr = new int[oldarray.GetLength(0) - 1, oldarray.GetLength(1) - 1];

//     for (int i = 0; i < oldarray.GetLength(0); i++)
//     {
//         if (i == elarray[0])
//         {
//             row++;
//         }
//         for (int j = 0; j < oldarray.GetLength(1); j++)
//         {
//             // newarr[i, j] = oldarray[i + row, j];
//             if (j == elarray[1])
//             {
//                 column++;
//             }
//             newarr[i, j] = oldarray[i + row, j + column];
//         }
//         row = 0;
//     }
//     return newarr;
// }

// Console.Clear();
// Console.WriteLine("enter rows number");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine("enter columns number");
// int n = int.Parse(Console.ReadLine());

// int[,] array = FillArray(m, n);
// PrintArray(array);

// // int[] newarr = FindEl(array);

// int[,] result = CheckArray(array, FindEl(array));
// PrintArray(result);





// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.



// using System;
// public class Answer
// {
//     public static void PrintArray(int[,] matrix)
//     {
//         // Введите свое решение ниже
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write($"{matrix[i, j]}\t");
//             }
//             Console.WriteLine();
//         }
//     }
//     public static int[,] CreateIncreasingMatrix(int n, int m, int k)
//     {
//         // Введите свое решение ниже
//         int[,] array = new int[n, m];
//         int increment = 1;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array[i, j] = array[i, j] + increment;
//                 increment = increment + k;
//             }
//         }
//         return array;
//     }
//     static void PrintListAvr(double[] list)
//     {

//         // Введите свое решение ниже
//         Console.WriteLine($" The averages in columns are: ");

//         for (int i = 0; i < list.Length; i++)
//         {
//             double temp = list[i];
//             Console.Write($"{temp.ToString("0.00")}\t");
//         }
//     }

//     static double[] FindAverageInColumns(int[,] matrix)
//     {
//         // Введите свое решение ниже
//         double[] array = new double[matrix.GetLength(1)];
//         for (int i = 0; i < matrix.GetLength(1); i++)
//         {
//             double summ = 0.00000;
//             for (int j = 0; j < matrix.GetLength(0); j++)
//             {
//                 summ = summ + matrix[j, i];
//                 // Console.Write($"el/{matrix[j, i]}--");
//             }
//             array[i] = summ / matrix.GetLength(0);
//             // Console.Write($"ar.mean/{Math.Round(array[i], 2)};");
//         }
//         // Console.WriteLine($"array {string.Join("/", array)}");
//         return array;
//     }

//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args)
//     {
//         int n, m, k;

//         if (args.Length >= 3)
//         {
//             n = int.Parse(args[0]);
//             m = int.Parse(args[1]);
//             k = int.Parse(args[2]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             n = 3;
//             m = 4;
//             k = 2;
//         }
//         // Не удаляйте строки ниже
//         int[,] result = CreateIncreasingMatrix(n, m, k);
//         PrintArray(result);
//         Console.WriteLine();
//         PrintListAvr(FindAverageInColumns(result));
//         // FindAverageInColumns(result);
//     }
// }


// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.


// int[,] FillArray(int row, int col)
// {
//     int[,] array = new int[row, col];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return array;
// }

// int[,] PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
//     return matrix;
// }

// int[,] SortArray(int[,] matrix)
// {
//     int i = 0;
//     int j = 0;
//     for (i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//             {
//                 if (matrix[i, k] < matrix[i, k + 1])
//                 {
//                     int temp = matrix[i, k];
//                     matrix[i, k] = matrix[i, k + 1];
//                     matrix[i, k + 1] = temp;
//                 }
//             }
//         }
//     }
//     return matrix;
// }


// Console.Clear();
// Console.WriteLine("enter rows number");
// int row = int.Parse(Console.ReadLine());

// Console.WriteLine("enter columns number");
// int col = int.Parse(Console.ReadLine());

// int[,] array = FillArray(row, col);
// PrintArray(array);
// // int[,] newarray = SortArray(array);
// int[,] newarray = SortArray(array);
// Console.WriteLine();
// PrintArray(newarray);






// using System;

// public class Answer
// {

//     public static void SortRowsDescending(int[,] matrix)
//     {
//         // Введите свое решение ниже
//         int i = 0;
//         int j = 0;
//         for (i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (j = 0; j < matrix.GetLength(1); j++)
//             {
//                 for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//                 {
//                     if (matrix[i, k] < matrix[i, k + 1])
//                     {
//                         int temp = matrix[i, k];
//                         matrix[i, k] = matrix[i, k + 1];
//                         matrix[i, k + 1] = temp;
//                     }
//                 }
//             }
//         }


//     }


//     public static void PrintMatrix(int[,] matrix)
//     {  // Введите свое решение ниже
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write($"{matrix[i, j]}\t");
//             }
//             Console.WriteLine();
//         }

//     }
//     // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args)
//     {
//         int[,] matrix;

//         if (args.Length == 0)
//         {
//             // Если аргументы не переданы, используем матрицу по умолчанию
//             matrix = new int[,]
//             {
//                 {5, 2, 9},
//                 {8, 1, 4},
//                 {6, 7, 3}
//             };
//         }
//         else
//         {
//             // Иначе, парсим аргументы в двумерный массив
//             string[] rows = args[0].Split(';');
//             matrix = new int[rows.Length, rows[0].Split(',').Length];
//             for (int i = 0; i < rows.Length; i++)
//             {
//                 string[] elements = rows[i].Split(',');
//                 if (elements.Length != matrix.GetLength(1))
//                 {
//                     Console.WriteLine($"Ошибка: Неправильное количество элементов в строке {i + 1}.");
//                     return;
//                 }
//                 for (int j = 0; j < elements.Length; j++)
//                 {
//                     if (int.TryParse(elements[j], out int number))
//                     {
//                         matrix[i, j] = number;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
//                         return;
//                     }
//                 }
//             }
//         }


//         Console.WriteLine("Исходная матрица:");
//         PrintMatrix(matrix);

//         SortRowsDescending(matrix);

//         Console.WriteLine("\nМатрица с упорядоченными по убыванию строками:");
//         PrintMatrix(matrix);
//     }
// }






// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

// Определение строки с наименьшей суммой элементов


// using System;
// public class Answer
// {
//     public static int SumOfRow(int[,] matrix, int row)
//     {
//         // Введите свое решение ниже
//         int summ = 0;
//         for (int i = 0; i < matrix.GetLength(1); i++)
//         {
//             // summ = summ + matrix[row, i];
//             summ += matrix[row, i];
//         }
//         return summ;
//     }

//     public static int[] MinimumSumRow(int[,] matrix)
//     {
//         // Введите свое решение ниже
//         int[] result = new int[2];
//         int rowindex = 0;
//         // int minsumm = int.MaxValue;
//         int minsumm = SumOfRow(matrix, 0);
//         Console.WriteLine($"minsumm-{minsumm}");

//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             int rowsumm = SumOfRow(matrix, i);
//             Console.WriteLine($"rowsumm-{rowsumm}");
//             if (rowsumm < minsumm)
//             {
//                 minsumm = rowsumm;
//                 rowindex = i;
//             }
//             result[0] = rowindex;
//             result[1] = minsumm;
//             // result[1] = SumOfRow(matrix, rowindex);
//             // Console.WriteLine($"minsumm-11-{minsumm}");
//         }
//         return result;
//     }

//     // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args)
//     {
//         int[,] matrix;
//         if (args.Length == 0)
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             // Если аргументы не переданы, используем матрицу по умолчанию

//             matrix = new int[,]
//             {
//                 {2, 5, 3},
//                 {4, 1, 2},
//                 {9, 6, 9}
//             };
//         }
//         else
//         {
//             // Иначе, парсим аргументы в двумерный массив
//             string[] rows = args[0].Split(';');
//             matrix = new int[rows.Length, rows[0].Split(',').Length];
//             for (int i = 0; i < rows.Length; i++)
//             {
//                 string[] elements = rows[i].Split(',');
//                 for (int j = 0; j < elements.Length; j++)
//                 {
//                     if (int.TryParse(elements[j], out int number))
//                     {
//                         matrix[i, j] = number;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
//                         return;
//                     }
//                 }
//             }
//         }

//         Console.WriteLine("Исходная матрица:");
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write($"{matrix[i, j]}\t");
//             }
//             Console.WriteLine();
//         }

//         int[] minSumRow = MinimumSumRow(matrix);

//         Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");

//     }
// }













// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.



// using System;

// public class Answer
// {
//     public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
//     { // Введите свое решение ниже
//       // if (matrixA.GetLength(1) != matrixB.GetLength(0) || matrixA.GetLength(0) != matrixB.GetLength(1))
//         if (matrixA.GetLength(1) != matrixB.GetLength(0))
//         {
//             Console.WriteLine($"It is impossible to multiply.");
//         }
//         else
//         {
//             int[,] result = MatrixMultiplication(matrixA, matrixB);
//             PrintMatrix(result);
//             // PrintMatrix(MatrixMultiplication(matrixA, matrixB));


//         }
//     }

//     public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
//     {  // Введите свое решение ниже

//         int[,] newmatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

//         for (int i = 0; i < newmatrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < newmatrix.GetLength(1); j++)
//             {
//                 for (int k = 0; k < matrixA.GetLength(1); k++)
//                 {

//                     // newmatrix[i, j] += matrixA[i, k] * matrixB[k, j];

//                     newmatrix[i, j] = newmatrix[i, j] + matrixA[i, k] * matrixB[k, j];

//                     // newmatrix[i, j] = matrixA[i, j] * matrixB[i, j] + matrixA[i, j + 1] * matrixB[i + 1, j];    ///29

//                     // newmatrix[i, j + 1] = matrixA[i, j] * matrixB[i, j + 1] + matrixA[i, j + 1] * matrixB[i + 1, j + 1];  ///26

//                     // newmatrix[i + 1, j] = matrixA[i, j] * matrixB[i, j] + matrixA[i + 1, j] * matrixB[i + 1, j + 1];   ///47

//                     // newmatrix[i + 1, j + 1] = matrixA[i + 1, j] * matrixB[i, j + 1] + matrixA[i + 1, j + 1] * matrixB[i + 1, j + 1];   ///52
//                 }
//             }
//         }
//         return newmatrix;
//     }

//     public static void PrintMatrix(int[,] matrix)
//     {  // Введите свое решение ниже
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write($"{matrix[i, j]}\t");
//             }
//             Console.WriteLine();
//         }
//     }

//     // Не удаляйте и не меняйте метод Main! 

//     public static void Main(string[] args)
//     {
//         int[,] matrix;

//         if (args.Length == 0)
//         {
//             // Если аргументы не переданы, используем матрицу по умолчанию
//             matrix = new int[,]
//             {
//                 {3, 2},
//                 {8, 1}
//             };
//         }
//         else
//         {
//             // Иначе, парсим аргументы в двумерный массив
//             string[] rows = args[0].Split(';');
//             matrix = new int[rows.Length, rows[0].Split(',').Length];
//             for (int i = 0; i < rows.Length; i++)
//             {
//                 string[] elements = rows[i].Split(',');
//                 for (int j = 0; j < elements.Length; j++)
//                 {
//                     if (int.TryParse(elements[j], out int number))
//                     {
//                         matrix[i, j] = number;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
//                         return;
//                     }
//                 }
//             }
//         }

//         Console.WriteLine("Исходная матрица:");
//         PrintMatrix(matrix);

//         int[,] matrixB = {
//             {5, 6},
//             {7,4}
//         };

//         Console.WriteLine("\nMatrix B:");
//         PrintMatrix(matrixB);

//         Console.WriteLine("\nMultiplication result:");

//         MultiplyIfPossible(matrix, matrixB);
//     }
// }






// using System;

// public class Answer
// {
//     public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
//     {
//         if (matrixA.GetLength(1) != matrixB.GetLength(0))
//         {
//             Console.WriteLine("It is impossible to multiply.");
//         }
//         else
//         {
//             int[,] multiplicative = MatrixMultiplication(matrixA, matrixB);
//             PrintMatrix(multiplicative);
//         }
//     }

//     public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
//     {
//         int[,] multiplicative = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
//         for (int i = 0; i < multiplicative.GetLength(0); i++)
//         {
//             for (int j = 0; j < multiplicative.GetLength(1); j++)
//             {
//                 for (int k = 0; k < matrixA.GetLength(1); k++)
//                 {
//                     multiplicative[i, j] += matrixA[i, k] * matrixB[k, j];
//                 }
//             }
//         }
//         return multiplicative;
//     }

//     public static void PrintMatrix(int[,] matrix)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write($"{matrix[i, j]}\t");
//             }
//             Console.WriteLine();
//         }
//     }

//     public static void Main(string[] args)
//     {
//         int[,] matrix;

//         if (args.Length == 0)
//         {
//             // Если аргументы не переданы, используем матрицу по умолчанию
//             matrix = new int[,]
//             {
//                 {5, 2},
//                 {5, 2},
//                 {5, 2},
//                 {5, 2},
//                 {5, 2},
//                 {5, 2},
//                 {8, 1}
//             };
//         }
//         else
//         {
//             // Иначе, парсим аргументы в двумерный массив
//             string[] rows = args[0].Split(';');
//             matrix = new int[rows.Length, rows[0].Split(',').Length];
//             for (int i = 0; i < rows.Length; i++)
//             {
//                 string[] elements = rows[i].Split(',');
//                 for (int j = 0; j < elements.Length; j++)
//                 {
//                     if (int.TryParse(elements[j], out int number))
//                     {
//                         matrix[i, j] = number;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
//                         return;
//                     }
//                 }
//             }
//         }

//         Console.WriteLine("Исходная матрица:");
//         PrintMatrix(matrix);

//         int[,] matrixB = {
//             {5, 1,6,3,2},
//             {7,1, 8,4,3}
//         };

//         Console.WriteLine("\nMatrix B:");
//         PrintMatrix(matrixB);

//         Console.WriteLine("\nMultiplication result:");

//         MultiplyIfPossible(matrix, matrixB);
//     }
// }














// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.










// Задача 62: Заполните спирально массив 4 на 4.
















// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


// int n = 453;
// int digitscore(int n)
// {
//     if (n == 0)
//     {
//         return 0;
//     }
//     int lastdigit = n % 10;
//     int restdigits = n / 10;
//     int summ = digitscore(restdigits) + lastdigit;
//     return summ;
// }
// Console.WriteLine(digitscore(n));


// int n = 453;
// int digitscore(int n)
// {
//     {
//         if (n == 0)
//             return 0;
//     }
//     return n % 10 + digitscore(n / 10);
// }
// Console.WriteLine(digitscore(n));





// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int digitscore(int a, int b)
// {
//     if (b == 0)
//     {
//         return 1;
//     }
//     int square = a;

//     return square * digitscore(square, b - 1);
// }

// int a = 3;
// int b = 3;

// Console.WriteLine(digitscore(a, b));






// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


// int m = 1;
// int n = 10;
// int recursion(int m)
// {
//     if (m == n) return m;
//     Console.Write($"m{m}");
//     return m + recursion(m + 1);
// }
// Console.WriteLine();
// Console.WriteLine($"   digits summ is - {recursion(m)}");





// int n = 1;
// int recursion1(int n)
// {
//     if (n == 6)
//     {
//         return n;
//     }
//     Console.Write($"{n}.");
//     return recursion1(n + 1);
// }
// recursion1(n);








// same as



// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// int digitscore(int m, int n)
// {
//     if (n == 0)
//     {
//         n = n + 1;
//         return
//                 0;
//     }
//     Console.Write($"\t{m}, ");
//     int digit = m + 1;

//     return (digitscore(digit, n - 1));
// }
// int m = 0;
// int n = 4;
// Console.WriteLine(digitscore(m, n));







// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int n = -10;

// int recursion(int n)
// {
//     if (n < 1)
//     {
//         return 0;
//     }
//     else
//     {

//         Console.WriteLine(n);
//         n = n - 1;
//         return recursion(n);
//     }
// }

// recursion(n);




// int m = 0;
// int recursion(int m)
// {
//     // int n = 10;
//     if (m == 10) return 10;
//     Console.Write($"m{m}");
//     return m + recursion(m + 1);
// }
// Console.WriteLine();
// Console.WriteLine($"   digits summ is - {recursion(m)}");




// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int m = 1;
// int n = 15;
// int recursion(int m, int n)
// {
//     if (m == n) return m;

//     return m + recursion(m + 1, n);
// }
// Console.WriteLine(recursion(m, n));





// int m = 1;
// int n = 5;

// int recursion(int m, int n)
// {

//     if (m == n)
//     {
//         // Console.WriteLine($" 2nd-returned m is -{m}");
//         return m;
//     }
//     // int temp = m + 1;

//     // Console.WriteLine($" 1st -recursive-m -is {m}");

//     int summ = recursion(m + 1, n) + m;

//     // Console.WriteLine($" result summ {summ}");

//     return summ;

// }
// Console.WriteLine(recursion(m, n));




// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
// m = 3, n = 2 -> A(m,n) = 9

// int m = 3;
// int n = 2;

// int akkerman(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) return akkerman(m - 1, 1);
//     else return akkerman(m - 1, akkerman(m, n - 1));
// }
// Console.Write($"Функция Аккермана равно {akkerman(m, n)} ");

//

// int argA = 10;
// int argB = 20;
// int akkerman(int argA, int argB)
// {
//     if (argA == 0)
//     {
//         Console.WriteLine($" 1st  returned argA is -{argA}");
//         Console.WriteLine($" 1st  returned argB is -{argB}");
//         return argB + 1;
//     }
//     else
//     if (argA > 0 && argB == 0)
//     {
//         Console.WriteLine($" 2nd  returned argA is -{argA}");
//         Console.WriteLine($"  2nd returned argB is -{argB}");
//         return akkerman(argA - 1, 1);
//     }
//     else
//         Console.WriteLine($" 3rd  returned argA is -{argA}");
//     Console.WriteLine($"  3rd returned argB is -{argB}");
//     return akkerman(argA - 1, akkerman(argA, argB - 1));
// }
// Console.WriteLine(akkerman(argA, argB));







// Задача 60:
// Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.


// Console.WriteLine("Enter layers number");
// int layer = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Enter rows number");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Enter colums number");
// int columns = int.Parse(Console.ReadLine()!);

// // string[,] newarray = new string[3, 3] { { "a", "b", "c" }, { "d", "e", "f" }, { "g", "h", "i" } };

// // int[,] multi_dim = { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 }, { 100, 110, 120 } };

// int[,,] Fillarray(int layer, int rows, int columns)
// {
//     int[,,] array = new int[layer, rows, columns];

//     for (int k = 0; k < layer; k++)
//     {
//         Console.WriteLine($"Номер слоя - массив-{k}");

//         for (int i = 0; i < rows; i++)
//         {
//             Console.WriteLine($"Номер строки {i}");

//             for (int j = 0; j < columns; j++)
//             {
//                 array[k, i, j] = new Random().Next(10, 100);

//                 Console.Write($"элемент- {array[k, i, j]}   -  {k},{i},{j},");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
//     return array;
// }

// int[,,] Zarray = Fillarray(layer, rows, columns);





// Задача 62:
// Заполните спирально массив 4 на 4.
// Домашнее задание

// Console.WriteLine("Enter layers number");
// int layer = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Enter rows number");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Enter colums number");
// int columns = int.Parse(Console.ReadLine()!);

// int[,,] FillArray(int layer, int rows, int columns)
// {
//     int[,,] array = new int[layer, rows, columns];
//     for (int i = 0; i < layer; i++)
//     {
//         // Console.WriteLine($"Номер строки {i}");

//         for (int j = 0; j < columns; j++)
//         {
//             // array[i, j] = new Random().Next(10, 100);
//             for (int k = 0; k < rows; k++)
//             {
//                 // array[j, i] = new Random().Next(10, 100);

//                 array[j, i, k] = int.Parse(Console.ReadLine()!);

//                 Console.Write($"элемент- {array[j, i, k]}   -  {i},{j},{k}");
//             }
//             Console.WriteLine();
//         }
//         // Console.Write($"элемент- {array[i, j, k]}   -  {i},{j},{k}");
//     }
//     return array;
// }

// void PrintArray(int[,,] array)
// {
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             for (int k = 0; k < rows; k++)
//             {
//                 Console.Write($"элемент-{array[i, j, k]}- {i},{j},{k}  ");
//             }
//             Console.WriteLine($"Номер строки {j}");
//         }
//     }
// }

// int[,,] newarray = FillArray(layer, rows, columns);
// PrintArray(newarray);




// Console.WriteLine("Enter rows number");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Enter colums number");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] FillArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         // Console.WriteLine($"Номер строки {i}");

//         for (int j = 0; j < columns; j++)
//         {
//             // array[i, j] = new Random().Next(10, 100);
//             Console.WriteLine($"Enter элемент {i},{j}");
//             array[i, j] = int.Parse(Console.ReadLine()!);

//             Console.Write($"элемент-{i},{j}-{array[i, j]}");
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//         // Console.Write($"элемент- {array[i, j, k]}   -  {i},{j},{k}");
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < rows; i++)
//     {
//         Console.WriteLine($" Номер строки {i}");
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write($" элемент-{i},{j}- {array[i, j]}");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] newarray = FillArray(rows, columns);
// PrintArray(newarray);





// Итоговая контрольная работа по основному блоку
// Урок 1. Контрольная работа
// Данная работа необходима для проверки ваших знаний и навыков 
// по итогу прохождения первого блока обучения на программе Разработчик. 
// Мы должны убедится, что базовое знакомство с IT прошло успешно.


// Задача алгоритмически не самая сложная, 
// однако для полноценного выполнения проверочной работы необходимо:


// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма 
// (можно обойтись блок-схемой основной содержательной части, 
// если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения 
// (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом 
// (не должно быть так, что всё залито одним коммитом, 
// как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)



// Задача: Написать программу, 
// которая из имеющегося массива строк формирует новый массив из строк, 

// длина которых меньше, либо равна 3 символам. 

// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []




// using System;

// public class Answer
// {

Console.WriteLine("Enter rows number");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Enter colums number");
int columns = int.Parse(Console.ReadLine());


string[,] FillArray(int rows, int columns)
{
    string[,] array = new string[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        Console.WriteLine("1st row");
        for (int j = 0; j < columns; j++)
        {
            Console.WriteLine("Enter massive's element");
            array[i, j] = Console.ReadLine()!;
        }
        Console.WriteLine();
        Console.WriteLine("next row");
    }
    return array;
}


void PrintArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($" Номер строки {i}");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" элемент-{i},{j}- {array[i, j]}");
        }
        Console.WriteLine();
    }
}

int ElementCount(string[,] array)
{
    int arraysize = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j].Length <= 3)
            {
                arraysize = arraysize + 1;
            }
        }
    }
    Console.WriteLine($"newarraysize is {arraysize} elements");
    return arraysize;
}

void ChangedArray(string[,] array, int arraysize)
{
    string[] newarray = new string[arraysize];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j].Length <= 3)
            {
                newarray[i] = array[i, j];
                Console.Write($"[{newarray[i]}]");
            }
        }
    }
}


Console.Clear();
string[,] newarray = FillArray(rows, columns);
PrintArray(newarray);
int newarraysize = ElementCount(newarray);
Console.WriteLine("newarray");
ChangedArray(newarray, newarraysize);
Console.WriteLine();
// PrintArray(ChangeArray(newarray));

