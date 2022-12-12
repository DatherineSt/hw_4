// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double A = new double();
Console.WriteLine("Введите A");
A = Convert.ToInt32(Console.ReadLine());
double B = new double();
Console.WriteLine("Введите B");
B = Convert.ToInt32(Console.ReadLine());
double results = Math.Pow (A, B);
Console.WriteLine(results);

