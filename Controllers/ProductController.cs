using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using BOL;
using DAL;
using BLL;
namespace Shop.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

 
      public IActionResult Product()
    {
       ProductManager pm = new ProductManager();
        List<Product> plist = new List<Product>();
        plist = pm.getProduct();
        ViewData["product"]=plist;

        return View();
    }

   
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() 
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
