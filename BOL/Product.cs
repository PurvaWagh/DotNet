using System.Data.Common;

namespace BOL;

public class Product
{
    public int Product_id{get;set;}
    public string Pname{get;set;}
    public int Quantity{get;set;}
    public double Price{get;set;}
   
   public Product()
   {
    Product_id=1;
    Pname="pranav";
    Quantity=2;
    Price=324;
   }

   public Product(int Pid,string Pname,int Quantity,double Price)
   {
    Product_id=Pid;
    this.Pname=Pname;
    this.Quantity=Quantity;
    this.Price=Price;
   }
    public override string ToString()
    {
        return "Id "+Product_id+"Product Name " + Pname+" Quantity "+Quantity+" Price "+Price;
    }

}