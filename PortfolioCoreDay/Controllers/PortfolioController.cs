using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult PortfolioList()
        {
            var values = context.Portfolios.Include(x=> x.category).ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            var values = new SelectList(context.Categories.ToList(), "CategoryId","CategoryName");
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio portfolio)
        {
            context.Portfolios.Add(portfolio);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
        public IActionResult DeletePortfolio(int id)
        {
            var value = context.Portfolios.Find(id);
            context.Portfolios.Remove(value);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
    }
}
