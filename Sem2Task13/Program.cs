// №13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// * Сделать вариант для числа длиной до 10 цифр не используя char или string

Console.WriteLine("Введите число");
string strNumber = Console.ReadLine()??"0";
int Number = int.Parse(strNumber);

void FindThird(int Arg)
{
    int result = 0;

    if (Arg < 100){
        Console.WriteLine("Нет третьей цифры");
    }else if (Arg < 1000){
        result = Arg % 10;
        Console.WriteLine(result);
    } else if (Arg < 10000){
        result = Arg % 100 / 10;
        Console.WriteLine(result);
    }
    else if (Arg < 100000){
        result = Arg % 1000 / 100;
        Console.WriteLine(result);
    }
    else if (Arg < 1000000){
        result = Arg % 10000 / 1000;
        Console.WriteLine(result);
    }else if(Arg < 10000000){
        result = Arg % 100000 / 10000;
        Console.WriteLine(result);
    }else if(Arg < 100000000){
        result = Arg % 1000000 / 100000;
        Console.WriteLine(result);
    }else if(Arg < 1000000000){
        result = Arg % 10000000 / 1000000;
        Console.WriteLine(result);
    }else{
        Console.WriteLine("Слишком большое число");
    }
}

FindThird(Number);