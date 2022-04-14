using System;
using System.Data.SqlClient;

public class StarStatistics{
    public static void execute(){
            SqlConnection entry = new SqlConnection(Login.connection);
            SqlCommand readStar = new SqlCommand("select * from stars", entry);
            SqlDataReader reader = null;

            int numOfStars = 0;
            int numOfWhite = 0;
            int numOfBlue = 0;
            int numOfYellow = 0;
            int numOfOrange = 0;
            int numOfRed = 0;
            int numLarger = 0;
            int numSmaller = 0;
            double x = 0;
            double y = 0;
            double z = 0;
            double totalDist = 0;
            double avgDist = 0;

            entry.Open();
            reader = readStar.ExecuteReader();

            while(reader.Read()){
                numOfStars++;
                if(reader[5].ToString() == "white"){numOfWhite++;}
                else if(reader[5].ToString() == "blue"){numOfBlue++;}
                else if(reader[5].ToString() == "yellow"){numOfYellow++;}
                else if(reader[5].ToString() == "orange"){numOfOrange++;}
                else if(reader[5].ToString() == "red"){numOfRed++;}
                if(Convert.ToDouble(reader[6])>1){numLarger++;}
                else if(Convert.ToDouble(reader[6])<1){numSmaller++;}

                x = Convert.ToDouble(reader[2]);
                y = Convert.ToDouble(reader[3]);
                z = Convert.ToDouble(reader[4]);
                totalDist = totalDist + Math.Sqrt((x*x)+(y*y)+(z*z));
            }

            avgDist = totalDist / numOfStars;

            entry.Close();

            Console.WriteLine("There are a total of " + numOfStars + " stars recorded in the database.");
            Console.WriteLine(
                numOfWhite + " (" + (100*numOfWhite/numOfStars) + "%) are white, " + 
                numOfBlue + " (" + (100*numOfBlue/numOfStars) + "%) are blue, " + 
                numOfYellow + " (" + (100*numOfYellow/numOfStars) + "%) are yellow, " + 
                numOfOrange + " (" + (100*numOfOrange/numOfStars) + "%) are orange, and " + 
                numOfRed + " (" + (100*numOfRed/numOfStars) + "%) are red."
            );
            Console.Write(numLarger + " (" + (100*numLarger/numOfStars) + "%) are larger than the sun. ");
            Console.WriteLine(numSmaller + " (" + (100*numSmaller/numOfStars) + "%) are smaller than the sun.");
            Console.WriteLine("The average star is " + String.Format("{0:.###}", avgDist) + " light years away from Earth.");
            Console.WriteLine();
            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        
    }

}