using System;

public class Program
{
    public Operations o;
    public void Main()
    {
        o = new Operations();
        Console.WriteLine("Welcome");
        o.DoMath(10, 4);
        o.DoMath(20, 7);
        o.DoMath(20, 7);
    }
}
public class Operations
{
    public void DoMath(int value1, int value2)
    {
        var number = value1 + value2;
        Console.WriteLine(number);
    }
}