using Microsoft.AspNetCore.Mvc;

namespace NamEcommerce.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
