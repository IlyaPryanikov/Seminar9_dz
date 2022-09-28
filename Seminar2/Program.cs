
/*
int CutNumber(){
    int num = new Random().Next(100,1000);
    Console.WriteLine("Number is =" + num);
    int dec = num / 100;
    int ed = num % 10;
    int result = dec*10 + ed;
    return result;
}

int number = CutNumber();
Console.WriteLine("Cutted number is =" +number);
*/


//void редко используется

// void CutNumber(){
//     int num = new Random().Next(100,1000);
//     Console.WriteLine("Number is =" + num);
//     int dec = num / 100;
//     int ed = num % 10;
//     int result = dec*10 + ed;
//     Console.WriteLine("Cutted number is =" +result);
// }

// CutNumber();

// int Factorial (int num){
//     int current=1;
//     int fact=1;
//     if (num>0){
//     while (current<=num){
//     fact = fact * current;
//     current++;
//     }
//     return fact;
//     }
//     else if (num == 0) { 
//     return fact;    
//     }
//     else{
//         Console.WriteLine("Факториал отрицательного числа невозможен!");
//         return 0;
//     }
// }

// int result = Factorial(0) * Factorial(5);
// Console.WriteLine("Your result =" +result);

// int Line(){
//     int num = new Random().Next(10,100);
//     Console.WriteLine("Your number is =" + num);
//     int dec = num / 10;
//     int ed = num % 10;
//     if (dec>ed){ 
//         return dec;
//     }
//     else {
//         return ed;
//     }
// }
// Console.WriteLine("Result =" + Line());

// void Crat(int num){
//     if (num % 7 == 0 && num % 23 == 0){
//         Console.WriteLine("Число кратно одновременно 7 и 23");
//     }
//     else{
//         Console.WriteLine("Число не кратно одновременно 7 и 23");
//     }
// }

// Console.WriteLine("Enter the number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Crat(number);


// Является ли одно число квадратом другого?

// void Square(int a, int b){
//     if (a==b*b || b==a*a){
//         Console.WriteLine("Условие выполняется");
//     }
//     else{
//         Console.WriteLine("Условие не выполняется");
//          }
// }

// Console.WriteLine("Введите число 1: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Square(a,b);

//Напишите программу, которая будет принимать на вход два числа и выводить
//является ли второе число кратным первому. Если 2 число не кратно 1 числу,
//то программа выводит остаток от деления.

// int delenie(int a, int b){
//     if (b % a != 0){
//         int result = b % a;
//         return result;}
//         else{
//             return 0;
//         }
//     }
// Console.WriteLine("Введите число 1: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a==0 || b==0){
//     Console.WriteLine("На ноль делить нельзя!");
// }
// else {
//     int result = delenie(a,b);
//     if (result == 0){
//         Console.WriteLine("Число 2 кратно 1");
//     }
//     else{
//         Console.WriteLine("Число 2 не кратно 1, остаток от деления: " +result);
//     }
// }