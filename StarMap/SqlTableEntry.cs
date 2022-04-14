using System;
using System.Data.SqlClient;

public class SqlTableEntry{

    public static void execute(string name, double x, double y, double z, double size, string color){
        SqlConnection entry = new SqlConnection(Login.connection);
        SqlCommand addStar = new SqlCommand("insert into stars (name, x, y, z, size, color) values (@name, @x, @y, @z, @size, @color);", entry);
        addStar.Parameters.AddWithValue("@name", name);
        addStar.Parameters.AddWithValue("@x", x);
        addStar.Parameters.AddWithValue("@y", y);
        addStar.Parameters.AddWithValue("@z", z);
        addStar.Parameters.AddWithValue("@size", size);
        addStar.Parameters.AddWithValue("@color", color);
        try {
            entry.Open();
            addStar.ExecuteNonQuery();
        }
        catch(SqlException e){
            Console.WriteLine(e.Message);
        }
        finally {
            entry.Close();
        }
    }
}