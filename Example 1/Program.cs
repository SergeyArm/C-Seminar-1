// Напишите программу, которая на вход принимает число и выдает его квадрат
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите число: ");
double a = Convert.ToDouble(Console.ReadLine());
double b = a * a;
//Console.WriteLine($"Квадрат числа равен {b}");
//или
Console.WriteLine("Квадрат числа равен " + b);