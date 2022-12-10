/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/


Console.WriteLine("Введите число, которое хотите возвести в степень: ");

double number = double.Parse(Console.ReadLine());

Console.WriteLine("Введите степень: ");

double squareNumber = double.Parse(Console.ReadLine());
double result = ReturnSquareNumber (number, squareNumber);

Console.WriteLine($"{number}^{squareNumber} = {result}");




double ReturnSquareNumber(double num1, double num2)
{
    double result = num1;
    if (num2 == 0) result = 1;
    else if (num2 < 0)
    {
        num2 = -num2;
        for (int i = 1; i < num2; i++)
        {
            result = result * num1;
        }
        result = 1/result;
    }
    else
    {
        for (int i = 1; i < num2; i++)
        {
            result = result = result * num1;
        }
    }
    return result;
}
