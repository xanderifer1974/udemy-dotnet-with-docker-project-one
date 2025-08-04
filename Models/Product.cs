namespace mvc_com_docker.Models;

public class Product
{
    public Product(int id, string? name, string? category, decimal price)
    {
        Id = id;
        Name = name;
        Category = category;
        Price = price;
    }

    public Product(string name, string category, string price)
    {
        this.Name = name;
        this.Category = category;
        if (decimal.TryParse(price, out decimal parsedPrice))
        {
            this.Price = parsedPrice;
        }
        else
        {
            throw new ArgumentException("Invalid price format");
        }
    }

    public Product() {   }
    
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Category { get; set; }
    public decimal Price { get; set; } 

    public override string ToString()
    {
        return $"{Id} - {Name} - {Category} - {Price:C}";
    }
   

}
