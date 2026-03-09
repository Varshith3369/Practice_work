using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Initialization
        HashSet<string> invitedGuests = new HashSet<string>();

        // 2. Adding elements
        invitedGuests.Add("Alice");
        invitedGuests.Add("Bob");
        invitedGuests.Add("Charlie");

        // 3. Attempting to add a duplicate
        bool wasAdded = invitedGuests.Add("Alice"); 
        Console.WriteLine($"Was Alice added again? {wasAdded}"); // Output: False

        // 4. Checking for existence (Extremely fast: O(1))
        if (invitedGuests.Contains("Bob"))
        {
            Console.WriteLine("Bob is on the list!");
        }

        // 5. Removing an element
        invitedGuests.Remove("Charlie");

        // 6. Iterating (Note: Order is NOT guaranteed)
        Console.WriteLine("\nGuest List:");
        foreach (var guest in invitedGuests)
        {
            Console.WriteLine(guest);
        }
    }
}
