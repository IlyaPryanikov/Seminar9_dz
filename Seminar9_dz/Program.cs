// Методы для решения задач

int ReadData(string line) //Запрос данных
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine()??"");
    return num;    
}

void PrintData(string prefix, int num) //Вывод результата для задач 66,68
{
    Console.WriteLine(prefix + num);
}

void PrintDataStr(string prefix, string num) //Вывод результата для задачи 64
{
    Console.WriteLine(prefix + num);
}


// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

string NumMN(int m, int n) //Рекурсия от M до N
{
    if (m>=n){
    return Convert.ToString(n);}
    else {
    string outLine = m + " " + NumMN(m+1,n);
    return outLine;
    } 
}

int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");
if (m<n){string outLine = NumMN(m,n); PrintDataStr("Числа от M до N: ",outLine);}
else {string outLine = NumMN(n,m); PrintDataStr("Числа от M до N: ",outLine);}


// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// // сумму натуральных элементов в промежутке от M до N.

// int SumMN(int m, int n) //Рекурсия от M до N
// {
//     if (m>=n){
//     return n;
//     }
//     else {
//     int temp = m + SumMN(m+1,n);
//     return temp;
//     } 
// }

// int m = ReadData("Введите число M: ");
// int n = ReadData("Введите число N: ");
// if (m<n){int outLine = SumMN(m,n); PrintData("Cумма натуральных элементов в промежутке от M до N: ",outLine);}
// else {int outLine = SumMN(n,m); PrintData("Cумма натуральных элементов в промежутке от M до N: ",outLine);}


// // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 

// int Ack(int m, int n) // Фция Аккермана
// {
//   if (m == 0) return n + 1;
//   else if (n == 0) return Ack(m - 1, 1);
//   else return Ack(m - 1, Ack(m, n - 1));
// }

// int m = ReadData("Введите число M: ");
// int n = ReadData("Введите число N: ");
// if (m<n){int outLine = Ack(m,n); PrintData("Функция Аккермана : ",outLine);}
// else {int outLine = Ack(n,m); PrintData("Функция Аккермана : ",outLine);}
