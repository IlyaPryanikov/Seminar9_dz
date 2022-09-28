// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// void Stepen(int num1, int num2){
// int result = 1;
//     for (int curr=1; curr<num2+1; curr++){
//         result = result * num1;
//     }
//     Console.WriteLine($"{num1} в степени {num2} равна {result}");
// }
// Console.Write("Введите число А: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число В: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Stepen(number1,number2);


// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int Summa(string stroka){
//     int result=0;
//         for (int num=0; num < stroka.Length; num++){
//         string temp = Convert.ToString(stroka[num]); //конвертируем каждый элемент в строку
//         result = result + Convert.ToInt32(temp); //конвертируем каждый элемент строки в Int, считаем сумму
//     } 
//     return result;
// }
// Console.Write("Введите число : ");
// string vvod = Console.ReadLine();
// Console.Write("Сумма чисел : "+ Summa(vvod));


// // Задача 29: Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.

// int[] RandomArray(int Razmer)
// {
//  int[] array=new int[Razmer]; //задаем размер массива
//  for (int i=0;i<Razmer;i++) //заполняем его случайными значениями
//  {
//     array[i]=new Random().Next(1,99); //значения от 1 до 99
//  }
//    return array;
// }
 
// void ShowArray(int[] array){
//     Console.Write("[ ");
//     for(int i=0; i<array.Length; i++){ //стандарный вывод из 4го семинара
//         Console.Write(array[i]+" ");
//     }
//     Console.Write("]");
// }

// Console.Write("Введите кол-во элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// ShowArray(RandomArray(size)); //функция вывод от функции заполнить случайными числами

