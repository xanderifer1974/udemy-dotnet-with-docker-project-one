using System;

namespace mvc_com_docker.Models;

public interface IRepositoryProduct
{
    IEnumerable<Product> GetAll();
}
