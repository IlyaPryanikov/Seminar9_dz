int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
    int[,] array = new int[rows,cols];
    for(int i = 0; i<rows; i++)
        for(int j = 0; j<cols; j++)
            array[i,j] = new Random().Next(min, max+1);
    return array;
}

void Show2dArray(int[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}


// // Задача 54: Задайте двумерный массив. 
// // Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


// int [,] SortRowDescendingOrder(int[,] array){
//     for (int i=0;i<array.GetLength(0);i++){
//         for (int j=0;j<array.GetLength(1);j++){
//             for (int k = 0; k < array.GetLength(1) - 1; k++){
//                 if (array[i, k] < array[i, k + 1])
//                     {
//                         int temp = array[i, k+1];
//                         array[i, k + 1] = array[i, k];
//                         array[i, k] = temp;
//                 }
//             }
//         }
//     }
//     return array;
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
// Console.WriteLine();
// int [,] array2 = SortRowDescendingOrder(array);
// Show2dArray(array2);


// // Задача 56: Задайте прямоугольный двумерный массив. 
// // Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.Write("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" ");
// int[,] array = CreateRandom2dArray(rows,cols,min,max);
// Show2dArray(array);
// Console.WriteLine();

// int result = 1, a = 0, b = 0;
// for(int i =0; i < rows; i++){
//     for(int j =0; j < cols; j++) {
//         if(i==0)
//         {
//             b = b + array[i, j];
//             a = b;
//         }
//         else{ b = b + array[i, j];}
//     }
//     if(a > b) {
//         result = i+1;
//         a = b;
//         b = 0;
//     }
//     b = 0;
// }
// Console.Write("Cтрока с наименьшей суммой элементов: " + result);



// // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// int n = 4;
// int[,] sqareMatrix = new int[n, n];

// int temp = 1, i = 0, j = 0;

// while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
// {
//   sqareMatrix[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)  {
//     for (int j = 0; j < array.GetLength(1); j++)  {
//       if (array[i,j] / 10 <= 0)
//       Console.Write($" {array[i,j]}");

//      else Console.Write($" {array[i,j]}");
//     }
//     Console.WriteLine();
//   }
// }

// WriteArray(sqareMatrix);