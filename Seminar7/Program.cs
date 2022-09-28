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

int CalcSumDiag(int[,] array){
    int sum = 0;
    if(array.GetLength(0) == array.GetLength(1)){
        for(int i = 0; i<array.GetLength(0); i++){
            sum += array[i,i];
        }
    }
    return sum;
}

//Задача на поиск квадратов у четных индексов:
int[,] ChangeArrayKwad(int[,] array){
for(int i = 0; i<array.GetLength(0); i++){
    for(int j = 0; j<array.GetLength(1); j++){
        if(i%2==0 && j%2==0){
            array[i,j] *= array[i,j];
        }
    }
}
return array;
}
//Задача на задание значения элемента массива равное сумме его индексов:
int[,] Create2dArray(int rows, int cols){
    int[,] array = new int[rows,cols];
    for(int i = 0; i<rows; i++){
        for(int j = 0; j<cols; j++){
            array[i,j] = i+j;
        }
    }
    return array;
}

Console.Write("Input numb of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(rows,cols,min,max);
Show2dArray(array);
int sum = CalcSumDiag(array);
Console.WriteLine("Sum of numb on main is: " + sum);