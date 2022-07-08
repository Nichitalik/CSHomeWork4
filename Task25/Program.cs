// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


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
System.Console.WriteLine(power(3, 5));