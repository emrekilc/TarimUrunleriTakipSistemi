using Microsoft.AspNetCore.Mvc;

public class ProductsController : Controller
{
    public IActionResult Shop()
    {
        return View();
    }
}
