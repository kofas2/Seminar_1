//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.WriteLine("Напишите номер дня недели (1-7): ");
int a = Convert.ToInt32(Console.ReadLine());

switch (a)
{
case 1:
    Console.WriteLine("День недели - понедельник");
    break;
case 2:
    Console.WriteLine("День недели - вторник");
    break;
case 3:
    Console.WriteLine("День недели - среда");
    break;
case 4:
    Console.WriteLine("День недели - четверг");
    break;
case 5:
    Console.WriteLine("День недели - пятница");
    break;
case 6:
    Console.WriteLine("День недели - суббота");
    break;
case 7:
    Console.WriteLine("День недели - воскресенье");
    break;
    default:
    Console.WriteLine("Введено некорректное значение!");
    break;
}