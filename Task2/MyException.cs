using System;
internal class MyException : Exception
{
    public override string Message { get; }
    internal MyException() : base()
    {
        Message = "Да сказали же 1 или 2!";
    }
}