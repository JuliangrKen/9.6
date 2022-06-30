using System;
internal class MyException : Exception
{
    public override string Message { get; }
    internal MyException() : base()
    {
        Message = "Сработала некая ошибка";
    }
}