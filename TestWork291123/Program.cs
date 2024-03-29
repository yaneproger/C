﻿






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






// Console.WriteLine("Enter rows number");
// int rows = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter colums number");
// int columns = int.Parse(Console.ReadLine());

// string[,] FillArray(int rows, int columns)
// {
//     string[,] array = new string[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         Console.WriteLine("1st row");
//         for (int j = 0; j < columns; j++)
//         {
//             Console.WriteLine("Enter massive's element");
//             array[i, j] = Console.ReadLine()!;
//         }
//         Console.WriteLine();
//         Console.WriteLine("next row");
//     }
//     return array;
// }

// void PrintArray(string[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine($" Номер строки {i}");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($" элемент-{i},{j}- {array[i, j]}");
//         }
//         Console.WriteLine();
//     }
// }

// int ElementCount(string[,] array)
// {
//     int arraysize = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j].Length <= 3)
//             {
//                 arraysize = arraysize + 1;
//             }
//         }
//     }
//     Console.WriteLine($"newarraysize is {arraysize} elements");
//     return arraysize;
// }

// void ChangedArray(string[,] array, int arraysize)
// {
//     string[] newarray = new string[arraysize];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j].Length <= 3)
//             {
//                 newarray[i] = array[i, j];
//                 Console.Write($"[{newarray[i]}]");
//             }
//         }
//     }
// }

// Console.Clear();
// string[,] newarray = FillArray(rows, columns);
// PrintArray(newarray);
// int newarraysize = ElementCount(newarray);
// Console.WriteLine("newarray");
// ChangedArray(newarray, newarraysize);
// Console.WriteLine();

