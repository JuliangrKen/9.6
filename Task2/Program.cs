SortSurnames sort = new SortSurnames();

sort.EnterNumberEvent += ShowNumber;

while (true)
{
    try
    {
        sort.Read();
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Вы ввели не число.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("(0_0)");
    }
    catch (MyException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

sort.Sort();

foreach (var surname in sort.list)
    Console.WriteLine(surname);

static void ShowNumber(byte number)
{
    switch (number)
    {
        case 1: Console.WriteLine("Введено значение 1"); break;
        case 2: Console.WriteLine("Введено значение 2"); break;
    }
}