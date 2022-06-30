Exception[] exceptions = { new ApplicationException(), new ArgumentException(), new ArgumentNullException(), new ArgumentOutOfRangeException(), new MyException()};
 
try
{
    throw new MyException();
}
catch (Exception ex) when (ex.GetType() == exceptions[0].GetType())
{

}
catch (Exception ex) when (ex.GetType() == exceptions[1].GetType())
{

}
catch (Exception ex) when (ex.GetType() == exceptions[2].GetType())
{

}
catch (Exception ex) when (ex.GetType() == exceptions[3].GetType())
{

}
catch (Exception ex) when (ex.GetType() == exceptions[4].GetType())
{
    Console.WriteLine(ex.Message);
}