// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от-N до N.
// Например:
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// Вариант через for

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for(int a = -N; a <= N; a++)
{
    Console.Write(" "+a);
};