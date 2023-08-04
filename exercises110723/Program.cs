





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

// Console.WriteLine("enter a number 1 to 10 : ");
// int find = int.Parse(Console.ReadLine());
// Console.WriteLine();

// int[] array = { 1, 2, 4, 1, 3, 4, 5, 3, 3, 6, 7, 8, 9, 9, 9, 4, 5, 8 };
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
//         break;
//     }
//     index++;
// }
// Console.WriteLine("the find is :" + find);

// to find an index of the entered number using functions(methods) a void method

// void FillArray(int[] array1)
// {
//     int length1 = array1.Length;
//     int index = 0;
//     while (index < length1)
//     {
//         array1[index] = new Random().Next(1, 10);
//         index++;
//     }
// }

// void PrintArray(int[] array2)
// {
//     int length2 = array2.Length;
//     int index = 0;
//     while (index < length2)
//     {
//         Console.WriteLine(array2[index]);
//         index++;
//     }
// }

// int IndexOf(int[] array1, int find)
// {
//     int size = array1.Length;
//     int index = 0;
//     int numberposition = -1;

//     while (index < size)
//     {
//         if (array1[index] == find)
//         {
//             numberposition = index;
//             break;
//         }
//         index++;
//     }
//     return numberposition;
// }

// int[] numbers = new int[15];
// FillArray(numbers);
// PrintArray(numbers);
// // Console.WriteLine();
// int pos = IndexOf(numbers, find);
// Console.WriteLine();
// Console.WriteLine("number's index is " + pos);
// Console.WriteLine("the find is " + find);





// Seminar's exercises


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// to find second digit of a random number


// int Get2ndDigit(int arg)
// {
//     int num = new Random().Next(-10000, 10000);
//     // int num = -9865;
//     Console.WriteLine(num);
//     if ((num > 1000) || (num < -1000) || (num < 100 && num > -100))
//     {
//         Console.WriteLine("there is no  3 digit number :" + num);
//     }
//     else
//     {
//         while ((num > 100) || (num < -100))
//         {
//             num = num / 10;
//         }
//         num = num % 10;
//     }
//     Console.WriteLine(num);
//     return num;
// }
// int number = 0;
// Console.WriteLine(Get2ndDigit(number));



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
//&& - логическое "И"
// || - логическое "Или"

// to get 3rd digit of a number or nothing


// int Get3rdDigit(int arg1)
// {
//     int num = new Random().Next(-1000000, 10000000);
//     // int num = -58976;
//     Console.WriteLine(num);
//     if (num < 100 && num > -100)
//     {
//         Console.WriteLine("there is no 3rd digit :" + num);
//     }
//     else
//     {
//         while ((num <= -1000) || (num >= 1000))
//         {
//             num = num / 10;
//         }
//         num = num % 10;
//     }
//     Console.WriteLine(num);
//     return num;
// }
// int number = 0;
// Console.WriteLine(Get3rdDigit(number));



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// to distinguish weekday's number


// int WeekDayCheck(int arg1)
// {
//     int day = int.Parse(Console.ReadLine());

//     if ((day < 1) || (day > 7))
//     {
//         Console.WriteLine("Enter a weekday number");
//     }
//     else if ((day == 6) || (day == 7))
//     {
//         Console.WriteLine("Congrads! today is a restday!");
//     }
//     else
//     {
//         Console.WriteLine("Go to work man!");
//     }
//     return day;
// }
// int daycheck = 0;
// Console.WriteLine("enter a weekday's number");
// Console.WriteLine(WeekDayCheck(daycheck));



// To distinguish a weekday's name

// string DayNameInput(string input)
// {
//     Console.WriteLine(input);
//     string day = Console.ReadLine();
//     return day;
// }
// string GetWeekday(string wday)
// {
//     // Console.WriteLine("Enter a weekday");
//     // string wday = Console.ReadLine();
//     if ((wday == "monday") || (wday == "tuesday") || (wday == "wednesday") || (wday == "thursday") || (wday == "friday") || (wday == "sunday") || (wday == "saturday"))
//     {

//         if ((wday == "sunday") || (wday == "saturday"))
//         {
//             Console.WriteLine("Congrads! today is a restday!");
//         }
//         else
//         {
//             Console.WriteLine("Go to work man!");
//         }

