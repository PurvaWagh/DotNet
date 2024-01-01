namespace DAL.Connected;
using BOL;
using MySql.Data.MySqlClient;

public class DBManager
{
    public static string conString = @"server=192.168.10.150; port=3306; user=dac31; password=welcome; database=dac31";

    public static List<Product> getAllProducts()
    {
        List<Product> list = new List<Product>();
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = conString;
        string query = "select * from product1";
        MySqlCommand command = new MySqlCommand(query, connection);
        try
        {
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product();
                product.Id = int.Parse(reader["Id"].ToString());
                product.Title = reader["Title"].ToString();
                product.Description = reader["Description"].ToString();
                product.Price = double.Parse(reader["Price"].ToString());
                list.Add(product);
            }
            reader.Close();


        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        finally
        {
            connection.Close();
        }
        return list;
    }

}

    


    