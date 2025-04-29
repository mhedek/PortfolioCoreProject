using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultServiceComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Services.Where(x => x.Status == true)
                .OrderByDescending(x => x.ServiceId)
                .Take(6)
                .ToList();
            return View(values);
        }
    }
}
