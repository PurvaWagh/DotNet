namespace Customers;
public class Customer
{
    public string Username{get;set;}
    public string Password{get;set;}
    public string Name{get;set;}
    
    public Customer()
    {
        Username=null;
        Password=null;
        Name=null;
    }
        public Customer(string un, string pass, string nm)
    {
        Username=un;
        Password=pass;
        Name=nm;
    }
     public override string ToString()
    {
        return "user name"+Username+"Pass " + Password+" name "+Name;
    }
    
}