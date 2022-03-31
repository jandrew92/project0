using System;
using System.Data.SqlClient;

public class Login{

    public static string username;
    public static string password;
    public static void execute(){
        bool exitLoop = false;
        while(!exitLoop){
            Console.Clear();
            Console.WriteLine("Input your username and press the enter key.");
            username = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Input your password and press the enter key.");
            password = Console.ReadLine();
            Console.Clear();

            SqlConnection entry = new SqlConnection(@"server=DESKTOP-5M7ISTP\JUSTIN_INSTANCE;database=StarMapDB;User Id=" + Login.username + ";Password=" + Login.password + ";");
            SqlCommand loginCount = new SqlCommand("select count(*) from stars", entry);
            
            try{
                entry.Open();
                int loginCheck = (int)loginCount.ExecuteScalar();
                exitLoop = true;
            }
            catch(SqlException){
                Console.WriteLine("Login failed! Try again.");
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
                exitLoop = false;
            }
            finally {
                entry.Close();
                if(exitLoop){
                    Console.WriteLine("Login successful!");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
            }            
        }
    }
}