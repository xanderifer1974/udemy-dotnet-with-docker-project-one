using Microsoft.AspNetCore.Mvc;
using mvc_com_docker.Models;

namespace mvc_com_docker.Controllers;

public class HomeController : Controller
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IRepositoryProduct _repositoryProduct;
    private string message;

    public HomeController(IRepositoryProduct repositoryProduct, 
                          IHttpContextAccessor httpContextAccessor, 
                          ILogger<HomeController> logger)
    {
        _repositoryProduct = repositoryProduct;
        _httpContextAccessor = httpContextAccessor;
        var hostname = _httpContextAccessor.HttpContext?.Request.Host.Value;
        message = $"Docker - ({hostname}) - ASP.NET Core MVC with Docker";
       
    }   
    
    public IActionResult Index()
    {
        ViewBag.Message = message;

        return View(_repositoryProduct.GetAll());
    }
    
}
