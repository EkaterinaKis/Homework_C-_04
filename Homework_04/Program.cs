// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.Write("Введите число A: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.Write("Введите степень: ");
// int B = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Число {A} в степени {B}: {GetExpo(B)}");

// int GetExpo(int limit)
// {

//     int num = A;
//     for (int i = 1; i < limit; i++)
//     {
//         num = num * A;
//     }
//     return num;
// }  

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма цифр числа {num}: {GetSum(num)}");

// int GetSum(int limit)
// {
//     int number = 0;
//     for (int i = 0; limit > 0; i++)
//     {
//         int number2 = limit % 10;
//         number = number + number2;
//         limit = limit / 10;
//     }
//     return number;
// }

//Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.

// int[]array = FillArray(8);
// Console.WriteLine($"[{String.Join(", ", array)}]");

// int[] FillArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(0,1000);
//     }
//     return result;
// }

