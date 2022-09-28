// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)

// int[] ReverseMass(int[] array){
//     int temp = 0;
//     for(int i=0; i < array.Length / 2;i++){
//         temp = array[i];
//         array[i]=array[array.Length -1 -i];
//         array[array.Length -1 -i] = temp;
//     }
//     return array;
// }

// int[] array = {1, 3, 6, 7, 2, 0};
// int[] revMas = ReverseMass(array);
// for(int i=0; i<revMas.Length; i++){
//     Console.Write(revMas[i]+" ");
// }

// int[] ReverseMass(int[] array){
//     int temp = 0;
//     for(int i=0, j = array.Length-1; i<j; i++, j--){
//         temp = array[i];
//         array[i]=array[j];
//         array[j] = temp;
//     }
//     return array;
// }

// int[] array = {1, 3, 6, 7, 2, 0};
// int[] revMas = ReverseMass(array);
// for(int i=0; i<revMas.Length; i++){
//     Console.Write(revMas[i]+" ");
// }

// int[] ReverseMass(int[] array){
//     int temp = 0;
//     int i = 0;
//     int j = array.Length - 1;
//     while (i<j){
//         temp = array[i];
//         array[i]=array[j];
//         array[j] = temp;  
//         i++;
//         j--;
//     }
//     return array;
// }

// int[] array = {1, 3, 6, 7, 2, 0};
// int[] revMas = ReverseMass(array);
// for(int i=0; i<revMas.Length; i++){
//     Console.Write(revMas[i]+" ");
// }

// Напииште программу, которая будет преобразовывать 
// десятичное число в двоичное

// string ChangeDigitSystem(int n){
//     string result = string.Empty;
//     while(n>0){
//         result = n%2 + result;
//         n = n/2;
//     }
//     return result;
// }
// Console.WriteLine("Input number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string res = ChangeDigitSystem(n);
// Console.WriteLine(res);

// Три числа - треугольник

// void Treugolnik(int a, int b, int c){
// if (a>b+c && b>a+c && c>a+b){
//     Console.WriteLine("Нет");}
// else Console.WriteLine("Да");
// }

// Console.Write("Первая сторона: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Вторая сторона: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Третья сторона: ");
// int c = Convert.ToInt32(Console.ReadLine());
// Treugolnik(a,b,c);

// DONE

// Fibonacci

//Задача.Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

int[] Fibon(int n){
    int[] array = new int[n];
    array[0]=0;
    array[1]=1;
    for(int i=2; i<n; i++){
       array[i] = array[i-2] + array[i-1]; 
    }
    return array;
}

void ShowArray(int[] array){                             
    for(int i = 0; i<array.Length; i++){
    Console.Write($"{array[i]} ");
    }
}
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowArray(Fibon(n));
