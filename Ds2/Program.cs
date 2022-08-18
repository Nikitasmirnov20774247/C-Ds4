Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int FnumberN = numberN;
int num = 0;
int sum = 0;

while (numberN > 0)
{
    num = numberN % 10;
    numberN = numberN / 10;
    sum = sum + num;
}

Console.WriteLine($"Сумма цифр в числе {FnumberN} = {sum}");