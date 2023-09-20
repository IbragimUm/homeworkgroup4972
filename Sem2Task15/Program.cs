// №15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// * Сделать вариант с использованием конструкции Dictionary

// Сделал массив Dictionary
string[] Dictionary = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

string day = Console.ReadLine()?? "0";

int Day = int.Parse(day);

int index = Day - 1;
if(Day>5){
    Console.WriteLine(Dictionary[index] + " выходной");
}else{
    Console.WriteLine(Dictionary[index] + " не выходной");
}
