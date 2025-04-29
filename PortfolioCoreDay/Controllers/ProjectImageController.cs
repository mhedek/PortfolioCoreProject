using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.Controllers
{
    public class ProjectImageController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult ProjectImageList()
        {
            var values = context.ProjectImages.ToList();
            return View(values);
        }
    }
}
