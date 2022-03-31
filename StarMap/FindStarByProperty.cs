using System;
using System.Data.SqlClient;

public class FindStarByProperty{
    public static void execute(){
        double min = 0;
        double max;
        string color;
        bool exitLoop = false;

        SqlConnection entry = new SqlConnection(@"server=DESKTOP-5M7ISTP\JUSTIN_INSTANCE;database=StarMapDB;User Id=" + Login.username + ";Password=" + Login.password + ";");
        SqlCommand seekStars = new SqlCommand("select * from stars where color=@starColor and size>@minSize and size<@maxSize", entry);
        SqlDataReader reader = null;
        /*
        @starColor
        @minSize
        @maxSize
        */

        Console.Clear();
        Console.WriteLine("You may look up stars based on their properties.");
        Console.WriteLine("Please input each required property, and press the Enter key.");
        Console.WriteLine("");

        Console.WriteLine("Minimum Star Size:");
            while(!exitLoop){
                try{
                    min = double.Parse(Console.ReadLine());
                    if(min>=0){
                        seekStars.Parameters.AddWithValue("@minSize", min);
                        exitLoop = true;
                    }
                    else{Console.WriteLine("The minimum star size must be larger than zero. Please try again.");}
                }
                catch(FormatException e){
                    Console.WriteLine(e.Message + " Please try again.");
                }
            }
            exitLoop = false;

        Console.WriteLine("Maximum Star Size:");
            while(!exitLoop){
                try{
                    max = double.Parse(Console.ReadLine());
                    if(max>min){
                        seekStars.Parameters.AddWithValue("@maxSize", max);
                        exitLoop = true;
                    }
                    else{Console.WriteLine("The maximum must be larger than the minimum. Please try again.");}
                }
                catch(FormatException e){
                    Console.WriteLine(e.Message + " Please try again.");
                }
            }
            exitLoop = false;

        Console.WriteLine("Star Color:");
        while(!exitLoop){
            try{
                color = Console.ReadLine();
                if(color == "white" || color == "blue" || color == "yellow" || color == "orange" || color == "red"){
                    seekStars.Parameters.AddWithValue("@starColor", color);
                    exitLoop = true;
                }
                else{Console.WriteLine("The valid colors are white, blue, yellow, orange, and red. Please try again.");}
            }
            catch(FormatException e){
                Console.WriteLine(e.Message + " Please try again.");
            }
        }
        exitLoop = false;
        
        Console.Clear();

        Console.WriteLine("The following stars match your criteria:");
        Console.WriteLine();
            try {
                entry.Open();
                reader = seekStars.ExecuteReader();
                while (reader.Read()){
                    double x = Convert.ToDouble(reader[2]);
                    double y = Convert.ToDouble(reader[3]);
                    double z = Convert.ToDouble(reader[4]);
                    double dist = Math.Sqrt((x*x)+(y*y)+(z*z));
                    Console.WriteLine("ID: " + reader[0]);
                    Console.WriteLine("Name: " + reader[1]);
                    Console.WriteLine("Color: " + reader[5]);
                    Console.WriteLine("Size: " + String.Format("{0:0.###}", reader[6]) + " sols");
                    Console.WriteLine("Coordinates: (" + String.Format("{0:0.###}", reader[2]) + ", " + String.Format("{0:0.###}", reader[3]) + ", " + String.Format("{0:0.###}", reader[4]) + ")");
                    Console.WriteLine("Distance: " + String.Format("{0:0.###}", dist) + " ly");
                    exitLoop = true;
                    Console.WriteLine();
                }
            }
            catch(SqlException e){
                Console.WriteLine(e.Message);
                Console.WriteLine("Sorry, there was an error.");
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
            }
            finally {
                entry.Close();
                if(!exitLoop){
                    Console.WriteLine("Invalid input.");
                    Console.WriteLine("Do you wish to continue? Type a number and press the Enter key to select an option.");
                    Console.WriteLine("1. Return to main menu.");
                    Console.WriteLine("2. Try again.");
                    int exitNum = Convert.ToInt32(Console.ReadLine());
                    if(exitNum==1){exitLoop=true;}
                }
            }

        Console.WriteLine("Please press the Enter key to return to the main menu.");
        Console.ReadLine();
        Console.Clear();
    }

}