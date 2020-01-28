using System;

public class Class2 : Class1
{
    public void publicFunc()
    {
        this.yes = false;
        {
            int anotherOne = 123;
        }
    }
    private void privateFunc()
    {
        bool veryBad = true;
    }
    protected void ProtectedFunc()
    {
        string hornet = "void";
    }

    public Class2()
    {

    }
}