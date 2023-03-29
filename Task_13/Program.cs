using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        // Вычисляем третью цифру числа
        int third_digit = (number / 100) % 10;

        // Проверяем, есть ли третья цифра
        if (third_digit != 0)
        {
            Console.WriteLine("Третья цифра введенного числа: " + third_digit);
        }
        else
        {
            Console.WriteLine("Третьей цифры введенного числа нет.");
        }
    }
}
