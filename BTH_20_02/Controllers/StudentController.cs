using Microsoft.AspNetCore.Mvc;

namespace BTH_20_02.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult About(){
        return View();
    }
}