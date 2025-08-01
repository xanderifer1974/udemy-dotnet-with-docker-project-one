using System;

namespace mvc_com_docker.Models;

public class ProductRepository: IRepositoryProduct
{

    private AppDbContext context;
    public ProductRepository(AppDbContext context)
    {
        this.context = context;
    }
    public IEnumerable<Product> products
    {
        get
        {
            return context.Products.ToList();
        }
    }   

    public IEnumerable<Product> GetAll()
    {
        return products;
    }

}
