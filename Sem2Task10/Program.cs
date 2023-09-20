// №10 Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void variant1()
{
    //Способ первый

    Console.WriteLine("Введите трехзначное число: ");
    //Вводит трехзначное число в виде строки
    string num3 = Console.ReadLine() ?? "0";
    //Находит вторую цифру цифру числа в виде символа
    char second = num3[1];
    //Выводит цифру
    Console.WriteLine(second);
}
void variant2()
{

    //Способ второй

    Console.WriteLine("Введите трехзначное число: ");
    //Вводит число
    string number = Console.ReadLine() ?? "0";
    //переделывает в число
    int numWrite = int.Parse(number);
    //делит число на 100 и находит остаток
    int firstDigit = numWrite % 100;
    //делит число на 10 и находит сколько 10 в числе
    int secondDigit = firstDigit / 10;
    Console.WriteLine(secondDigit);
}

variant1();
variant2();