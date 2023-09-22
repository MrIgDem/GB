// // // // // // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// // // // // // Например, даны 2 матрицы:
// // // // // // 2 4 | 3 4
// // // // // // 3 2 | 3 3
// // // // // // Результирующая матрица будет:
// // // // // // 18 20
// // // // // // 15 18

// // // // // using System;

// // // // // class Program
// // // // // {
// // // // //     static void Main()
// // // // //     {
// // // // //         // Задайте две матрицы
// // // // //         int[,] matrix1 = {
// // // // //             {2, 4},
// // // // //             {3, 2}
// // // // //         };

// // // // //         int[,] matrix2 = {
// // // // //             {3, 4},
// // // // //             {3, 3}
// // // // //         };

// // // // //         // Выполните умножение матриц
// // // // //         int[,] result = MultiplyMatrices(matrix1, matrix2);

// // // // //         // Выведите результат
// // // // //         Console.WriteLine("Результирующая матрица:");
// // // // //         for (int i = 0; i < result.GetLength(0); i++)
// // // // //         {
// // // // //             for (int j = 0; j < result.GetLength(1); j++)
// // // // //             {
// // // // //                 Console.Write(result[i, j] + " ");
// // // // //             }
// // // // //             Console.WriteLine();
// // // // //         }
// // // // //     }

// // // // //     // Функция для умножения двух матриц
// // // // //     static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
// // // // //     {
// // // // //         // Проверка, что матрицы можно умножить
// // // // //         if (matrix1.GetLength(1) != matrix2.GetLength(0))
// // // // //         {
// // // // //             Console.WriteLine("Умножение невозможно. Количество столбцов первой матрицы не соответствует количеству строк второй матрицы.");
// // // // //             return null;
// // // // //         }

// // // // //         int rows1 = matrix1.GetLength(0);
// // // // //         int cols1 = matrix1.GetLength(1);
// // // // //         int cols2 = matrix2.GetLength(1);

// // // // //         // Инициализация результирующей матрицы
// // // // //         int[,] result = new int[rows1, cols2];

// // // // //         // Выполнение умножения матриц
// // // // //         for (int i = 0; i < rows1; i++)
// // // // //         {
// // // // //             for (int j = 0; j < cols2; j++)
// // // // //             {
// // // // //                 for (int k = 0; k < cols1; k++)
// // // // //                 {
// // // // //                     result[i, j] += matrix1[i, k] * matrix2[k, j];
// // // // //                 }
// // // // //             }
// // // // //         }

// // // // //         return result;
// // // // //     }
// // // // // }

// // // // Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// // // // Например, задан массив:
// // // // 1 4 7 2
// // // // 5 9 2 3
// // // // 8 4 2 4
// // // // 5 2 6 7
// // // // Наименьший элемент - 1, на выходе получим
// // // // следующий массив:
// // // // 9 2 3
// // // // 4 2 4
// // // // 2 6 7


// // // using System;

// // // class Program
// // // {
// // //     static void Main()
// // //     {
// // //         int[,] array = {
// // //             {1, 4, 7, 2},
// // //             {5, 9, 2, 3},
// // //             {8, 4, 2, 4},
// // //             {5, 2, 6, 7}
// // //         };


// // //         int minElement = array[0, 0];
// // //         int minRow = 0;
// // //         int minCol = 0;

// // //         for (int i = 0; i < array.GetLength(0); i++)
// // //         {
// // //             for (int j = 0; j < array.GetLength(1); j++)
// // //             {
// // //                 if (array[i, j] < minElement)
// // //                 {
// // //                     minElement = array[i, j];
// // //                     minRow = i;
// // //                     minCol = j;
// // //                 }
// // //             }
// // //         }

// // //         int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
// // //         int newRow = 0;

// // //         for (int i = 0; i < array.GetLength(0); i++)
// // //         {
// // //             if (i == minRow)
// // //                 continue;

// // //             int newCol = 0;

// // //             for (int j = 0; j < array.GetLength(1); j++)
// // //             {
// // //                 if (j == minCol)
// // //                     continue;

// // //                 result[newRow, newCol] = array[i, j];
// // //                 newCol++;
// // //             }

// // //             newRow++;
// // //         }

    
// // //         Console.WriteLine("Массив после удаления строки и столбца с минимальным элементом:");
// // //         for (int i = 0; i < result.GetLength(0); i++)
// // //         {
// // //             for (int j = 0; j < result.GetLength(1); j++)
// // //             {
// // //                 Console.Write(result[i, j] + " ");
// // //             }
// // //             Console.WriteLine();
// // //         }
// // //     }
// // // }


// // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// // Например, на выходе получается вот такой массив:
// // 01 02 03 04
// // 12 13 14 05
// // 11 16 15 06
// // 10 09 08 07

// using System;

// class Program
// {
//     static void Main()
//     {
//         int n = 4; // Размерность массива
//         int[,] spiralArray = new int[n, n];

//         int currentValue = 1;
//         int minRow = 0, minCol = 0;
//         int maxRow = n - 1, maxCol = n - 1;

//         while (currentValue <= n * n)
//         {
//             // Заполнение верхней горизонтальной строки слева направо
//             for (int i = minCol; i <= maxCol; i++)
//             {
//                 spiralArray[minRow, i] = currentValue;
//                 currentValue++;
//             }
//             minRow++;

//             // Заполнение правой вертикальной строки сверху вниз
//             for (int i = minRow; i <= maxRow; i++)
//             {
//                 spiralArray[i, maxCol] = currentValue;
//                 currentValue++;
//             }
//             maxCol--;

//             // Заполнение нижней горизонтальной строки справа налево
//             for (int i = maxCol; i >= minCol; i--)
//             {
//                 spiralArray[maxRow, i] = currentValue;
//                 currentValue++;
//             }
//             maxRow--;

//             // Заполнение левой вертикальной строки снизу вверх
//             for (int i = maxRow; i >= minRow; i--)
//             {
//                 spiralArray[i, minCol] = currentValue;
//                 currentValue++;
//             }
//             minCol++;
//         }

//         // Вывод массива на экран
//         for (int i = 0; i < n; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 Console.Write($"{spiralArray[i, j]:D2} ");
//             }
//             Console.WriteLine();
//         }
//     }
// }
