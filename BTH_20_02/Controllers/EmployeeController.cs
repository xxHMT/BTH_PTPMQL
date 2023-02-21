using Microsoft.AspNetCore.Mvc;

namespace BTH_20_02.Controllers;

public class EmployeeController : Controller
{
    public IActionResult Hello ()
    {
        return View();
    }
    public IActionResult More()
    {
        return View();
    }
}