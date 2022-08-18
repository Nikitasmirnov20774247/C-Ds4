Console.Write("Введите число: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень для предыдущего числа: ");
int Num2 = Convert.ToInt32(Console.ReadLine());

int Numbers(int A, int B)
{
    int extentB = 1;
    for (int i = 0; i < B; i++)
    {
        extentB = extentB * A;
    }
    return extentB;
}

int result = Numbers(Num1, Num2);
Console.WriteLine($"Результат: {Num1}^{Num2} = {result}");