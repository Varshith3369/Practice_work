using System;

// Base Class (Parent)
public class Animal
{
    public string Name { get; set; }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }

    // 'virtual' allows derived classes to override this method
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic animal sound");
    }
}

// Derived Class (Child)
public class Dog : Animal
{
    // 'override' changes the behavior of the base method
    public override void MakeSound()
    {
        Console.WriteLine("Woof! Woof!");
    }
}

class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        myDog.Name = "Buddy";
        
        // Inherited method from Animal
        myDog.Eat(); 
        
        // Overridden method from Dog
        myDog.MakeSound(); 
    }
}
