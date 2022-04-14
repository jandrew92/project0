using System;

public class PrintOptions{
    public static void execute(){
        Console.WriteLine("Welcome to StarMap!");
        Console.WriteLine("A record-keeping tool for astronomers!");
        Console.WriteLine("");
        Console.WriteLine("Type a number and press the Enter key to select an option.");
        Console.WriteLine("");
        Console.WriteLine("1. Look up a star record by ID number.");
        // 
        Console.WriteLine("2. Input a record for a new star.");
        // auto-increment star ID number for new stars
        // star ID number, name, color, size, and planets
        Console.WriteLine("3. Modify or delete records.");
        // 
        Console.WriteLine("4. View statistics regarding the entire database.");
        // percentage of each color, size group, and distance from Earth
        Console.WriteLine("5. Find stars by property.");
        // once a star is selected you can update or delete its record
        Console.WriteLine("6. Randomly generate a new galaxy.");
        // this will generate 1,000 random stars, each with between 5 and 12 planets
        // all previous records will be wiped and replaced with the new galaxy
        Console.WriteLine("7. Exit program.");
    }
}