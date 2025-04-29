using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreDay.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult Error404(int statusCode)
        {
            if (statusCode == 404)
            {
                return View("Error404");
            }

            return View();
        }
    }
}
