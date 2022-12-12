// Задача 27: Напишите программу, 
// которая принимает на вход число и выдаёт 
// сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());
int SumNumbers(int userNumber)
{
    int counter = Convert.ToString(userNumber).Length;
    int nextDigit = 0;
    int result = 0;
    for (int i = 0; i < counter; i++)
    {
        nextDigit = userNumber - userNumber % 10;
        result = result + (userNumber - nextDigit);
        userNumber = userNumber / 10;
    }
    return result;
}
int sumNumbers = SumNumbers(userNumber);
Console.WriteLine("сумма цифр в числе равняется " + sumNumbers);
