using Microsoft.EntityFrameworkCore;

namespace mvc_com_docker.Models
{
    public static class Populadb
    {
        public static void IncluiDadosDB(IApplicationBuilder app)
        {
           IncluiDadosDB(app.ApplicationServices.GetRequiredService<AppDbContext>());
        }

        public static void IncluiDadosDB(AppDbContext context)
        {
            System.Console.WriteLine("Populando o banco de dados...");
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product { Name = "Luvas de goleiro", Price = 25, Category = "Futebol" },
                    new Product { Name = "Bola de basquete", Price = 49.95M, Category = "Basquete" },
                    new Product { Name = "Bola de Futebol", Price = 30.0M, Category = "Futebol" },
                    new Product { Name = "Meias Grandes", Price = 50, Category = "Futebol" },
                    new Product { Name = "Cesta para quadra", Price = 29.95M, Category = "Basquete" }
                );
                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Banco de dados já populado.");
            }
        }
    }
}
