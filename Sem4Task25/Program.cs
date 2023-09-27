// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Num(string msg)
{
    Console.WriteLine($"Введите {msg} число");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void stepen(int num1, int num2)
{
    double number = Math.Pow(num1, num2);
    Console.WriteLine($"{num1}, {num2} -> {number}");
}

stepen(Num("first"), Num("SECOND"));

