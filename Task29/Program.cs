// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


System.Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] arr = new int[size];

int[] createArr(int a)
{
    int i = 0;
    while (i < a)
    {
        System.Console.Write($"Введите {i + 1} элемент массива: ");
        arr[i] = int.Parse(Console.ReadLine()!);
        i++;
    }
    return arr;
}

void printArr()
{
    for (int i = 0; i < size; i++)
    {
        System.Console.Write(arr[i]);
        if (i+1 < size) System.Console.Write(", ");
    }
}


createArr(size);
printArr();