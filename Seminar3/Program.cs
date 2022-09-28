//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

void Func(int a){
    if(a == 1) Console.WriteLine("Значение x>0, значение y>0"); // лайфхак)))
    else if(a == 2) Console.WriteLine("Значение x<0, значение y>0");
    else if(a == 3) Console.WriteLine("Значение x<0, значение y<0");
    else if(a == 4) Console.WriteLine("Значение x>0, значение y<0");
    else Console.WriteLine("Ввод не соответствует условию"); 
}

Console.Write("Введите номер четверти(1-4): ");
int num = Convert.ToInt32(Console.ReadLine());
Func(num);

//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


// void Func(int x, int y){
//     if(x>0 && y>0) Console.WriteLine("Четверть - 1"); // лайфхак)))
//     else if(x<0 && y>0) Console.WriteLine("Четверть - 2");
//     else if (x<0 && y<0) Console.WriteLine("Четверть - 3");
//     else if(x>0 && y<0) Console.WriteLine("Четверть - 4");
// }

// Console.Write("Введите координату x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x==0 || y==0) Console.Write("Несоответствует условию задачи");
// else Func(x,y);

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

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

// Напишите программу, 
//которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21