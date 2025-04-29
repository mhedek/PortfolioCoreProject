using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultIstatistikComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            Random random = new Random();
            var values = new Istatistik()
            {
                SkillCount = context.Skills.Count(),
                ProjectCount = context.Works.Count(),
                MessageCount = context.Messages.Count(),
                RandomNumber = random.Next(1,101)
            };
            return View(values);

        }
    }
}
