namespace BLL;
using DAL;
using BOL;

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


    public List<Product> findById(int id)
    {
 Product products = new Product();
         DbManager.GetProductById(12);
    
    }
}