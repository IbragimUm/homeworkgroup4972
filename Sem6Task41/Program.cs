// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


class Program
{
    static int CountPositiveNumbers(string input)
    {
        string[] numbers = input.Split(',');
        int count = 0;

        foreach (string number in numbers)
        {
            if (int.TryParse(number.Trim(), out int value) && value > 0)
            {
                count++;
            }
        }

        return count;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите числа, разделенные запятой:");
        string input = Console.ReadLine();

        int positiveCount = CountPositiveNumbers(input);
        Console.WriteLine($"Количество чисел, больше 0: {positiveCount}");

        Console.ReadLine();
    }
}