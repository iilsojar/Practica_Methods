//задайте массив из 12 элементов, заполненный случайными числами от -9 до 9.
//найдите сумму положительных и отрицательных элементов массива

//1шаг - метод для заполнения массива 12тью числами в диапазоне от -9 до 9

int[] CreatArrayRandom(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
//2шаг - вывод массива, заполненного выше с символами "[" "," и "]".

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] arr = CreatArrayRandom(12, -9, 9);
PrintArray(arr);
int SumPosit = SummPositiveElem(arr);
int SumNegat = SummNegativeElem(arr);
Console.WriteLine($"сумма положительных элементов = {SumPosit}");
Console.WriteLine($"сумма отрицательных элементов = {SumNegat}");

// int[] summPositiveNegativeElem = SummPositiveNegativeElem(arr);
// Console.WriteLine($"сумма положительных элементов = {summPositiveNegativeElem[0]}");
// Console.WriteLine($"сумма отрицательных элементов = {summPositiveNegativeElem[1]}");


// 3шаг поиск суммы положительных и отрицательных значений
// метод 1 общий для отриц и положит чисел

int[] SummPositiveNegativeElem(int[] array)
{
    int SumPositive = default;
    int SumNegative = default;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) SumNegative = SumNegative + array[i];
        else SumPositive = SumPositive + array[i];
    }
    return new int[] { SumPositive, SumNegative };
}

//метод поиска только суммы положительных значений
int SummPositiveElem(int[] array)
{
    int SumPositive = default;

    for (int i = 0; i < array.Length; i++)
        if(array[i] > 0) SumPositive = SumPositive + array[i];
    return SumPositive;
}
//метод поиска только отрицательных значений
int SummNegativeElem(int[] array)
{
    int SumNegative = default;

    for (int i = 0; i < array.Length; i++)
        if(array[i] < 0) SumNegative = SumNegative + array[i];
    return SumNegative;
}