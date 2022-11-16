//задайте одномерный массив из 123 случайных чисел
//найдите кол-во элементов массива, значения которых лежат в отрезке [10, 99]


Console.Clear();
int[] GetArray(int size, int minvalue, int maxvalue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minvalue, maxvalue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
    Console.WriteLine();
}

int[] array = GetArray(123, 1, 123);
int count = default;
Console.WriteLine();

foreach (int elem in array)
{
    if(elem > 9 && elem < 100) count++;
}
Console.Write($"кол-во элементов массива, значения которых лежат в отрезке [10, 99] => {count}");
Console.WriteLine();
