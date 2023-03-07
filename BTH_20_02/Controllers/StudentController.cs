using Microsoft.AspNetCore.Mvc;

namespace BTH_20_02.Controllers;

public class StudentController : Controller
{

    public IActionResult Index(){
        return View();
    }
    
    [HttpPost]
    public IActionResult Index(string FullName)
    {
        string strReturn = "Hello " + FullName;
        //Gui du lieu ve view
        ViewBag.thongbao = strReturn;
        return View();
    }
    
    public IActionResult About(){
        return View();
    }
}