namespace BOL;

public class Product
{
    public int Id { set; get; }
    public string Title { set; get; }
    public string Description { set; get; }
    public double Price { set; get; }

    public Product()
    {

    }

    public Product(int id, string title, string description, double price)
    {
        this.Id = id; ;
        this.Title = title;
        this.Description = description;
        this.Price = price;
    }

}