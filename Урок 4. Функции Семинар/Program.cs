Console.Clear();
// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// int count = 0;

// int getNumber()
// {
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// int countElements(int number)
// {
//     if(number < 0)
//     {
//         number = number * -1;
//     }
    
//     while(number > 0)
//     {
//         number = number / 10;
//         count++;
//     }
//     return count;
// }

// int num1 = getNumber();
// int sum = countElements(num1);
// Console.WriteLine(sum);



// int Print(string text)
// {
// Console.WriteLine(text);
// int number = Convert.ToInt32(Console.ReadLine());
// return number;
// }
// static int DigitsNumber (int value){
// if (value < 0)
// {
// value = -value;
// }

// string number = value.ToString();
// return number.Length;
// }
// int number = Print("Введите число");

// Console.WriteLine(DigitsNumber(number));

//--------------------------------------------------------------

// Задача № 30

// int[] array = new int[8];

// void FillArray(int[] array)
// {
//     int length = array.Length;
//     Random random = new Random(); // Создаем объект Random один раз.
    
//     for (int index = 0; index < length; index++)
//     {
//         array[index] = random.Next(0, 2);
//     }
// }

// FillArray(array); // Вызываем функцию для заполнения массива.

// // Выводим элементы массива поочередно.
// foreach (int element in array)
// {
//     Console.Write(element);
// }

//--------------------------------------------------------------------------------

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int count = 1;
for (int i = 0; i < num2; i++)
{
    count = count * num1;
    
}

Console.WriteLine(count);