using System;

delegate void MyEventHandler(string message);

class MyClass
{
    public event MyEventHandler MyEvent;

    public void RaiseEvent(string message)
    {
        if (MyEvent != null)
        {
            MyEvent(message);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass();

        myObject.MyEvent += MyEventHandlerMethod;

        myObject.RaiseEvent("Si sale esto funciona jajaja");

        Console.ReadLine();
    }

    static void MyEventHandlerMethod(string message)
    {
        Console.WriteLine($"Event raised: {message}");
    }
}