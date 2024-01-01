namespace BLL;
using BOL;
using DAL.Connected;
public class CatalogManager
{

    public List<Product> getAllProducts()
    {
        List<Product> allProducts = new List<Product>();
        allProducts = DBManager.getAllProducts();
        return allProducts;

    }

    public Product GetProduct(int id)
    {
        Console.WriteLine(id);
        List<Product> allProducts = DBManager.getAllProducts();
        Product product = allProducts.Find((product) => product.Id == id);
        return product;
    }

}