int num1, num2;

// Ввод данных
Console.Write("Введите число 1: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2) {
Console.WriteLine("Число 1 является квадратом числа 2");
}
else {
Console.WriteLine("Число 1 не является квадратом числа 2");
}

