// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("введите число: ");
int sum(int num)
{
    int Res = 0;
    while (num > 0)
    {
        Res = Res + num % 10;
        num /= 10;
    }
    return Res;
}
System.Console.Write("ответ: ");
System.Console.WriteLine(sum(9012));