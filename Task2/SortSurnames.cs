using System;

internal class SortSurnames
{
    internal delegate void EnterNumberDelegate(byte Number);
    internal event EnterNumberDelegate EnterNumberEvent;

    internal List<string> list = new List<string>();
    private byte SortIndex;
    internal SortSurnames() { }
    internal void Read()
    {        
        Console.WriteLine("Введите 1 (А-Я) или 2 (Я-А) для выбора варианта сортировки.");
        Console.Write("Ввод: ");

        byte number = Convert.ToByte(Console.ReadLine());
        if (number != 1 && number != 2) throw new MyException();
        EnterNumber(number);
        SortIndex = number;
    }

    internal void Sort()
    { 
        for (byte i = 0; i < 5; i++)
        {
            Console.WriteLine("Введите фамилию #" + (i + 1));
            list.Add(Input());
        }
        list.Sort();
        var Array = list.ToArray();
        if (SortIndex == 2)
            for (int i = 0; i < (int)(Array.Length - 1) / 2; i++)
                (list[i], list[Array.Length - 1 - i]) = (list[Array.Length - 1 - i], list[i]);
    }
    private string Input()
    {
        while (true)
        {
            Console.Write("Ввод: ");
            try
            {
                string? input = Console.ReadLine();
                if (input == null || input == "")
                    throw new FormatException();
                return input;
            }
            catch
            {
                Console.WriteLine("Некорректный ввод");
            }
        }
    }
    protected virtual void EnterNumber(byte Number)
    {
        EnterNumberEvent?.Invoke(Number);
    }
}