//     }
//     else
//     {
//         Console.WriteLine("Enter a weekday's name");
//     }
//     return wday;
// }
// // string daycheck = "";
// // Console.WriteLine(GetWeekday(daycheck));

// string wdayinput = DayNameInput("Enter a weekday's name : ");
// GetWeekday(wdayinput);


// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


// int Request(string messagein)
// {
//     Console.WriteLine(messagein);
//     int KeyInput = int.Parse(Console.ReadLine());
//     return KeyInput;
// }
// void FindCoordinates(int quarter)
// {
//     if (quarter == 1)
//     {
//         Console.WriteLine("coordinates between 0 and x , 0 and y ");
//     }
//     if (quarter == 2)
//     {
//         Console.WriteLine("coordinates between 0 and -x , 0 and y ");
//     }
//     if (quarter == 3)
//     {
//         Console.WriteLine("coordinates between 0 and x , 0 and -y ");
//     }
//     if (quarter == 4)
//     {
//         Console.WriteLine("coordinates between 0 and -x , 0 and -y ");
//     }
// }
// int message = Request("enter a number");
// FindCoordinates(message);




// Напишите программу, которая принимает на вход кординаты двух точек 
// и находит расстояние между ними в 2D пространстве. A(3.6); B(2.1); -> 5.09
// A(7,-5);B(1,-1)->7.21



// int PointRequest(string message)
// {
//     Console.WriteLine(message);
//     int PointCoordinate = int.Parse(Console.ReadLine());
//     return PointCoordinate;
// }

// double PointDistance(int x1, int y1, int x2, int y2)
// {
//     double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
//     return distance;
// }

// int x1 = PointRequest("Enter x1 coodinate : ");
// int y1 = PointRequest("Enter y1 coodinate : ");

// int x2 = PointRequest("Enter x2 coodinate : ");
// int y2 = PointRequest("Enter y2 coodinate : ");

// // double result = PointDistance(x1, y1, x2, y2);
// Console.WriteLine(PointDistance(x1, y1, x2, y2));





// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// Console.WriteLine("enter a number");
// Console.ReadLine();

// int i = 1;
// int n = 5;
// while (i < n)
// {
//     int square = i * i;
//     Console.WriteLine(square);
//     i = i + 1;

// }

// Console.WriteLine(square);


// int InputData(string message)
// {
//     Console.WriteLine(message);
//     int DigitVar = Math.Abs(int.Parse(Console.ReadLine())); // math.abs throws minus "-" from entered digit, int.parse converts string to integer
//     return DigitVar;
// }

// void SquareTable(int number)
// {
//     int i = 1;
//     while (i <= number)
//     {
//         double num = Math.Pow((i), 2);
//         Console.WriteLine(num);
//         i++;
//     }
// }
// int digit = InputData("Enter a digit : ");
// SquareTable(digit);









// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// here you should enter "string" operator, 
// int KeyInput(string Point)  // // because you entered a message in x,y,z variables - " Enter x1 coordinates : "
// {
//     Console.WriteLine(Point);
//     int PointCoordinate = int.Parse(Console.ReadLine());
//     return PointCoordinate;
// }

// double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     double PointDistance = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
//     return PointDistance;
// }

// int Point1x1 = KeyInput("Enter x1 coordinates : ");
// int Point1y1 = KeyInput("Enter y1 coordinates : ");
// int Point1z1 = KeyInput("Enter z1 coordinates : ");

// int Point2x2 = KeyInput("Enter x2 coordinates : ");
// int Point2y2 = KeyInput("Enter y2 coordinates : ");
// int Point2z2 = KeyInput("Enter z2 coordinates : ");

// Console.WriteLine(Distance(Point1x1, Point1y1, Point1z1, Point2x2, Point2y2, Point2z2));




// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// int DigitInput(string message)
// {
//     Console.WriteLine(message);
//     int Digit = Math.Abs(int.Parse(Console.ReadLine()));
//     // int Digit = int.Parse(Console.ReadLine());
//     return Digit;
// }

// void Cube(int num)
// {
//     int i = 1;
//     // int num = 0;
//     while (i < num)
//     {
//         double result = Math.Pow((i), 3);
//         Console.WriteLine(result);
//         i++;
//     }
// }
// int digit = DigitInput("Enter a number : ");
// Cube(digit);




// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом - одинаково читающееся в обоих направлениях.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


// to check if it's a palindrom

// string DigitInput(string inmessage)
// {
//     Console.WriteLine(inmessage);
//     // int inputmsg = Convert.ToInt32(Console.ReadLine());
//     string inputmsg = Console.ReadLine();
//     return inputmsg;
// }

// string DigiCheck(string digits)
// {
//     int check;
//     bool isdigits = int.TryParse(digits, out check);
//     Console.WriteLine("is the number digits :" + isdigits);
//     if (isdigits != true)
//     {
//         Console.WriteLine("the number is not a digits");

//     }
//     return digits;
// }

// void PaliCheck(string number)
// {
//     int index = 0;
//     int len = number.Length;
//     // int check;
//     // bool isdigits = int.TryParse(number, out check);
//     // Console.WriteLine("isdigits :" + isdigits);
//     if (len == 5)
//     // if ((len == 5) && (Convert.ToInt32( TryParse(number, out check)==true)))
//     // if ((len == 5) && isdigits == true)
//     {
//         // Console.WriteLine(number);
//         for (index = 0; index < len / 2; index++)
//             if (number[index] != number[len - index - 1])
//             {
//                 Console.WriteLine(" NO Palindrom");
//                 break;
//             }
//             else
//             {
//                 Console.WriteLine("This is a Palindrom");
//                 break;
//             }
//     }
//     else
//     {
//         Console.WriteLine("the number is not in correct diapason or uve entered Non-digits");
//     }
// }
// string num = DigitInput("Enter a symbols");
// DigiCheck(num);
// PaliCheck(Convert.ToString(num));





// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5



// string Input(string arg1)
// {
//     Console.WriteLine(arg1);
//     string input = Console.ReadLine();
//     return input;
// }

// void Digitquantity(string arg2)
// {
//     int len = arg2.Length;
//     Console.WriteLine("Digits quantity is : " + len);
// }

// string number = Input("Enter a number");
// Digitquantity(number);





// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


// int input(string arg1)
// {
//     Console.WriteLine(arg1);
//     // Console.WriteLine("enter a number");
//     int number = Math.Abs(int.Parse(Console.ReadLine()));
//     return number;
// }

// // int Check(int arg)
// // {
// //     if (arg == 0)
// //     {
// //         Console.WriteLine("You've entered a 0, result is 0");
// //         // break;

// //     }
// //     return arg;
// // }

// int MultipleOfN(int arg2)
// {
//     int sum = 1;
//     for (int i = 1; i <= arg2; i++)
//     {
//         if (arg2 == 0)
//         {
//             Console.WriteLine("You've entered a 0, result is 0");

//             break;
//         }
//         sum = sum * i;
//         // else
//         // {
//         // }
//     }
//     return sum;
// }

// int num = input("enter a number");

// // Check(num);
// // int num = input();
// Console.WriteLine($"The mutliplication of the digits of the number {num} is equals : {MultipleOfN(num)}");







// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16




// int input1()
// {
//     Console.WriteLine("enter a number1");
//     int number = Math.Abs(int.Parse(Console.ReadLine()));
//     // Console.WriteLine("enter a number2");
//     // int number2 = Math.Abs(int.Parse(Console.ReadLine()));
//     return number;
//     // return number2;
// }
// void PowOfDig(int arg1, int arg2)
// {

//     double result = Math.Pow((arg1), arg2);
//     Console.WriteLine($"the result of the powering operation is : {result}");

// }

// int power1 = input1();
// int power2 = input1();

// PowOfDig(power1, power2);





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// string Input()
// {
//     Console.WriteLine("Enter an Input");
//     string input = Console.ReadLine();
//     // int input = Math.Abs(int.Parse(Console.ReadLine()));
//     return input;
// }
// int DigiSum(string arg2)
// {
//     int index = 0;
//     int sum = 0;
//     int len = arg2.Length;
//     int parsed = Math.Abs(int.Parse(arg2));
//     while (index < len)
//     {
//         sum = sum + parsed % 10;
//         parsed = parsed / 10;
//         index++;
//         Console.WriteLine(parsed % 10);
//     }
//     Console.WriteLine(sum);
//     return sum;
// }
// string digisum = Input();
// DigiSum(digisum);




