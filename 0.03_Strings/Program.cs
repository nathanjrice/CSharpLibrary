using System;

public class Program
{
    public static void Main()
    {
        string firstName;
        string lastName;
        string occupation;

        firstName = "Nathan";
        lastName = "Rice";
        occupation = "Gamer";
        string fullName = firstName + " " + lastName;
        Console.WriteLine(fullName);

        Console.WriteLine("Name: " + fullName + "\n" + "Occupation: " + occupation);

        decimal temp = 20.4m;
        string s = String.Format("At {0}, the temperature is {1}°C.",
                         DateTime.Now, temp);
        Console.WriteLine(s);
        Console.ReadLine();
    }
}
