namespace BLL;
using DAL;
using BOL;
using Customers;

public class ProductManager
{
  public  ProductManager()
   {

   }
    public List<Product> getProduct()
    {
        List<Product> products = new List<Product>();
        products = DbManager.getAllProduct();
        return products;
    }

//     public List<Product> findById(int id)
//     {
//          Product products = new Product();
//          DbManager.GetProductById(12);
//     }

public static Product InsertPr(Product p){
    return p;
}

   public  List<Customer> getCustomer()
    {
        List<Customer> cust = new List<Customer>();
         cust = DbManager.getAllcustomer();
        return cust;
    }


}