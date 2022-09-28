// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве

// int[] CreateRandomArray(int size){  //функция массив из трехзначных чисел
//     int[] array = new int[size];
//     for (int i=0; i<size; i++){
//         array[i] = new Random().Next(100,1000);
//     }
//     return array;
// }

// void ShowArray(int[] array){   //функция вывода массива
//     for (int i=0; i<array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }

// int Chetnost(int[] array){  //функция проверки четности (остаток от деления на 2 равно 0)
//     int count=0;
//     for (int i=0; i<array.Length;i++){
//         if (array[i]%2 == 0) {
//             count++;}
//     }
//     return count;
// }

// Console.Write("Input size : ");  //задаем размер массива
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray3(size);
// ShowArray(array); //вывод массива

// int counter = Chetnost(array);
// Console.WriteLine();
// Console.WriteLine($"Number of even numbers :{counter}"); //считаем и выводим четные


// //Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// // Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreateRandomArray(int size){  //функция массив рандом
//     int[] array = new int[size];
//     for (int i=0; i<size; i++){
//         array[i] = new Random().Next(1,100);
//     }
//     return array;
// }

// void ShowArray(int[] array){   //функция вывода массива
//     for (int i=0; i<array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }

// int SummaElNechet(int[] array){  //функция проверки нечетности элемента, сумма
//     int count=0;
//     for (int i=0; i<array.Length;i++){
//         if (i%2 > 0) {
//             count=count+array[i];}
//     }
//     return count;
// }

// Console.Write("Input size : ");  //задаем размер массива
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(size);
// ShowArray(array); //вывод массива

// int counter = SummaElNechet(array);
// Console.WriteLine();
// Console.WriteLine($"Summ of odd array elements :{counter}"); //считаем и выводим сумму нечетных (начиная с 1-го)


// //Задача 38: Задайте массив вещественных чисел. 
// //Найдите разницу между максимальным и минимальным элементов массива.

// int[] CreateRandomArray(int size){  //функция массив рандом double
//     int[] array = new int[size];
//     for (int i=0; i<size; i++){
//         array[i] = new Random().Next(100,1000);
//     }
//     return array;
// }

// void ShowArray(int[] array){   //функция вывода массива
//     for (int i=0; i<array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }

// int MaxElement(int[] array){  //функция нахождения max
//     int max=array[0];
//     for (int i=0; i<array.Length;i++){
//         if (array[i] > max) {
//             max=array[i];}
//     }
//     return max;
// }

// int MinElement(int[] array){  //функция нахождения min
//     int min=array[0];
//     for (int i=0; i<array.Length;i++){
//         if (array[i] < min) {
//             min=array[i];}
//     }
//     return min;
// }

// Console.Write("Input size : ");  //задаем размер массива
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(size);
// ShowArray(array); //вывод массива


// int max = MaxElement(array);
// int min = MinElement(array);
// Console.WriteLine();
// Console.WriteLine($"Min: {min}, Max: {max}"); //считаем и выводим min и max
// Console.WriteLine("The difference between the maximum and minimum array elements = " +(max-min));

