Console.Clear();

// int[] array = new int[2];

// Console.WriteLine("Введите координаты Х и У");

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }

// if (array[0] > 0 && array[1] > 0)
// {
//     Console.WriteLine("Первая четверть");
// }
// else if (array[0] < 0 && array[1] > 0)
// {
//     Console.WriteLine("Вторая четверть");
// }
// else if (array[0] < 0 && array[1] < 0)
// {
//     Console.WriteLine("Третья четверть");
// }
// else if (array[0] > 0 && array[1] < 0)
// {
//     Console.WriteLine("Четвёёртая четверть");
// }

//--------------------------------------------------------------------------------

// Console.WriteLine("Введите N");
// int num1 = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= num1; i++)
// {
//     int count = i * i;
//     Console.Write($"{count} ");
// }


//------------------------------------------------------------------------------
// Console.WriteLine("Введите x1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y1");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите x2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y2");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Pow(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2), 0.5);
// Console.WriteLine(d);

---------------------------------------------------------------------
// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

using System;

public class Answer
{
    static bool IsPalindrome(int number){
      // Введите свое решение ниже
      if(number < 10000 || number > 10000)
      {
        Console.WriteLine("Число не пятизначное");
        return false;
      }

      string numberStr = number.ToString();

      for (int i = 0; i < numberStr.Length / 2; i++)
        {
            if (numberStr[i] != numberStr[numberStr.Length - 1 - i])
            {                  
                return false;
            }
        }

        return true;
      
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}