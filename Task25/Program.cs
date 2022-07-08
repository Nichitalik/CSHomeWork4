// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


System.Console.WriteLine("Введите число: ");
System.Console.WriteLine("Введите степень: ");

int power(int A, int B)
{
    int i = 1;
    int Res = A;
    while (i < B)
    {
        Res = Res * A;
        i++;
    }
    return Res;
}

System.Console.Write("Ответ: ");
System.Console.WriteLine(power(3, 5));