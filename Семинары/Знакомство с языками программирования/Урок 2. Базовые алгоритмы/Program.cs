// // Random rand = new Random();
// // int number = rand.Next(10, 100);

// // int a = number / 10;
// // int b = number % 10;

// // Console.WriteLine(number);

// // if (a > b)
// // {
// // Console.WriteLine("Максимальное число a = " + a);
// // }
// // else if (b > a)
// // {
// // Console.WriteLine("Максимальное число b = {0}", b);
// // }
// // else {
// // Console.WriteLine($"Все числы равны {a} = {b}");
// // }

// // Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// // Random rand = new Random();
// // int number = rand.Next(100, 1000);

// // int a = number / 100 % 10;
// // int b = number % 100 / 10;
// // int c = number % 100 % 10;

// // Console.Write(a);
// // Console.Write(b);
// // Console.WriteLine(c);

// // Console.WriteLine($"{a} {c}");


// // Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// // Console.WriteLine("Введите первое число:");
// // int number1 = Convert.ToInt32(Console.ReadLine());

// // Console.WriteLine("Введите второе число:");
// // int number2 = Convert.ToInt32(Console.ReadLine());

// // if (number1 / number2 == number2 || number2 / number1 == number1)
// // {
// //     Console.WriteLine("Да");
// // }
// // else
// // {
// //     Console.WriteLine("Нет");
// // }


// // Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. 
// // Если число 1 не кратно числу 2, то программа выводит остаток от деления.

// // 34, 5 -> не кратно, остаток 4
// // 16, 4 -> кратно

// // Console.WriteLine("Введите первое число:");
// // int num1 = Convert.ToInt32(Console.ReadLine());

// // Console.WriteLine("Введите второе число:");
// // int num2 = Convert.ToInt32(Console.ReadLine());

// // if (num1 * num1 == num2 || num2 * num2 == num1)
// // {
// //     Console.WriteLine("Кратно");
// // }
// // else
// // {
// //     Console.WriteLine($"Не кратно, остаток {num1 % num2}");
// // }


// // Задача №14.
// // Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// // 7 и 23.

// // 14 -> нет
// // 46 -> нет
// // 161 -> да


// Console.WriteLine("Введите первое число:");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if (num1 % 7 == 0 && num1 % 23 == 0)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }