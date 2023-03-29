using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите номер дня недели (1 - понедельник, 2 - вторник, и т.д.): ");
        int dayOfWeek = int.Parse(Console.ReadLine());

        // Проверяем, является ли день недели выходным
        if (dayOfWeek == 6 || dayOfWeek == 7)
        {
            Console.WriteLine("Это выходной день!");
        }
        else
        {
            Console.WriteLine("Это рабочий день.");
        }
    }
}

