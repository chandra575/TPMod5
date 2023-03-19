using System;

public class HaloGeneric
{
    public void SebutUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
    }
}