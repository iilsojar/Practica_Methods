//найдите произведение пар чисел в одномерном массиве.
//Пара - первый и последний элементы, второй и предпоследний и т.д.
//запишите в новом массиве

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

int[] array = GetArray(9, 1, 11);
int maslength = 0;

if (array.Length % 2 == 0)
{
    maslength = array.Length / 2;
}
else
{
    maslength = array.Length / 2 + 1;
}

int[] mass = new int[maslength];
Console.WriteLine();

for (int i = 0; i < maslength; i++)
{
    if (i != array.Length - 1 - i)
    {
        mass[i] = array[i] * array[array.Length - 1 - i];
        Console.Write($"{mass[i]} ");
    }
    else
    {
        mass[i] = array[i];
        Console.Write($"{mass[i]} ");
    }
}


