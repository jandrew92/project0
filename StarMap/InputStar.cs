using System;

public class InputStar{
    public static void execute(){
        Console.WriteLine("Please input the star's name, and press the Enter key.");
        Console.WriteLine("The name can have a maximum of fifty characters.");
        string name = Console.ReadLine();
        while(name.Length > 51){
            Console.WriteLine("Invalid input. The name can have a maximum of fifty characters.");
            Console.WriteLine("Please input the star's name, and press the Enter key.");
            name = Console.ReadLine();
        }
        Console.WriteLine("Coordinates are measured in light-years, and (0,0,0) is the position of Earth.");
        Console.WriteLine("Please input the star's X coordinate, and press the Enter key.");
        double x = 0;
        while(x == 0){
            try{x = double.Parse(Console.ReadLine());}
            catch(FormatException e){
                Console.WriteLine(e.Message + " Please try again.");
            }
        }
        Console.WriteLine("Please input the star's Y coordinate, and press the Enter key.");
        double y = 0;
        while(y == 0){
            try{y = double.Parse(Console.ReadLine());}
            catch(FormatException e){
                Console.WriteLine(e.Message + " Please try again.");
            }
        }
        Console.WriteLine("Please input the star's Z coordinate, and press the Enter key.");
        double z = 0;
        while(z == 0){
            try{z = double.Parse(Console.ReadLine());}
            catch(FormatException e){
                Console.WriteLine(e.Message + " Please try again.");
            }
        }
        Console.WriteLine("Please input the star's size as a proportion of the Sun's size, and press the Enter key.");
        Console.WriteLine("(For example, a size of '3' means the star is 3 times bigger than the sun.)");
        double size = 0;
        while(size == 0){
            try{size = double.Parse(Console.ReadLine());}
            catch(FormatException e){
                Console.WriteLine(e.Message + " Please try again.");
            }
            if(size < 0){
                Console.WriteLine("Invalid input. The size must be a positive number. Please try again."); 
                size = 0;
            }
        }
        Console.WriteLine("Please input the star's color, and press the Enter key.");
        Console.WriteLine("Valid colors are blue, white, yellow, orange, and red.");
        string color = "null";
        while(color == "null"){
            string tempColor = Console.ReadLine();
            tempColor = tempColor.ToLower();
            if(tempColor == "blue" || tempColor == "white" || tempColor == "orange" || tempColor == "yellow" || tempColor == "red" ){
                color = tempColor;
            }
            else{Console.WriteLine("Invalid input. Please try again.");}
        }

        SqlTableEntry.execute(name,x,y,z,size,color);

        Console.WriteLine("");
        Console.WriteLine("The star " + name + " is at cordinates " + "(" + x + ", " + y + ", " + z + ")");
        Console.WriteLine(name + " is a " + color + " star, " + size + " times bigger than the sun.");
        Console.WriteLine("");
        Console.WriteLine("Your record has been successfully added to the database.");
        Console.WriteLine("Please press the Enter key to return to the main menu.");
        Console.ReadLine();
    }
    public static void execute(string name, double x, double y, double z, double size, string color){
        SqlTableEntry.execute(name,x,y,z,size,color);
    }
}