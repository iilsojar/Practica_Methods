// факториал


Console.Clear();
Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(number);
Console.WriteLine($"произведение чисел от 1 до {number} -> {factorial}");

int Factorial (int num)
{
    int factor = 1;
    for (int i = 1; i <= num; i++)
    {
        factor = factor * i;
    }
    return factor;
}

