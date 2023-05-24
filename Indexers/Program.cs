using System;

class MyClass
{
    int[] arr =  {1,2,3,4,5,6,7,8 };
    public int this[int i]
    {
        get { return arr[i]; }
        set { arr[i] = value; }
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        MyClass myClass = new MyClass();
        var a = myClass[0];
        System.Console.WriteLine(a);
        Console.ReadLine();
    }
}
