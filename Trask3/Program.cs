Console.Write("Введите размер массива: ");
string len = Console.ReadLine();

void ExceptionHandling(string enterA)
{
    bool yesInt = int.TryParse(enterA, out int result);

    if (yesInt && result > 0)
    {
        int[] rndNum = new int[result];
        FillArray(rndNum);
        PrintArray(rndNum);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("{0} -> Некорректный ввод!", len);
        Console.ForegroundColor = ConsoleColor.White;
    }
}

void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write("Введите целое число, {0} элемент массива: ", i + 1);
        string elemArray = Console.ReadLine();
        bool yesInt = int.TryParse(elemArray, out int result);
        if (yesInt)
        {
            array[i] = result;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{elemArray} -> Некорректный ввод!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{i + 1} элемент массива = 0");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

void PrintArray(int[] arr)
{
    string str = "[";
    foreach (int i in arr)
    {
        str += $", {i}";
    }
    str = str.Remove(1, 2);
    str += "]";
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write($"Массив из {arr.Length} элементов: ");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write(str);
    Console.ForegroundColor = ConsoleColor.White;
}

ExceptionHandling(len);
