using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое натуральное число:");
        if (!int.TryParse(Console.ReadLine(), out int number1) || number1 <= 0)
        {
            Console.WriteLine("Ошибка: введите натуральное число!");
            return;
        }

        Console.WriteLine("Введите второе натуральное число:");
        if (!int.TryParse(Console.ReadLine(), out int number2) || number2 <= 0)
        {
            Console.WriteLine("Ошибка: введите натуральное число!");
            return;
        }

        Console.WriteLine("результат");
        Console.WriteLine($"сложение: {number1} + {number2} = {number1 + number2}");
        Console.WriteLine($"вычитание: {number1} - {number2} = {number1 - number2}");
        Console.WriteLine($"умножение: {number1} * {number2} = {number1 * number2}");
        if (number2 != 0)
        {
            Console.WriteLine($"деление: {number1} / {number2} = {(double)number1 / number2}");
        }
        else
        {
            Console.WriteLine("ltkbnm yf 0 ytkmpz");



        }
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}