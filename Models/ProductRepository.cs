using System;

namespace mvc_com_docker.Models;

public class ProductRepository: IRepositoryProduct
{
    private List<Product> products = new List<Product>
    {
        new Product(1, "Product A", "Category 1", 10.99m),
        new Product(2, "Product B", "Category 2", 20.99m),
        new Product(3, "Product C", "Category 1", 30.99m)
    };

    public IEnumerable<Product> GetAll()
    {
        return products;
    }

}