// string Input(string arg1)
// {
//     Console.WriteLine(arg1);
//     string keyinput = Console.ReadLine();
//     return keyinput;
// }

// void Digitquantity(string arg2)
// {
//     int len = arg2.Length;
//     int[] range = new int[len];

//     int sum = 0;
//     int index = 0;
//     // for (int i = 0; i < len; i++)
//     while (index < len)
//     {

//         range[index] = arg2[index];

//         // char n = arg2[i];

//         // sum = sum + arg2[i];
//         // sum+=arg2[i];
//         Console.WriteLine(range[index]);
//     }

//     // return range;

// }

// string number = Input("Enter a number");
// Digitquantity(number);





// int xa = 1, ya = 1, xb = 1, yb = 40, xc = 80, yc = 40;
// int x = xa, y = ya;
// int count = 0;
// while (count < 10000)
// {
//     int what = new Random().Next(0, 3);
//     if (what == 0)
//     {
//         x = (x + xa) / 2;
//         y = (y + ya) / 2;
//     }
//     if (what == 1)
//     {
//         x = (x + xb) / 2;
//         y = (y + yb) / 2;
//     }
//     if (what == 2)
//     {
//         x = (x + xc) / 2;
//         y = (y + yc) / 2;
//     }
//     Console.SetCursorPosition(x, y);
//     Console.WriteLine("+");
//     count++;
// }









// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }


// int a1 = 15;
// int b1 = 21;
// int c1 = 39;

// int a2 = 15;
// int b2 = 21;
// int c2 = 39;

// int a3 = 25;
// int b3 = 61;
// int c3 = 59;


// int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

// Console.WriteLine(max);



// int Number()
// {
//     Console.WriteLine("Enter find number");
//     int digit = int.Parse(Console.ReadLine());
//     // Console.WriteLine(digit);
//     return digit;
// }
// void Findnum(int arg1)
// {
//     Console.WriteLine("find number is " + arg1);
//     int[] array = { 11, 12, 13, 14, 15, 25, 61, 57, 81, 9 };
//     int index = 0;
//     int find = arg1; int len = array.Length;
//     while (index < len)
//     {
//         if (index == len - 1 && array[index] != find)
//         {
//             Console.WriteLine($"the : {find} is not present ");
//         }
//         else if (array[index] == find)
//         {
//             find = array[index];
//             Console.WriteLine("find is found  " + find);
//             break;
//         }
//         else if (array[index] != f-ind)
//         {
//             Console.WriteLine($"searching for the : {find}  in next position ");
//         }

//         else Console.WriteLine($"the : {find} is not present ");
//         index++;
//     }
//     // return find;
// }
// // int num = Number();

// int num = Number();

// Findnum(num);
// // Console.WriteLine("find number is present " + Findnum(num));


// int Number()
// {
//     Console.WriteLine("Enter find number");
//     int digit = int.Parse(Console.ReadLine());
//     // Console.WriteLine(digit);
//     return digit;
// }
// void FillupArray(int[] collection)
// {
//     int count = 0; int len = collection.Length;
//     while (count < len)
//     {
//         collection[count] = new Random().Next(1, 10);
//         count++;
//     }
// }

// void PrintArray(int[] myarray)
// {
//     int count = 0; int len = myarray.Length;
//     while (count < len)
//     {
//         Console.WriteLine(myarray[count]);
//         count++;
//     }
// }

// int IndexOf(int[] array, int find)
// {
//     int count = 0; int len = array.Length; int element = 0;
//     while (count < len)
//     {
//         if (array[count] == find)`
//         {
//             element = array[count];
//             break;
//             count++;
//         }
//     }
//     return element;
// }

// // int el = Number();

// int[] array = new int[10];
// FillupArray(array);
// PrintArray(array);
// int pos = IndexOf(array, 5);
// Console.WriteLine($"Now its find {pos}");




// To sort massive - from minto max & from max to min



// int[] array = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// void Selectionsort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)

//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] > array[minPosition]) minPosition = j;
//         }
//         int Temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = Temporary;
//     }
// }

// PrintArray(array);
// Selectionsort(array);
// PrintArray(array);


// To find max from 3 number

