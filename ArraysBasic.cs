using System;

class Program
{
    static void Main()
    {
        string[] planets = { "Mercury", "Venus", "Earth", "Mars" };
        Console.WriteLine($"The third planet is {planets[2]}"); 
        
        planets[3] = "Jupiter"; 

        Console.WriteLine("List of planets:");
        for (int i = 0; i < planets.Length; i++)
        {
            Console.WriteLine($"Index {i}: {planets[i]}");
        }
    }
}
