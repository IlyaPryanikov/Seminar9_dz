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

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRandom2dArray(rows,cols,min,max);
Show2dArray(array);
Console.WriteLine();
int [,] array2 = Reverse2dArray(array);
Show2dArray(array2);

//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int [,] Reverse2dArray(int[,] array){
    int temp=0;
    for (int i=0;i<array.GetLength(0);i++){
        for (int j=i+1;j<array.GetLength(0);j++){
            temp = array[i,j];
            array[i,j]=array[j,i];
            array[j,i]=temp;
        }
    }
    return array;
}