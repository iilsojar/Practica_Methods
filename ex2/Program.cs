//напишите программу которая выводит массив из 8 элементов заполненный 0 и 1 в случайном порядке

//способы инициализации массива
//int [] array = new int [8]; //если известно сколько должно быть элементов
// int [] array1 = new int [8] {1, 3, 4, 5, 6, 7, 8 }; //если сразу известно значение элементов
// int [] array2 = {1, 3, 4, 5, 6,}; //если сразу известно значение элементов
// var array3 = new int [8]; //если сразу понятен тип исаользуемых данных - в данном случае это int
// var randomNumber = new Random(); //тип данных сразу понятно что random, 
//если в будет например int и double - использовать var нельзя
//конфликт переменных


// array[0] = 5;
// array[1] = 3;
// array[2] = 1;
// array[3] = 4;
// array[4] = 0;
// array[5] = 9;
// array[6] = 2;
// array[7] = 6;

Console.Clear();
// int[] array = new int[8];
// FillArray(array);
// PrintArray(array);

// void FillArray(int[] arr)
// {
//     int length = arr.Length;
//     for (int i = 0; i < length; i++)
//     {
//         arr[i] = new Random().Next(0, 2);
//     }
// }
// void PrintArray(int[] arr)
// {
//     int length = arr.Length;
//     for (int i = 0; i < length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }

Console.Write("введите размер массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int [number];
FillArray(array);
PrintArray(array);

void FillArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write("]");
}