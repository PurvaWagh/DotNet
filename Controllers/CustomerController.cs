using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using BOL;
using DAL;
using BLL;
using Customers;
namespace Shop.Controllers;

public class CustomerController : Controller
{
    private readonly ILogger<CustomerController> _logger;


    public IActionResult Product()
    {
        ProductManager pm = new ProductManager();
        List<Product> plist = new List<Product>();
        plist = pm.getProduct();
        ViewData["product"] = plist;

        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Welcome()
    {
        
        return View();
     
    }

     public IActionResult Login()
    {

        return View();
    }
        [HttpPost]
    public IActionResult Login(string username, string password)
    {
         ProductManager pm = new ProductManager();
         List<Customer> plist = new List<Customer>();
         plist =pm.getCustomer();
       foreach (Customer item in plist)
       {
        Console.WriteLine(item);
       }
        if(username=="pranav" && password=="pranav")
        {
          return Redirect("/Product/Product");
        }
     

        return View();
    }
    public IActionResult Register()
    {
        return View();
    }

}