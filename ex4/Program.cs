//напишите программу замены элементов массива: положительные замените на отрицательные и наоборот
//[-4, -8, 8, 2] => [4, 8, -8, -2]
//решение - каждое число массива умножить на -1

Console.Clear();
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

void InversElemArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}
int[] arr = CreatArrayRandom(5, -9, 9);
PrintArray(arr);
InversElemArray(arr);
PrintArray(arr);
