// Задайте массив из 12 элементов (рандом от -9 до 9), найдите сумму отрицательных и положительных элементов


int[] CreateRandomArray(int size, int min, int max){
    int[] array = new int[size];
    for (int i=0; i<size; i++){
        array[i] = new Random().Next(min,max+1);
    }
    return array;
}

void ShowArray(int[] array){
    for (int i=0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}

int CountPosEl(int[] array){
    int count=0;
    for (int i=0; i<array.Length;i++){
        if (array[i]>0) {count = count+array[i];}
    }
    return count;
}

int CountNegEl(int[] array){
    int count=0;
    for (int i=0; i<array.Length;i++){
        if (array[i]<0) {count = count+array[i];}
    }
    return count;
}

Console.Write("Input size : ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min : ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max : ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size,min,max);
ShowArray(array);

int posSum = CountPosEl(array);
int negSum = CountNegEl(array);
Console.WriteLine();
Console.WriteLine($"Sum of positive numbers is {posSum} and sum of negative numbers is {negSum}");