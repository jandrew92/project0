using System;
using System.Data.SqlClient;

public class StarLookupID{
    public static void execute(){
        bool exitLoop = false;
        while(!exitLoop){
            Console.Clear();
            Console.WriteLine("Please input the ID Number of the star you wish to look up.");
            string IDnum = Console.ReadLine();
            
            SqlConnection entry = new SqlConnection(@"server=DESKTOP-5M7ISTP\JUSTIN_INSTANCE;database=StarMapDB;User Id=" + Login.username + ";Password=" + Login.password + ";");
            SqlCommand readStar = new SqlCommand("select * from stars where id=@idno", entry);
            readStar.Parameters.AddWithValue("@idno", IDnum);
            SqlDataReader reader = null;
            
            try {
                entry.Open();
                reader = readStar.ExecuteReader();
                while (reader.Read()){
                    Console.WriteLine("ID: " + reader[0]);
                    Console.WriteLine("The star " + reader[1] + " is a " + reader[5] + " star, " + String.Format("{0:0.###}", reader[6]) + " times bigger than the sun.");
                    double x = Convert.ToDouble(reader[2]);
                    double y = Convert.ToDouble(reader[3]);
                    double z = Convert.ToDouble(reader[4]);
                    double dist = Math.Sqrt((x*x)+(y*y)+(z*z));
                    if(x==0 && y==0 && z==0){Console.WriteLine("This is the home planet of humanity. You live here!");}
                    else{
                        Console.WriteLine("It is at coordinates (" + String.Format("{0:0.###}", reader[2]) + ", " + String.Format("{0:0.###}", reader[3]) + ", " + String.Format("{0:0.###}", reader[4]) + ").");
                        Console.WriteLine(reader[1] + " is " + String.Format("{0:0.###}", dist) + " light years away from Earth.");
                    }
                    Console.WriteLine();
                }
                exitLoop = true;
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
            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        }
    }
    public static void execute(string IDnum){
        bool exitLoop = false;
        while(!exitLoop){            
            SqlConnection entry = new SqlConnection(@"server=DESKTOP-5M7ISTP\JUSTIN_INSTANCE;database=StarMapDB;User Id=" + Login.username + ";Password=" + Login.password + ";");
            SqlCommand readStar = new SqlCommand("select * from stars where id=@idno", entry);
            readStar.Parameters.AddWithValue("@idno", IDnum);
            SqlDataReader reader = null;
            
            try {
                entry.Open();
                reader = readStar.ExecuteReader();
                while (reader.Read()){
                    Console.WriteLine("ID: " + reader[0]);
                    Console.WriteLine(reader[1] + " is a " + reader[5] + " star, " + String.Format("{0:0.###}", reader[6]) + " times bigger than the sun.");
                    double x = Convert.ToDouble(reader[2]);
                    double y = Convert.ToDouble(reader[3]);
                    double z = Convert.ToDouble(reader[4]);
                    double dist = Math.Sqrt((x*x)+(y*y)+(z*z));
                    if((x+y+z)==0){Console.WriteLine("This is the home planet of humanity. You live here!");}
                    else{
                        Console.WriteLine("It is at coordinates (" + String.Format("{0:0.###}", reader[2]) + ", " + String.Format("{0:0.###}", reader[3]) + ", " + String.Format("{0:0.###}", reader[4]) + ").");
                        Console.WriteLine(reader[1] + " is " + String.Format("{0:0.###}", dist) + " light years away from Earth.");
                    }
                    Console.WriteLine();
                }
                exitLoop = true;
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
                    Console.WriteLine("Please input the ID of the star you wish to modify and press the Enter key.");
                    IDnum = Console.ReadLine();
                }
            }
        }
    }
}