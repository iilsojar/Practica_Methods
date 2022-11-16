//задайте массив. напишите программу, которая определяет есть ли заданное число в массиве

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

int[] arr = GetArray(12, -9, 9);
Console.Write("введите искомое в массиве число: ");

int number = Convert.ToInt32(Console.ReadLine());
// int count = 0;

// foreach (int elem in arr)
// {
//     if (elem == number)
//     {
//         count +=1;
//     }
// }
//     if (count > 0) Console.Write($"в заданном массиве есть число {number} ");
//     else Console.Write($"в заданном массиве нет числа {number} ");
//     Console.WriteLine();

bool count = false; 

foreach (int elem in arr)
{
    if (elem == number)
    {
        count = true;
    }
}
    if (count == true) Console.Write($"в заданном массиве есть число {number} ");
    else Console.Write($"в заданном массиве нет числа {number} ");
    Console.WriteLine();

