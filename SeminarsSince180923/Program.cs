

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

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// string Input(string message)
// {
//     Console.WriteLine(message);
//     string input = Console.ReadLine();
//     return input;
// }
// int Check(string input)
// {
//     int number = 0;
//     int output;
//     bool check = int.TryParse(input, out output);
//     if (check != true)
//     {
//         Console.WriteLine("enter a  number");
//     }
//     else
//     {
//         number = int.Parse(input);
//     }
//     return number;
// }
// void CheckNumber(int number1, int number2)
// {
//     if (number1 > number2)
//     {
//         Console.WriteLine("the bigger number is  " + number1);
//     }
//     else if (number2 > number1)
//     {
//         Console.WriteLine("the bigger number is  " + number2);
//     }
//     else
//     {
//         Console.WriteLine("wrong input ");
//     }
// }
// Console.Clear();
// string number1 = Input("Enter 1st number");
// string number2 = Input("Enter 2nd number");
// int temp1 = Check(number1);
// int temp2 = Check(number2);
// CheckNumber(temp1, temp2);


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// string Input(string message)
// {
//     Console.WriteLine(message);
//     string input = Console.ReadLine();
//     return input;
// }
// int Check(string input)
// {
//     // int number = 0;
//     int output;
//     bool check = int.TryParse(input, out output);
//     if (check != true)
//     {
//         Console.WriteLine(" 1 wrong input , enter a  number" + output);
//     }
//     // else if (check == false && check != true && check != false)
//     // {
//     //     Console.WriteLine(" 1 wrong input , enter a  number");
//     // }
//     // else
//     // {
//     //     Console.WriteLine(" 2 wrong input , enter a  number");

//     // }
//     // else
//     // {
//     int number = Convert.ToInt32(int.Parse(input));
//     // Console.WriteLine(" the  number is " + number);
//     // }
//     return number;
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
//         Console.WriteLine("the numbers equals ");
//     }
//     else
//     {
//         Console.WriteLine("wrong input ");
//     }
// }
// Console.Clear();
// string number1 = Input("Enter 1st number");
// string number2 = Input("Enter 2nd number");
// string number3 = Input("Enter 3rd number");
// int temp1 = Check(number1);
// int temp2 = Check(number2);
// int temp3 = Check(number3);
// CheckNumber(temp1, temp2, temp3);






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

int Input(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    // int output;
    bool check = int.TryParse(input, out int output);
    if (check != true)
    {
        Console.WriteLine(" 1 wrong input , enter a  number" + output);
    }
    int number = Math.Abs(Convert.ToInt32((input)));
    return number;
}

void ShowNumber(int start, int number)
{
    while (start <= number)
    {
        if (start % 2 == 0)
        {
            Console.WriteLine("the next even number is " + start);
        }
        start++;
    }
}
Console.Clear();
int number1 = Input("enter 1st number");
int number2 = Input("enter 2nd number");
ShowNumber(number1, number2);
