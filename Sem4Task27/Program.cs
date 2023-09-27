// Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Num()
{
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int Sum(int number)
{
    int sum = 0;
    for (sum = 0; 0 < number; number /= 10)
    {
        sum = sum + number % 10;
    }
    return sum;
}
Console.WriteLine(Sum(Num()));
