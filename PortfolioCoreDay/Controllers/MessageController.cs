using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class MessageController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult ListMessage()
        {
            var values = context.Messages.ToList();
            return View(values);
        }

    }
}
