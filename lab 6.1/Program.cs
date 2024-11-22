using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите натуральное число:");
        // Вводим натуральное число
        if (!long.TryParse(Console.ReadLine(), out long number) || number <= 0)
        {
            Console.WriteLine("Ошибка: Введите корректное натуральное число.");
            return;
        }

        Console.WriteLine("Введите основание системы счисления (от 2 до 9):");
        // Вводим основание системы счисления
        if (!int.TryParse(Console.ReadLine(), out int baseSystem) || baseSystem < 2 || baseSystem > 9)
        {
            Console.WriteLine("Ошибка: Введите основание от 2 до 9.");
            return;
        }

        string result = ConvertToBase(number, baseSystem);
        Console.WriteLine($"Число {number} в {baseSystem}-ричной системе: {result}");
    }

    static string ConvertToBase(long number, int baseSystem)
    {
        if (number == 0)
        {
            return "0";
        }

        string result = string.Empty;
        while (number > 0)
        {
            long remainder = number % baseSystem;
            result = remainder.ToString() + result; // Добавляем остаток в строку результата
            number /= baseSystem; // Уменьшаем число
        }

        return result;
    }
}