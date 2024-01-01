using BLL;
using BOL;
using Microsoft.AspNetCore.Mvc;
namespace ReactWithWebAPIApp.Controllers;
[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;
    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    public IEnumerable<Product> get()
    {
        CatalogManager mgr = new CatalogManager();
        List<Product> products = mgr.getAllProducts();
        return products.ToArray();
    }

    [HttpGet("getbyid/{id?}")]
    public Product getbyid(int id)
    {
        Console.WriteLine(id);
        CatalogManager ct = new CatalogManager();
        Product p = ct.GetProduct(id);
        return p;
    }

}