// Console.WriteLine("Enter a");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter b");
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter c");
// int c = int.Parse(Console.ReadLine());

// int max = a;

// if (b > max)
// {
//     max = b;
// }
// if (c > max)
// {
//     max = c;
// }
// Console.WriteLine(max);

//to find an even/odd  number

// Console.WriteLine("Enter a");
// int a = int.Parse(Console.ReadLine());
// if (a % 2 == 0)
// {
//     Console.WriteLine("even number");
// }
// else
// {
//     Console.WriteLine("odd number");
// }




// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// Console.WriteLine("Enter N");
// int n = int.Parse(Console.ReadLine());
// int count = 1;

// while (count <= n)
// {
//     if (count % 2 == 0)
//     {
//         Console.WriteLine(count);
//     }
//     count++;
// }




// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.WriteLine("Enter Number");
// var n = Math.Abs(Convert.ToInt64(Console.ReadLine()));

// // if (n > 100 && n < 999)
// // {
// while (n > 100)
// {
//     n = (n / 10);
// }

// }

// Console.WriteLine(n % 10);



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


// int check = 0;
// Console.WriteLine("Enter Number");
// var n = Math.Abs(Convert.ToInt64(Console.ReadLine()));
// bool isdigits = int.TryParse(n, out check);

// if (n <= 99)
// {
//     Console.WriteLine("No 3rd digit");
// }
// while (n > 99)
// {
//     if (n > 99 && n < 999)
//     {
//         Console.WriteLine(n % 10);
//         // n = (n % 10);
//     }
//     n = n / 10;
// }







// else Console.WriteLine("no 3rd digit");








// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет





// Задача №21. Работа в группах
// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
// ● A (3,6); B (2,1) -> 5,09
// ● A (7,-5); B (1,-1) -> 7,21


// int Input(string message)
// {
//     Console.WriteLine(message);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }

// double FindDistance(int x1, int y1, int x2, int y2)
// {
//     double distance = Math.Round(Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2))), 5);
//     return distance;
// }


// int x1 = Input("enter x1");
// int y1 = Input("enter y1");
// int x2 = Input("enter x2");
// int y2 = Input("enter y2");

// Console.WriteLine(FindDistance(x1, y1, x2, y2));





// Задача 21: Напишите программу, которая принимает
// на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53




// int Input(string message)
// {
//     Console.WriteLine(message);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }
// double FindDistance(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     double distance = Math.Round(Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2) + (Math.Pow((z2 - z1), 2)))), 5);
//     return distance;
// }
// int x1 = Input("enter x1");
// int y1 = Input("enter y1");
// int z1 = Input("enter z1");
// int x2 = Input("enter x2");
// int y2 = Input("enter y2");
// int z2 = Input("enter z2");
// Console.WriteLine(FindDistance(x1, y1, z1, x2, y2, z2));



// Задача №22. Работа в группах
// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// ● 5 -> 1, 4, 9, 16, 25.
// ● 2 -> 1,4



// int Input(string message)
// {
//     Console.WriteLine(message);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }
// void SquareTable(int arg1)
// {
//     int a = 1;
//     while (a <= arg1)
//     {
//         Console.WriteLine("square of digit  " + a);
//         int square = a * a;
//         Console.WriteLine(square);
//         a++;
//     }
//     // return a;
// }

// int squarenumber = Input("enter a number for square");
// // Console.WriteLine(SquareTable(squarenumber));
// SquareTable(squarenumber);




//new exercises130722
//start new program


// int input(string message)
// {
//     Console.WriteLine(message);
//     int result = int.Parse(Console.ReadLine());
//     return result;
// }
// void NumberCheck(int arg1)
// {
//     if (arg1 %2==0)
//     {
//         Console.WriteLine("the number is even");
//     }
//     else 
//     {
//         Console.WriteLine("the number is odd");
//     }
// }
// int numcheck=input("enter a number");
// NumberCheck(numcheck);


// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125



// int Input(string message)
// {
//     Console.WriteLine(message);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }
// void CubeTable(int arg1)
// {
//     int a = 1;
//     while (a <= arg1)
//     {
//         Console.WriteLine("cube of digit  " + a);
//         double square = Math.Pow((a), 3);
//         Console.WriteLine(square);
//         a++;
//     }
// }
// int cubenumber = Input("enter a number for cube");
// CubeTable(cubenumber);





