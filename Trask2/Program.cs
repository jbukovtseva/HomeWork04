Console.Write("Введите число: ");
string numbers = Console.ReadLine();

/* int SumNumbersInNumber(int number)
{
    int count = 0;
    int sum = 0;
    int resNum = GetCountNumbers(number);
    for (int i = 0; i < resNum; i++)
    {
        sum = sum + (number % 10);
        number = number / 10;
    }
    return sum;
}
int GetCountNumbers(int num)
{
    int count = 0;
    while (num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}
void ExceptionHandling(string enterA)
{
    bool yesInt = int.TryParse(enterA, out int result);
    if (yesInt && result >= 0) // Непонятно, что делать с отрицательными числами и 0
    {
        int sumResult = SumNumbersInNumber(result);
        Console.WriteLine("Сумма цифр числа {0} = {1}",
                          result, sumResult);
    }
    else
    {
        Console.WriteLine("{0} -> Некорректный ввод!", numbers);
    }
}
ExceptionHandling(numbers); */

int SumNumbersInNumber(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }
    return sum;
}

void ExceptionHandling(string enterA)
{
    bool yesInt = int.TryParse(enterA, out int result);

    if (yesInt && result >= 0) // Непонятно, что делать с отрицательными числами и 0
    {
        int sumResult = SumNumbersInNumber(result);
        Console.WriteLine("Сумма цифр числа {0} = {1}",
                          result, sumResult);
    }
    else
    {
        Console.WriteLine("{0} -> Некорректный ввод!", numbers);
    }
}

ExceptionHandling(numbers);