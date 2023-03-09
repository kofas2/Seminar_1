Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32 (Console.ReadLine());
int square = num*num;
Console.WriteLine("Квадрат введенного числа равен: " + square);

if (num<0)
{
    Console.WriteLine("Введено отрицательное число");
}
else
{
    Console.WriteLine("Введено неотрицательное число");
}