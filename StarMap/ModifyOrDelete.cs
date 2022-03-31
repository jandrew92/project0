using System;
using System.Data.SqlClient;

public class ModifyOrDelete{
    public static void execute(){
        bool exitLoop = false;
        string newName;
        double newX;
        double newY;
        double newZ;
        double newSize;
        string newColor;

        Console.WriteLine("Please input the ID of the star you wish to access and press the Enter key.");
        string IDnum = Console.ReadLine();

        SqlConnection entry = new SqlConnection(@"server=DESKTOP-5M7ISTP\JUSTIN_INSTANCE;database=StarMapDB;User Id=" + Login.username + ";Password=" + Login.password + ";");
        SqlCommand nameStar = new SqlCommand("update stars set name = @name where id=@idno", entry);
        SqlCommand xStar = new SqlCommand("update stars set x = @x where id=@idno", entry);
        SqlCommand yStar = new SqlCommand("update stars set y = @y where id=@idno", entry);
        SqlCommand zStar = new SqlCommand("update stars set z = @z where id=@idno", entry);
        SqlCommand sizeStar = new SqlCommand("update stars set size = @size where id=@idno", entry);
        SqlCommand colorStar = new SqlCommand("update stars set color = @color where id=@idno", entry);
        SqlCommand deleteStar = new SqlCommand("delete from stars where id=@idno", entry);
        nameStar.Parameters.AddWithValue("@idno", IDnum);
        xStar.Parameters.AddWithValue("@idno", IDnum);
        yStar.Parameters.AddWithValue("@idno", IDnum);
        zStar.Parameters.AddWithValue("@idno", IDnum);
        sizeStar.Parameters.AddWithValue("@idno", IDnum);
        colorStar.Parameters.AddWithValue("@idno", IDnum);
        deleteStar.Parameters.AddWithValue("@idno", IDnum);
            
        while(!exitLoop){
            StarLookupID.execute(IDnum);
            entry.Open();
            Console.WriteLine("Which property would you like to modify?");
            Console.WriteLine("Type a number and press the Enter key to select an option.");
            Console.WriteLine("");
            Console.WriteLine("1. Name");
            Console.WriteLine("2. Coordinates");
            Console.WriteLine("3. Size");
            Console.WriteLine("4. Color");
            Console.WriteLine("5. Delete the star from the database.");
            Console.WriteLine("6. Return to previous menu.");
            string selection = Console.ReadLine();
            switch(selection){
                case "1":
                    Console.Clear();
                    Console.WriteLine("Please input the new name and press the Enter key.");
                    Console.WriteLine("The name can have a maximum of fifty characters.");
                    newName = Console.ReadLine();
                        while(newName.Length > 51){
                            Console.Clear(); 
                            Console.WriteLine("Invalid input. The name can have a maximum of fifty characters.");
                            Console.WriteLine("Please input the star's name, and press the Enter key.");
                            newName = Console.ReadLine();
                        }
                    nameStar.Parameters.AddWithValue("@name", newName);
                    nameStar.ExecuteNonQuery();
                break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Please input the new X coordinate and press the Enter key.");
                    while(!exitLoop){
                        try{
                            newX = double.Parse(Console.ReadLine());
                            xStar.Parameters.AddWithValue("@x", newX);
                            xStar.ExecuteNonQuery();
                            exitLoop = true;
                        }
                        catch(FormatException e){
                            Console.WriteLine(e.Message + " Please try again.");
                        }
                    }
                    exitLoop = false;
                    Console.Clear();
                    
                    Console.WriteLine("Please input the new Y coordinate and press the Enter key.");
                    while(!exitLoop){
                        try{
                            newY = double.Parse(Console.ReadLine());
                            yStar.Parameters.AddWithValue("@y", newY);
                            yStar.ExecuteNonQuery();
                            exitLoop = true;
                        }
                        catch(FormatException e){
                            Console.WriteLine(e.Message + " Please try again.");
                        }
                    }
                    exitLoop = false;
                    Console.Clear();
                    
                    Console.WriteLine("Please input the new Z coordinate and press the Enter key.");
                    while(!exitLoop){
                        try{
                            newZ = double.Parse(Console.ReadLine());
                            zStar.Parameters.AddWithValue("@z", newZ);
                            zStar.ExecuteNonQuery();
                            exitLoop = true;
                        }
                        catch(FormatException e){
                            Console.WriteLine(e.Message + " Please try again.");
                        }
                    }
                    exitLoop = false;
                    Console.Clear();
                break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Please input the new size and press the Enter key.");
                    while(!exitLoop){
                        try{
                            newSize = double.Parse(Console.ReadLine());
                            if(newSize>0){
                                sizeStar.Parameters.AddWithValue("@size", newSize);
                                sizeStar.ExecuteNonQuery();
                                exitLoop = true;
                            }
                            else{Console.WriteLine("The size must be larger than 0. Please try again.");}
                        }
                        catch(FormatException e){
                            Console.WriteLine(e.Message + " Please try again.");
                        }
                    }
                    exitLoop = false;
                break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Please input the new color and press the Enter key.");
                    Console.WriteLine("Valid options are white, blue, yellow, orange, or red.");
                    while(!exitLoop){
                        try{    
                            newColor = Console.ReadLine();
                            if(newColor == "white" || newColor == "blue" || newColor == "yellow" || newColor == "orange" || newColor == "red"){
                                colorStar.Parameters.AddWithValue("@color", newColor);
                                colorStar.ExecuteNonQuery();
                                Console.Clear();
                                exitLoop=true;
                            }
                            else{Console.WriteLine("Invalid input. Please try again.");}
                        }
                        catch(FormatException e){
                            Console.WriteLine(e.Message + " Please try again.");
                        }
                    }
                    exitLoop = false;
                break;
                case "5":
                    Console.Clear();
                    if(IDnum == "1"){Console.WriteLine("You cannot delete the Earth!");}
                    else{
                        deleteStar.ExecuteNonQuery();
                        exitLoop = true;
                        Console.WriteLine("The selected star has been deleted from the database.");
                    }
                    Console.WriteLine("Please press the Enter key to continue.");
                    Console.ReadLine();
                    Console.Clear();
                break;
                case "6":
                    exitLoop = true;
                    Console.Clear();
                break;
                default:
                    Console.Clear(); 
                    Console.WriteLine("Invalid input. Please try again.");
                break;
            }
            entry.Close();
        }
    }
}