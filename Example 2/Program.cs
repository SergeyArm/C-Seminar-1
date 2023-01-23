// Напишите программу, которая на вход принимает два числа и проверяет,
//является ли первое число квадратом второго.
// Например:
// a = 25, b = 5 -> Да
// a = 2, b = 10 -> Нет
// a = 9, b = -3 -> Да
// a = -3, b =9 -> Нет

Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = b * b;
if (c == a)
{
Console.Write("Число a является квадратом числа b!");
}
else
{
Console.Write("Число a не является квадратом числа b!");
};