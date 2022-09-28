// //Задача 41: Пользователь вводит с клавиатуры M чисел. 
// // Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int [] CreateArray(int size){  //функция создания нового массива из size элементов (ввод с клавиатуры)
//     int[] array = new int [size];
//     for(int i=0; i<size;i++){
//         Console.Write("Введите число: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// int PositiveCount(int[] array){ //считаем элементы больше нуля
//     int count = 0;
//     for (int i=0; i<array.Length; i++){
//         if(array[i]>0){
//             count++;
//         }
//     }
//     return count;
// }

// Console.Write("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(size); //создаем массив, заполняем
// int x = PositiveCount(array); // считаем элементы больше нуля
// Console.WriteLine("Количество положительных элементов в массиве: "+x); //вывод


// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// // значения b1, k1, b2 и k2 задаются пользователем.

// Console.WriteLine("y = k1 * x + b1; y = k2 * x + b2");
// Console.WriteLine("Введите значения:");
// Console.Write("b1=");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("k1=");
// double  k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("b2=");
// double  b2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("k2=");
// double  k2 = Convert.ToDouble(Console.ReadLine());

// double x=((b2-b1)/(k1-k2));
// double y=(k1*((b2-b1)/(k1-k2))+b1);
// Console.WriteLine($"({x},{y})");