// Задача 19: Напишите программу, которая принимает
// на вход пятизначное число и проверяет, является ли
// оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да


// string Input(string message)
// {
//     Console.WriteLine(message);
//     string result = Console.ReadLine();
//     return result;
// }

// string Digicheck(string arg1)
// {
//     int len = arg1.Length;
//     bool palicheck = true; ;
//     for (int index = 0; index < len / 2; index++)
//     {
//         palicheck = (arg1[index] == arg1[len - index - 1]);
//     }
//     if (palicheck == true)
//     {
//         Console.WriteLine("Palindrom");
//     }
//     else if (palicheck == false)
//     {
//         Console.WriteLine("No palindrom");
//     }
//     return arg1;
// }
// string number = Input("enter a symbols");
// Console.WriteLine("Entered symbols is  ");
// Console.WriteLine(Digicheck(number));






// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// int Input(string message)
// {
//     Console.WriteLine(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// double DistFind(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     double distance = Math.Round(Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)) + (Math.Pow(z2 - z1, 2))), 3);
//     return distance;
// }

// int x1 = Input("enter x1");
// int y1 = Input("enter y1");
// int z1 = Input("enter z1");
// int x2 = Input("enter x2");
// int y2 = Input("enter y2");
// int z2 = Input("enter z2");

// Console.WriteLine(DistFind(x1, y1, z1, x2, y2, z2));






// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// int Input(string message)
// {
//     Console.WriteLine(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }
// void CubeTable(int arg1)
// {
//     int first = 1;
//     while (first <= arg1)
//     {
//         double cube = Math.Pow((first), 3);
//         Console.WriteLine(cube);

//         first++;
//     }
// }
// int number = Input("enter a number");
// CubeTable(number);




// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


// int Input(string message)
// {
//     Console.WriteLine(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// double PowDigit(int arg1, int arg2)
// {
//     double result = Math.Pow((arg1), arg2);
//     return result;
// }

// int digit1 = Input("enter 1st number");
// int digit2 = Input("enter 2nd number");
// Console.WriteLine(PowDigit(digit1, digit2));


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


// string Input(string message)
// {
//     Console.WriteLine(message);
//     string result = Console.ReadLine();
//     return result;
// }

// int DigitSum(string arg1)
// {
//     int numbers = int.Parse(arg1);
//     int len = arg1.Length;
//     int index = 0;
//     int sum = 0;
//     // char sum;
//     while (index < len)
//     {
//         // Console.WriteLine(arg1[index]);
//         // char tempsum = arg1[index];
//         // Console.WriteLine("tempsum " + tempsum);
//         // decimal digit = Convert.ToDecimal(tempsum);
//         // Console.WriteLine("digit " + digit);

//         // sum = sum + digit;
//         // // sum = sum + tempsum;
//         // int lastdigit = numbers % 10;
//         // sum = sum + lastdigit;
//         sum = sum + (numbers % 10);
//         Console.WriteLine("numbers" + numbers % 10);
//         Console.WriteLine("sum  " + sum);
//         numbers = numbers / 10;
//         index++;
//     }
//     return sum;
// }

// string number = Input("enter a number");
// Console.WriteLine($"Sum of the digits of the {number} is   {DigitSum(number)}");





// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 4, 76, 3 -> [1, 2, 5, 7, 19,4,76,3]

// 6, 1, 33, 43, 12, 3 ,2, 9 -> [6, 1, 33,43,12,3,2,9]

// void FillArray(int[] arr)
// {
//     // int index = 0;
//     // int[] arr = new int[15];
//     // int[] arr(10);
//     // int len = arr.Length;
//     // string arr;
//     for (int index = 0; index < arr.Length; index++)
//         arr[index] = new Random().Next(1, 100);
//     //    new Random().Next(1, 10);
//     // return arr[];
// }
// void PrintArray(int[] arr)
// {
//     int len = arr.Length;
//     for (int index = 0; index < len; index++)
//     {
//         Console.Write($"{arr[index]} ,  ");
//     }
// }
// int[] numbers = new int[15];
// FillArray(numbers);
// PrintArray(numbers);
// Console.WriteLine();



