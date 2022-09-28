// //Задача 47. Задайте двумерный массив размером m×n, 
// //заполненный случайными вещественными числами.

// void CreateRandom2dArray(double[,] array, int rows, int cols){   //функция создания массива вещественных чисел 
//     for(int i = 0; i<rows; i++){
//         for(int j = 0; j<cols; j++){
//             array[i,j] = (new Random().NextDouble()-new Random().NextDouble())*10; //делаем красиво, как в примере к Заданию
//         }
//     }
// }

// void Show2dArray(double[,] array){ //функция вывода
//     for(int i = 0; i<array.GetLength(0); i++){
//         for(int j = 0; j<array.GetLength(1); j++){
//             double temp = Math.Round(array[i, j], 1);
//             Console.Write(temp + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// double[,] array = new double[rows, cols];
// CreateRandom2dArray(array, rows, cols);
// Show2dArray(array);
// Console.WriteLine();


// //Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// //и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
//     int[,] array = new int[rows,cols];
//     for(int i = 0; i<rows; i++)
//         for(int j = 0; j<cols; j++)
//             array[i,j] = new Random().Next(min, max+1);
//     return array;
// }

// void Show2dArray(int[,] array){
//     for(int i = 0; i<array.GetLength(0); i++){
//         for(int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// void Position (int[,] array, int m, int n){ // ищем элемент по номеру
//     int result = 0;
//     if(m < array.GetLength(0) && n < array.GetLength(1)) {
//         result = array[m,n];
//         Console.Write($"Here it is : {result}");
//     }
//     else {
//         Console.Write("Error, no such coordinates");
//     }
// }

// Console.Write("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] array = CreateRandom2dArray(rows,cols,min,max);
// Show2dArray(array);

// Console.Write("Element coordinates: (remember, rows and columns are numbered from ZERO!");
// Console.WriteLine();
// Console.Write("Input element coordinate (row): ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input element coordinate (col): ");
// int n = Convert.ToInt32(Console.ReadLine());
// Position(array,m,n);
// Console.WriteLine();

// //Задача 52. Задайте двумерный массив из целых чисел. 
// //Найдите среднее арифметическое элементов в каждом столбце.

// int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
//     int[,] array = new int[rows,cols];
//     for(int i = 0; i<rows; i++)
//         for(int j = 0; j<cols; j++)
//             array[i,j] = new Random().Next(min, max+1);
//     return array;
// }

// void Show2dArray(int[,] array){
//     for(int i = 0; i<array.GetLength(0); i++){
//         for(int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// void Srednee(int[,] array, int a) {  //считаем среднее по колоннам
// for (int j = 0; j < array.GetLength(0); j++){
//     double srednee = 0;  
//     for (int i = 0; i < array.GetLength(1); i++)    {
//         srednee = (srednee + array[i, j]);
//     }
//     srednee = srednee / a;
//     Console.Write(srednee + "; ");
// }}

// Console.Write("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] array = CreateRandom2dArray(rows,cols,min,max);
// Show2dArray(array);
// Console.WriteLine();
// Srednee(array,cols);

