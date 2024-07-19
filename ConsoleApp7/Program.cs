using System;

public class MyClass
{
    public void Space(string str)
    {
        string result = "";
        foreach (var c in str)
        {
            result += c + "_";
        }
        if (result.Length > 0)
            result = result.Remove(result.Length - 1);
        Console.WriteLine(result);
    }

    public void Reverse(string str)
    {
        string result = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            result += str[i];
        }
        Console.WriteLine(result);
    }
}

public class Run
{
    public void RunFunc(Action<string> func, string argument)
    {
        func(argument);
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter string");
        var str = Console.ReadLine();

        MyClass cls = new MyClass();
        Run run = new Run();
        Action<string> spaceAction = cls.Space;
        Action<string> reverseAction = cls.Reverse;
        run.RunFunc(spaceAction, str);
        run.RunFunc(reverseAction, str);
    }
}
