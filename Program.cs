// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//*******************************
//РАБОЧИЙ СПОСОБ!!!!///
//*******************************

// Console.WriteLine("Введите пятизначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// int One = (num/10000)%10;//первое
// int Two = (num/1000)%10;//второе
// int Three = (num/100)%10;//третье
// int Four = (num/10)%10;//четвертое
// int Five = num%10;// последнее число

// // Console.WriteLine(One);
// // Console.WriteLine(Two);
// // Console.WriteLine(Three);
// // Console.WriteLine(Four);
// // Console.WriteLine(Five);

// if(One == Five)
// {
//     if(Two == Four)
//     {
//         Console.WriteLine("Это палиндром!");
//     }
//     else
//     {
//         Console.WriteLine("Это не палиндром");
//     }
// }
// else
// {
// Console.WriteLine("Это не палиндром");
// }

//*******************************
//НЕ РАБОЧИЙ СПОСОБ!!!!///
//*******************************
// int[] arr = {};
// int index = 0;
// int Size = 5;
// Console.WriteLine("Введите пятизначное число");
// arr[index] = Convert.ToInt32(Console.ReadLine());


// while(index < Size)
// {
//     if(arr[index] == arr[Size])
//     {
//         Size--;
//         index++;
//     }
//     else
//     {
//         Console.WriteLine("Это не палиндром");
//     }

// }
// Console.WriteLine("Это палиндром!");


//********************************************************************************************************************************************///


// // Задача 21
// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите X1 ");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите X2 ");
// int X2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите Y1 ");
// int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y2 ");
// int Y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите Z1 ");
// int Z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Z2 ");
// int Z2 = Convert.ToInt32(Console.ReadLine());

// double  d = Math.Sqrt(Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2) + Math.Pow((Z2-Z1),2));//теорема пифагора
// d = Math.Round(d,2); // округление до 2х знаков после запятой
// Console.WriteLine(d);


///*************************************************************************************************************************************************************////


// // Задача 23

// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());

// for(int i=1; i<=num; i++)
// {
//     Console.WriteLine("результат "+Math.Pow(i,3));   
// }
