using System;
using System.Collections.Generic; // Required for List<T>

class Program
{
    static void Main()
    {
        // 1. Declaration and Initialization
        // <string> defines the type of data the list will hold
        List<string> gamers = new List<string> { "Alice", "Bob" };

        // 2. Adding elements
        gamers.Add("Charlie");
        gamers.AddRange(new string[] { "Dave", "Eve" });

        // 3. Removing elements
        gamers.Remove("Bob"); // Removes by value
        gamers.RemoveAt(0);   // Removes by index (Alice is gone)

        // 4. Accessing and Counting
        Console.WriteLine($"Total gamers: {gamers.Count}");
        Console.WriteLine($"The first person in line is: {gamers[0]}");

        // 5. Iterating
        Console.WriteLine("\nCurrent Lobby:");
        foreach (var player in gamers)
        {
            Console.WriteLine($"- {player}");
        }
    }
}
