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
       
       
    }

    public IActionResult Index()
    {
        var hostname = _httpContextAccessor.HttpContext?.Request.Host.Value;
        ViewBag.Hostname = hostname;
        ViewBag.Message = $"Docker - ({hostname}) - ASP.NET Core MVC with Docker";
        return View(_repositoryProduct.GetAll());
    }

}
