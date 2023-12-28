namespace DAL;

using System.Reflection.Metadata;
using BOL;
using Customers;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;

public static class DbManager
{
     public static string conString=@"server=192.168.10.150;port=3306;user=dac54; password=welcome;database=dac54";

    public static List<Product> getAllProduct()
    {
          List<Product> allproduct=new List<Product>();
          MySqlConnection con = new MySqlConnection();
          con.ConnectionString = conString;
          string query = "select * from ShopProduct";
          try
          {
            
                MySqlCommand cmd = new MySqlCommand(query,con);
                con.Open();
                MySqlDataReader reader=cmd.ExecuteReader();

                while (reader.Read())
                {
                    int pid = int.Parse(reader["pid"].ToString());
                    string pname = reader["pname"].ToString();
                    int qty = int.Parse(reader["quantity"].ToString());
                    double price = double.Parse(reader["price"].ToString());

                    Product p  = new Product
                    {
                        Product_id = pid,
                        Pname=pname,
                        Quantity=qty,
                        Price = price
                    };
                    allproduct.Add(p);
                }
          }
          catch (Exception ee)
          {
             Console.WriteLine(ee.Message);
          }finally{
                    con.Close();
            }
         return allproduct;
    }
    // public static Product GetProductById(int id){
    //   //
    //    Product  pr=null;
    //       MySqlConnection con = new MySqlConnection();
    //       con.ConnectionString = conString;
    //       string query = "select * from ShopProduct where pid="+id;
    //       try {
    //          MySqlCommand command = new MySqlCommand(query,con);
    //          con.Open();
    //          MySqlDataReader reader = command.ExecuteReader();
    //          if(reader.Read())
    //          {
    //            int id1 = int.Parse(reader["Product_id"].ToString());
    //             string name = reader["Pname"].ToString();
    //             int qty = int.Parse(reader["Quantity"].ToString());
    //             int p = int.Parse(reader["Price"].ToString());
    //              pr = new Product
    //             {
    //                 Product_id = id1,
    //                 Pname = name,
    //                 Quantity = qty,
    //                 Price=p
    //             };
    //          }
    //       }catch(Exception e)
    //       {
    //              Console.WriteLine( e.Message);
    //       }

    //       return pr;
    // }

    public static void InsertData(Product p)
    {
      
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString=conString;
        string query= "insert into ShopProduct values(@id,@pname,@qty,@price);";
        MySqlCommand cmd = new MySqlCommand(query,con);
        cmd.Parameters.AddWithValue("@id",p.Product_id);
        cmd.Parameters.AddWithValue("@pname",p.Pname);
        cmd.Parameters.AddWithValue("@qty",p.Quantity);
        cmd.Parameters.AddWithValue("@price",p.Price);

    try{
        con.Open();
        cmd.ExecuteNonQuery();
    }catch(Exception e)
    {
        Console.WriteLine(e);
    }finally{
        con.Close();
    }
    }

    //db for customer 
     public static List<Customer> getAllcustomer()
    {
          List<Customer> allcustomer=new List<Customer>();
          MySqlConnection con = new MySqlConnection();
          con.ConnectionString = conString;
          string query = "select * from register";
          try
          {
            
                MySqlCommand cmd = new MySqlCommand(query,con);
                con.Open();
                MySqlDataReader reader=cmd.ExecuteReader();

                while (reader.Read())
                {
                    string username = reader["username"].ToString();
                    string pass = reader["password"].ToString();
                    string nm = reader["name"].ToString();

                    Customer p  = new Customer
                    {
                        Username = username,
                        Password=pass,
                        Name=nm,
                    };
                    allcustomer.Add(p);
                }
          }
          catch (Exception ee)
          {
             Console.WriteLine(ee.Message);
          }finally{
                    con.Close();
            }
         return allcustomer;
    }
}