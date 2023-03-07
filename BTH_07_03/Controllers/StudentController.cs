using Microsoft.AspNetCore.Mvc;


namespace BTH_07_03.Controllers;

public class StudentController : Controller
{

    public IActionResult TinhTong()
    {
        return View();
    }
    [HttpPost]
    public IActionResult TinhTong(string Number)
    {
        int so = Convert.ToInt32(Number);
        int tong = 0;
        while (so > 0)
        {

            tong = tong + so % 10;
            so = so / 10;
        }

        ViewBag.Sum = tong;

        return View();
    }

    public IActionResult GiaiPhuongTrinhBac2(string HeSoA, string HeSoB, string HeSoC)
    {
        //khai báo biến

        double delta, x1, x2, a = 0, b = 0, c = 0;
        string ketqua;

        //Giải phương trình bậc 2
        if (!String.IsNullOrEmpty(HeSoA)) a = Convert.ToDouble(HeSoA);
        if (!String.IsNullOrEmpty(HeSoB)) b = Convert.ToDouble(HeSoB);
        if (!String.IsNullOrEmpty(HeSoC)) c = Convert.ToDouble(HeSoC);

        //Kiểm tra xem có phải phương trình bậc 2 không
        if (a == 0) ketqua = "Không phải phương trình bậc 2";
        else
        {
            //Tính delta
            delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta < 0) ketqua = "Phương trình vô nghiệm";
            else if (delta == 0)
            {
                x1 = -b / (2 * a);
                ketqua = "Phương trình có nghiệm kép = " + x1;
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                ketqua = "Phương trình có 2 nghiệm phân biệt x1 = " + x1 + " và x2 = " + x2;
            }
        }
        ViewBag.ketqua = ketqua;
        return View();
    }
}