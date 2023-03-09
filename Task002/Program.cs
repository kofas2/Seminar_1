//Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет

Console.WriteLine("Введите число a: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numB == numA*numA)
{
    Console.WriteLine("Число b является квадратом числа a");
}
else 
{
    Console.WriteLine("Число b не является квадратом числа a");
}