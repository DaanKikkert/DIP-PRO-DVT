using System;

namespace YOUDONTOWNME
{
    class Program
    {
        static void Main(string[] args)
        {
            GoldenMushroom goldenMushroom1 = new GoldenMushroom();
            goldenMushroom1.itemoutput();
            Bananas banana1 = new Bananas();
            banana1.itemoutput();
            Coin coin1 = new Coin();
            coin1.itemoutput();
        }
    }
}
