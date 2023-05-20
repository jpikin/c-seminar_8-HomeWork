// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// void BubbleSort(int[] arr)
//         {
//             for (int i = 0; i < arr.Length; i++)
//                 for (int j = 0; j < arr.Length - i - 1; j++)
//                 {
//                     if (arr[j] < arr[j + 1])
//                     {
//                         int temp = arr[j];
//                         arr[j] = arr[j + 1];
//                         arr[j + 1] = temp;
//                     }
//                 }
//         }

// int [,] GetArray(int num, int column)
// {
//     int [,] arr = new int[num,column];
//     return arr;
// }

// int GetRandom()
// {
//     return new Random().Next(1, 20);
// }

// int [,] FillArray(int [,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i,j] = GetRandom();
//         }
//     }
//     return arr;
// }

// int [,] SortArray(int [,] arr)
//     {
//         int [] tempArray = new int[arr.GetLength(1)];
//         for (int i = 0; i < arr.GetLength(0); i++)
//         {
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 tempArray[j] = arr[i,j];    
//             }
//             BubbleSort(tempArray);
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 arr[i,j] = tempArray[j];    
//             }    
//         }
//         return arr;
//     }

// void PrintArray(int [,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i,j] + "    ");
//         }
//     Console.WriteLine(); 
//     }   
// }

// int [,] array = GetArray(3, 4);
// FillArray(array);
// SortArray(array);
// PrintArray(array);


// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int GetMinStringSum(int [,] arr)
// {
//     int [] tempArray = new int[arr.GetLength(0)];
//     int sum = 0;
//     int index = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             sum += arr[i,j];    
//         }
//         tempArray[i] = sum;
//         sum = 0;
//     }
//     sum = tempArray[0];
//     for (int i = 1; i < tempArray.Length; i++)
//         {
//             if (sum > tempArray[i])
//             {
//                 sum = tempArray[i];
//                 index = i;
//             }            
//         }   
//     return index;
// }

// int [,] GetArray(int num, int column)
// {
//     int [,] arr = new int[num,column];
//     return arr;
// }

// int GetRandom()
// {
//     return new Random().Next(1, 9);
// }

// int [,] FillArray(int [,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i,j] = GetRandom();
//         }
//     }
//     return arr;
// }

// void PrintResult(int [,] arr)
// {
//     Console.WriteLine($"Строка {GetMinStringSum(arr)}"); 
// }

// void PrintArray(int [,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i,j] + "    ");
//         }
//     Console.WriteLine(); 
//     }   
// }

// int [,] array = GetArray(3, 4);
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// PrintResult(array);


// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int [,] GetArray(int num, int column)
// {
//     int [,] arr = new int[num,column];
//     return arr;
// }

// int [,] FillArray(int [,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i,j] = new Random().Next(1, 9);
//         }
//     }
//     return arr;
// }

// void FindResult(int [,] arr1, int [,] arr2)
// {
//     if (arr1.GetLength(0) != arr2.GetLength(1))
//     {
//         Console.WriteLine("Умножение матриц невозможно");
//     }
//     else
//     {
//         MatrixMultiplication(arr1, arr2);
//     }
// }

// void MatrixMultiplication(int [,] array1, int [,] array2)
// {
//     int [,] arrayResult = new int [array1.GetLength(0),array2.GetLength(1)];
//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             for (int k = 0; k < array1.GetLength(1); k++)
//             {
//                 arrayResult[i, j] += array1[i, k] * array2[k, j];
//             }
//         }
//     }
//     PrintArray(arrayResult); 
// }

// void PrintArray(int [,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i,j] + "    ");
//         }
//     Console.WriteLine(); 
//     }
//     Console.WriteLine();   
// }

// int [,] matrix1 = GetArray(2,2),
//         matrix2 = GetArray(2,2);
        
// FillArray(matrix1);
// PrintArray(matrix1);
// FillArray(matrix2);
// PrintArray(matrix2);
// FindResult(matrix1, matrix2);



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int [,,] GetRandomArray()
// {
//     int a = new Random().Next(3, 5),
//         b = new Random().Next(3, 5),
//         c = new Random().Next(3, 5);
//     int [,,] arr = new int[a,b,c];
//     return arr;
// }

// int [,,] FillArray(int[,,] arr)
// {
//     List<int> lst = new List<int>(arr.GetLength(0)*arr.GetLength(1)*arr.GetLength(2)){0};
//     int temp = 0;
    
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 while (lst.Contains(temp))
//                     {
//                         temp = new Random().Next(10, 100);
//                     }
//                 lst.Add(temp);
//                 arr[i,j,k] = temp;
//             }
//         }
//     }
//     return arr;
// }
// void PrintResult(int [,,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 Console.Write($"{arr[i,j,k]}({i},{j},{k}) "); 
//             }
//             Console.WriteLine();
//         }
//     }
// }
// int [,,] array = GetRandomArray();
// FillArray(array);
// PrintResult(array);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
