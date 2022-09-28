int ReadData(string line) //Запрос данных
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine()??"");
    return num;    
}
string Recurs(int num) //Рекурсия от 1 до N
{
    if (num<=1){
    return "1";}
    else {
    string outLine = Recurs(num-1) + " " + num;
    return outLine;
    }
}
void PrintData(string prefix, string num) //Вывод результата
{
    Console.WriteLine(prefix + num);
}

int inputNumber = ReadData("Введите число N");
string outLine = Recurs(inputNumber);
PrintData("Числа от 1 до N: ",outLine);