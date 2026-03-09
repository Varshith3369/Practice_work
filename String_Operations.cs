using System;

class Program
{
    static void Main()
    {
        string firstName = "Jai";
        string lastName = "SriRam";

        string fullName = firstName + " " + lastName;

        string bio = $"{firstName} {lastName} was a good king.";

        string joined = string.Concat(firstName, " ", lastName);

        Console.WriteLine(fullName);
        Console.WriteLine(bio);
        Console.WriteLine(joined);
    }
}