// int IndexOf(int[] array1, int find)
// {
//     int size = array1.Length;
//     int index = 0;
//     int numberposition = -1;

//     while (index < size)
//     {
//         if (array1[index] == find)
//         {
//             numberposition = index;
//             break;
//         }
//         index++;
//     }
//     return numberposition;
// }

// int[] numbers = new int[15];
// FillArray(numbers);
// PrintArray(numbers);
// // Console.WriteLine();
// int pos = IndexOf(numbers, find);
// Console.WriteLine();
// Console.WriteLine("number's index is " + pos);
// Console.WriteLine("the find is " + find);



// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// void FillArray(int[] arr, int arrlength)
// {
//     int index = 0;
//     int len = arrlength;
//     for (index = 0; index < arrlength; index++)
//         arr[index] = new Random().Next(0, 2);
// }
// void PrintArray(int[] arr)
// {
//     int len = arr.Length;
//     for (int index = 0; index < len; index++)
//     {
//         Console.Write($"{arr[index]} ,  ");
//     }
// }
// Console.WriteLine("Enter array's length");
// int arrlength = int.Parse(Console.ReadLine());
// int[] numbers = new int[arrlength];
// FillArray(numbers, arrlength);
// PrintArray(numbers);
// Console.WriteLine();




// Урок 5. Функции и одномерные массивы
// 
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



// void FillArray(int[] arr, int arg2)
// {
//     for (int index = 0; index < arr.Length; index++)
//     {
//         arr[index] = new Random().Next(100, 1001);
//     }
// }

// void EvenDigits(int[] arr)
// {
//     int sum = 0;
//     for (int index = 0; index < arr.Length; index++)
//     {
//         // Console.WriteLine(arr[index]);
//         Console.Write($"{arr[index]} ,  ");

//         if (arr[index] % 2 == 0)
//             sum = sum + 1;
//     }
//     Console.WriteLine();
//     Console.WriteLine($"the sum of even elements is = {sum} ");
// }

// Console.WriteLine("enter array's length");
// int arrlength = int.Parse(Console.ReadLine());
// int[] array = new int[arrlength];

// FillArray(array, arrlength);
// EvenDigits(array);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// void FillArray(int[] arr, int arg2)
// {
//     for (int index = 0; index < arr.Length; index++)
//     {
//         arr[index] = new Random().Next(0, 99);
//     }
// }

// void PrintArray(int[] arr)
// {
//     for (int index = 0; index < arr.Length; index++)
//     {
//         Console.Write($" {arr[index]} , ");
//     }
// }

// void OddSum(int[] arr)
// {
//     int sum = 0;

//     for (int index = 0; index < arr.Length; index++)
//     {
//         if (index % 2 != 0)
//         {
//             sum = sum + arr[index];
//         }
//     }
//     Console.WriteLine($"sum {sum} ");
// }

// Console.WriteLine("enter array's length");
// int arrlength = int.Parse(Console.ReadLine());
// int[] array = new int[arrlength];

// FillArray(array, arrlength);
// PrintArray(array);
// Console.WriteLine();
// OddSum(array);



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


// void FillArray(int[] arr, int arg2)
// {
//     for (int index = 0; index < arr.Length; index++)
//     {
//         arr[index] = new Random().Next(0, 99);
//     }
// }

// void PrintArray(int[] arr)
// {
//     for (int index = 0; index < arr.Length; index++)
//     {
//         Console.Write($" {arr[index]} , ");
//         // Console.WriteLine();

//     }

// }


// void MaxMinDiffer(int[] arr)
// {
//     int max = arr[0];
//     int min = arr[0];

//     for (int index = 0; index < arr.Length; index++)
//     {
//         // max = arr[0];
//         // min = arr[0];

//         if (arr[index] > max)
//             max = arr[index];
//         if (arr[index] < min)
//             min = arr[index];
//     }

//     int differ = max - min;
//     Console.WriteLine($"  max is {max} ");
//     Console.WriteLine($"  min is {min} ");

//     Console.WriteLine($"  Diffenrence is {differ} ");

// }


// Console.WriteLine("enter array's length");
// int arrlength = int.Parse(Console.ReadLine());
// int[] array = new int[arrlength];

// FillArray(array, arrlength);
// PrintArray(array);
// Console.WriteLine();
// MaxMinDiffer(array);











