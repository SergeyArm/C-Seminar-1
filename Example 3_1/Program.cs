// Напишите программу,
// которая будет выдавать название дня недели по заданному номеру
// Вариант Switch case

Console.Write("Введите число от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());
switch (a)
{
case 1:
    Console.Write("Понедельник");
    break;
case 2:
    Console.Write("Вторник");
    break;
case 3:
    Console.Write("Среда");
    break;
case 4:
    Console.Write("Четверг");
    break;
case 5:
    Console.Write("Пятница");
    break;
case 6:
    Console.Write("Суббота");
    break;
case 7:
    Console.Write("Воскресенье");
    break;
default:
    Console.Write("В неделе 7 дней. Введите число от 1 до 7");
    break;
};

