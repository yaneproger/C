




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

string InputAndCheck(string message)
{
    Console.WriteLine(message);
    string number = Console.ReadLine();
    while ((!int.TryParse(number, out int output)) || (output > 100000))
    {
        Console.WriteLine("InputAndCheck method check false - wrong input");
        break;
    }
    return number;
}

bool CheckPalindrom(string arg1)
{
    bool palicheck = false;

    if (arg1.Length == 5)
    {
        for (int index = 0; index < arg1.Length / 2; index++)
        {
            if (arg1[index] == arg1[arg1.Length - 1 - index])
            {
                Console.WriteLine($"the {arg1} is palindrom ");
                palicheck = true;
            }
            // else
            // {
            //     Console.WriteLine($"the {arg1} is No palindrom ");
            //     palicheck = false;
            // }
        }
    }
    else
    {
        Console.WriteLine($"CheckPalindrom method check false - enter 5 digit number ");
    }
    return palicheck;
}

void Result(bool arg1)
{
    if (arg1 == true)
    {
        Console.WriteLine($"entered symbols return - {arg1}-  is palindrom ");
    }
    else
    {
        Console.WriteLine($"entered symbols return - {arg1} - is No palindrom ");
    }

}

Console.Clear();
string number = InputAndCheck("Введите число");
bool check = CheckPalindrom(number);
Result(check);

//
//
//
// from 100


