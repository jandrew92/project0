using System;
public class Menu {
    public static void execute(){
        Console.Clear();
        PrintOptions.execute();
        string optionSelect = "0";
        bool exitLoop = false;
        while(!exitLoop){
            optionSelect = Console.ReadLine();
            switch(optionSelect){
                case "1":
                    // 1. Look up a star's record by ID number.
                    Console.Clear();
                    StarLookupID.execute();
                    Console.Clear();
                    PrintOptions.execute();
                break;
                case "2":
                    // 2. Input a record for a new star. 
                    Console.Clear();
                    InputStar.execute();
                    Console.Clear();
                    PrintOptions.execute();
                break;
                case "3":
                    // 3. Modify or delete a star's record. 
                    Console.Clear();
                    ModifyOrDelete.execute();
                    Console.Clear();
                    PrintOptions.execute();
                break;
                case "4":
                    // 4. See statistics for the entire database. 
                    Console.Clear();
                    StarStatistics.execute();
                    Console.Clear();
                    PrintOptions.execute();
                break;
                case "5":
                    // 5. Find stars by property. WIP
                    Console.Clear();
                    FindStarByProperty.execute();
                    Console.Clear();
                    PrintOptions.execute();
                break;
                case "6":
                    // 6. Randomly generate a new galaxy. 
                    Console.Clear();
                    GenerateGalaxy.execute();
                    Console.Clear();
                    PrintOptions.execute();
                break;
                case "7":
                    // 7. Exit program. 
                    exitLoop = true;
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                break;
            }
        }
    }
}