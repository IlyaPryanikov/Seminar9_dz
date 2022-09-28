// //Задача 19
// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// void palindrom(string n){
//    if (n[0] == n[4] && n[1] == n[3]) {
//         Console.WriteLine("да");
//     }
//     else {
//         Console.WriteLine("нет");
//     }
// }

// Console.WriteLine("Введите число: ");
// string vvod = Console.ReadLine();
// palindrom(vvod);


// // Задача 21. Напишите программу, которая принимает на вход координаты двух точек и 
// // находит расстояние между ними в 3D пространстве.

// Console.WriteLine("Введите координату Х первой точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y первой точки: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Z первой точки: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Х второй точки: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y второй точки: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Z второй точки: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double rasstoyanie(double x1, double x2, double y1, double y2,double z1,double z2) {
//     return Math.Sqrt(((x2-x1)*(x2-x1)) + ((y2-y1)*(y2-y1)) + ((z2-z1)*(z2-z1)));
// }
// double znachenie=rasstoyanie(x1, x2, y1, y2, z1, z2);
// Console.WriteLine("Длина отрезка :"+ Math.Round(znachenie,2));


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// Было же на семинаре, нет разве?)

// void Square(int n){
//     int curr = 1;
//     while(curr<=n){
//         Console.Write(curr*curr + ", ");
//         curr++;
//     }
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num <= 0) Console.Write("Некорректный ввод");
// else Square(num);


// ** Напишите программу, 
// ** которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
// same same as Задача 21.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Введите координату Х первой точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y первой точки: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Х второй точки: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y второй точки: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double rasstoyanie(double x1, double x2, double y1, double y2) {
//     return Math.Sqrt(((x2-x1)*(x2-x1)) + ((y2-y1)*(y2-y1)));
// }
// double znachenie=rasstoyanie(x1, x2, y1, y2);
// Console.WriteLine("Длина отрезка :"+ Math.Round(znachenie,3));


