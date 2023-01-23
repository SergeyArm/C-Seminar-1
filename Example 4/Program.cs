// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от-N до N.
// Например:
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// Вариант через while

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = -1 * N;
while (a < N)
{
    Console.Write($"{a}, ");
    a = a + 1;
};
while (a == N)
{
    Console.Write($"{a}");
    break;
};