using System;
public class GoldenMushroom : Item
{
    public int duration = 5;

    public void itemoutput()
    {
        Console.WriteLine(itemtext + "Golden Mushroom");
        Console.WriteLine("Duration left: " + duration);
    }
}