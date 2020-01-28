using System;
public class Coin : Item
{
    public int currentCoins = 4;
    public int maxCoins = 10;

    public void itemoutput()
    {
        Console.WriteLine(itemtext + "Coin");
        Console.WriteLine("Current amount: " + currentCoins);
        Console.WriteLine("Max amount: " + maxCoins);
    }
}