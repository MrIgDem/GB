Console.Clear();

// int[] array = new int[12];
// int sumPositive = 0;
// int sumNegative = 0;

// FillArray(array);

// foreach (int number in array)
// {
//     if (number > 0)
//     {
//         sumPositive += number;
//     }
//     else
//     {
//         sumNegative += number;
//     }
// }

// Console.WriteLine($"Сумма положительных {sumPositive} сумма отрицательных {sumNegative}");


// void FillArray(int[] array) {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//     }
//     Console.WriteLine(String.Join(" ", array));
// }
//------------------------------------------------------------------------
// int[] array = new int[12];

// void FillArray(int[] array) {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//     }
//     Console.WriteLine(String.Join(" ", array));
// }
// FillArray(array);

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] *= -1;
// }

// Console.WriteLine(String.Join(" ", array));

//---------------------------------------------------------------------------------
int num1 = Convert.ToInt32(Console.ReadLine());
int[] array = new int[12];

void FillArray(int[] array) {
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    Console.WriteLine(String.Join(" ", array));
}
FillArray(array);

bool ArraySearch(int[] array, int num1)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (num1 == array[i])
        {
            return true;
        }
    }
    return false;
}

bool search = ArraySearch(array, num1);
Console.WriteLine(search);