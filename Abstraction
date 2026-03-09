using System;

// 1. Define an Abstract Class (Cannot be instantiated)
public abstract class SmartDevice
{
    public string DeviceName { get; set; }

    // Regular method: All devices turn on the same way
    public void PowerOn() => Console.WriteLine($"{DeviceName} is powering up...");

    // Abstract method: Each device performs its "Action" differently
    public abstract void PerformAction();
}

// 2. Concrete Class (Must implement the abstract method)
public class SmartLight : SmartDevice
{
    public override void PerformAction()
    {
        Console.WriteLine("The light is shining at 80% brightness.");
    }
}

public class SmartSpeaker : SmartDevice
{
    public override void PerformAction()
    {
        Console.WriteLine("The speaker is playing jazz music.");
    }
}
