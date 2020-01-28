using System;
public class Bananas : Item
{
    public int amount = 3;

    public void itemoutput()
    {
        Console.WriteLine(itemtext + "Bananas");
        Console.WriteLine("Current amount: " + amount);
    }
}