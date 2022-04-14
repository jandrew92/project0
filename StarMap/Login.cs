using System;
using System.Data.SqlClient;

public class Login{
    public static string connection;
    public static void execute(){
        bool exitLoop = false;
        var reader = new System.Xml.Serialization.XmlSerializer(typeof(String));
        var file = new System.IO.StreamReader(@".\ConnectionString.xml");
        string c = (String)reader.Deserialize(file);
        file.Close();
        string username;
        string password;
        while(!exitLoop){

            Console.Clear();
            Console.WriteLine("Input your username and press the enter key.");
            username = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Input your password and press the enter key.");
            password = Console.ReadLine();
            Console.Clear();

            Login.connection = c + "User Id=" + username + ";Password=" + password + ";";

            SqlConnection entry = new SqlConnection(Login.connection);
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