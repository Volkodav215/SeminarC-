﻿// // Задача 47. Задайте двумерный массив размером m×n,
// // заполненный случайными вещественными числами.
// // m = 3, n = 4.

// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9

// Console.WriteLine("Введите число строк!");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов!");
// int columns = Convert.ToInt32(Console.ReadLine());

// double [,] arr = new double [rows,columns];

// for (int i = 0; i < arr.GetLength(0)/*rows*/; i++)
// {
//     for (int j = 0; j < arr.GetLength(1)/*columns*/; j++)
//     {
//        arr[i,j] = new Random().NextDouble()*100;
//        Console.Write("{0:0.00}",arr[i,j]); // если добавить пробел через + в эту же строку, то не работает маска почему то!?
//        Console.Write(" ");                 // поэтому пробел отдельно вывел
//     }
//     Console.WriteLine();
// }

///***********************************************************************************************************************************************///

// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// // и возвращает значение этого элемента или же указание, что такого элемента нет.

// // Например, задан массив:

// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4

// // 17 -> такого числа в массиве нет

// int [,] arr = new int [3,4];

// for (int i = 0; i < arr.GetLength(0)/*rows*/; i++)
// {
//     for (int j = 0; j < arr.GetLength(1)/*columns*/; j++)
//     {
//         arr[i,j] = new Random().Next(0,10);
//         Console.Write(arr[i,j]+ " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Введите позицию элемента в столбце! от 0 до 2");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите позицию элемента в строке! от 0 до 3");
// int columns = Convert.ToInt32(Console.ReadLine());

// if(rows< arr.GetLength(0) && columns< arr.GetLength(1))
// {
//     Console.Write("Искомый элемент - "+arr[rows,columns]+ " ");
// }
// else
// {
//     Console.WriteLine("Такого элемента нет!");
// }


///***********************************************************************************************************************************************///

// // Задача 52. Задайте двумерный массив из целых чисел.
// // Найдите среднее арифметическое элементов в каждом столбце.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// // Console.WriteLine("Введите число строк!");
// // int rows = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Введите число столбцов!");
// // int columns = Convert.ToInt32(Console.ReadLine());

// int [,] arr = new int [3,3];
// int temp = 0;
// double MidSum = temp/3;
// int i,j;
// for (j = 0; j < arr.GetLength(0)/*rows*/; j++)
// {
//     for (i = 0; i < arr.GetLength(1)/*columns*/; i++)
//     {
//         arr[i,j] = new Random().Next(0,10);
//         Console.Write(arr[i,j]+ " ");
//         temp = temp + arr[i,j];
//     }
//     Console.WriteLine("mid sum "+temp/3+","+temp%3);
//     temp=0;
//     Console.WriteLine();
// }

