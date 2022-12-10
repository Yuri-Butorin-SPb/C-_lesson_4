// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число: ");
int yourNum = int.Parse(Console.ReadLine());


int result = SumOfNumbers(yourNum);
Console.WriteLine($"Сумма цифр в числе: {result}");



int SumOfNumbers(int number)

{
    int sum = 0;
    
    while (number > 0)
    {
        sum = number % 10 + sum;
        number = number / 10;
    }
    return sum;
}




